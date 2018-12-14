using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWitchcraftAndKeyFuckery.DTO
{
    public class KeyReplacement
    {
        public bool ShiftActive { get; set; }
        public bool AltActive { get; set; }
        public bool ControlActive { get; set; }
        public Keys Key { get; set; }
        public Keys Replacement { get; set; }

        public override string ToString()
        {
            return $"{GetKeyString()} => {GetReplacementString()}";
        }

        public string GetKeyString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("[{0}]", Key.ToString());
            if (ShiftActive)
                builder.Append(" + [SHIFT]");
            if (AltActive)
                builder.Append(" + [ALT]");
            if (ControlActive)
                builder.Append(" + [CTRL]");
            return builder.ToString();
        }
        public string GetReplacementString()
        {
            return $"[{Replacement.ToString()}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (obj == null)
                return false;
            var other = obj as KeyReplacement;
            if (other == null)
                return false;

            return other.Key == this.Key && 
                other.Replacement == this.Replacement &&
                this.ShiftActive == other.ShiftActive &&
                this.AltActive == other.AltActive &&
                this.ControlActive == other.ControlActive;
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode() + Replacement.GetHashCode() << 8 + ShiftActive.GetHashCode() << 16 + AltActive.GetHashCode() << ControlActive.GetHashCode() << 24;
        }
    }
}
