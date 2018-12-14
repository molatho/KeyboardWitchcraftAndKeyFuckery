using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWitchcraftAndKeyFuckery.DTO
{
    public class KeySave
    {
        public Dictionary<KeyReplacement, KeyStatistics> Statistics;
        public List<KeyReplacement> Replacements;
    }
}
