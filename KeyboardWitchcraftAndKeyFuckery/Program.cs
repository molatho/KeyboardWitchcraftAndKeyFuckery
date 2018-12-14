using KeyboardWitchcraftAndKeyFuckery.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWitchcraftAndKeyFuckery
{
    static class Program
    {
        public static KeyManager Manager { get; private set; }
        public static string SAVE_FILE = "keys.json";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Manager = new KeyManager();
            if (File.Exists(SAVE_FILE))
                Manager.Load(SAVE_FILE);
            Manager.Hook();
            Application.Run(new frmMain());
            Manager.Unhook();
            Manager.Save(SAVE_FILE);
        }
    }
}
