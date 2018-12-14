using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KeyboardWitchcraftAndKeyFuckery.WinAPI;

namespace KeyboardWitchcraftAndKeyFuckery.DTO
{
    public class KeyManager
    {
        public class KeyStatsEventArgs : EventArgs
        {
            public KeyStatistics Statistics { get; private set; }
            public KeyReplacement Replacement { get; private set; }

            public KeyStatsEventArgs(KeyReplacement replacement, KeyStatistics statistics)
            {
                Replacement = replacement;
                Statistics = statistics;
            }
        }

        public event EventHandler<KeyStatsEventArgs> Replaced;
        public event EventHandler<KeyStatsEventArgs> Hit;
        public IEnumerable<KeyReplacement> Replacements { get { return replacements; } }
        public IEnumerable<KeyStatistics> Statistics { get { return statistics.Values; } }
        public IntPtr IgnoreHwnd { get; set; }

        private Dictionary<KeyReplacement, KeyStatistics> statistics;
        private List<KeyReplacement> replacements;
        private IntPtr hHook;
        private HookProc hookProc;

        public KeyManager()
        {
            hHook = IntPtr.Zero;
            hookProc = null;
            statistics = new Dictionary<KeyReplacement, KeyStatistics>();
            replacements = new List<KeyReplacement>();
        }

        public void Load(string file)
        {
            using (var reader = new StreamReader(file))
            {
                var save = JsonConvert.DeserializeObject<KeyReplacement[]>(reader.ReadToEnd());
                var newReplacements = save.Except(replacements);
                foreach (var rep in newReplacements)
                    AddReplacement(rep);
            }
        }

        public void Save(string file)
        {
            using (var writer = new StreamWriter(file))
            {
                writer.Write(JsonConvert.SerializeObject(replacements));
            }
        }

        public void AddReplacement(KeyReplacement key)
        {
            if (replacements.Any(x => x.Equals(key)))
                throw new Exception($"Replacement \"{key.ToString()}\" already exists");

            replacements.Add(key);
            statistics.Add(key, new KeyStatistics());
        }

        public void RemoveReplacement(KeyReplacement key)
        {
            if (!replacements.Contains(key))
                throw new Exception($"Replacement \"{key.ToString()}\" not found");

            replacements.Remove(key);
            statistics.Remove(key);
        }

        public KeyReplacement GetReplacement(Keys key, bool shift, bool alt, bool ctrl)
        {
            return replacements.FirstOrDefault(x => 
                x.Key == key &&
                x.ShiftActive == shift &&
                x.AltActive == alt &&
                x.ControlActive == ctrl);
        }

        public void Hook()
        {
            hookProc = new HookProc(this.LowLevelKeyboardProc);
            using (var proc = Process.GetCurrentProcess())
            {
                using (var module = proc.MainModule)
                {
                    hHook = SetWindowsHookEx(HookType.WH_KEYBOARD_LL, hookProc, module.BaseAddress, 0);
                    Debug.WriteLine(hHook.ToInt64());
                }
            }
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(hHook);
        }

        private IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WM.KEYDOWN || wParam == (IntPtr)WM.KEYUP) && (IgnoreHwnd != IntPtr.Zero && GetForegroundWindow() != IgnoreHwnd))
            {
                KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
                bool shift = IsKeyDown(Keys.Shift) || IsKeyDown(Keys.ShiftKey);
                bool alt = IsKeyDown(Keys.Menu);
                bool ctrl = IsKeyDown(Keys.Control) || IsKeyDown(Keys.ControlKey);

                var replacement = GetReplacement((Keys)kbd.vkCode, shift, alt, ctrl);
                if (replacement == null)
                    return CallNextHookEx(hHook, nCode, wParam, lParam);
                var stats = statistics[replacement];
                stats.Hits++;
                Hit?.Invoke(this, new KeyStatsEventArgs(replacement, stats));
                if (replacement.Replacement != Keys.None)
                {
                    var input = new INPUT();
                    input.type = INPUT_TYPE.INPUT_KEYBOARD;
                    input.ki.wVk = (short)replacement.Replacement;
                    input.ki.wScan = (short)MapVirtualKeyA((uint)replacement.Replacement, MapVirtualKeyMapTypes.MAPVK_VK_TO_VSC);
                    if (wParam == (IntPtr)WM.KEYUP)
                        input.ki.dwFlags = KEYEVENTF.KEYUP;
                    SendInput(1, new INPUT[] { input }, Marshal.SizeOf(input));
                    stats.Replacements++;
                    Replaced?.Invoke(this, new KeyStatsEventArgs(replacement, stats));
                }
                return (IntPtr)1;
            }
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }
}
