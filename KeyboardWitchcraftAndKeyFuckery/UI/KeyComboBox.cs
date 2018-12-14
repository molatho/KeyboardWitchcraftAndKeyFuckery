using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWitchcraftAndKeyFuckery.UI
{
    public class KeyComboBox : ComboBox
    {
        private static Keys[] ALL_KEYS = (Keys[])Enum.GetValues(typeof(Keys));

        public Keys SelectedKey
        {
            get { return selectedKey; }
            set
            {
                if (selectedKey != value)
                {
                    selectedKey = value;
                    SelectedItem = value;
                    Text = value.ToString();
                }
            }
        }
        private Keys selectedKey;

        public KeyComboBox()
        {
            SelectedValueChanged += (o, e) => SelectedKey = (Keys)SelectedValue;
        }

        public void Initialize()
        {
            DataSource = ALL_KEYS.Cast<int>().Distinct().Cast<Keys>().ToArray();
            SelectedItem = Keys.None;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            e.Handled = true;
            this.SelectedItem = e.KeyCode;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            e.Handled = true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
