using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWitchcraftAndKeyFuckery.DTO
{
    public class KeyStatistics
    {
        public int Hits { get; set; }
        public int Replacements { get; set; }

        public override string ToString()
        {
            return $"{Hits} hits, {Replacements} replacements";
        }
    }
}
