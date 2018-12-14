using KeyboardWitchcraftAndKeyFuckery.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardWitchcraftAndKeyFuckery
{
    public partial class frmMain : Form
    {
        private static Keys[] ALL_KEYS = (Keys[])Enum.GetValues(typeof(Keys));
        public frmMain()
        {
            InitializeComponent();

            var version = Assembly.GetCallingAssembly().GetName();
            abtVersion.Text = version.Version.ToString();
            abtArchitecture.Text = version.ProcessorArchitecture.ToString();
            abtFullName.Text = version.FullName;
            abtCodeBase.Text = version.CodeBase;

            var bmp = global::KeyboardWitchcraftAndKeyFuckery.Properties.Resources.logo;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            pictureBox1.Image = bmp;

            cfgKey.Initialize();
            cfgReplacement.Initialize();
            this.Shown += (o, e) => Program.Manager.IgnoreHwnd = this.Handle;
            foreach (var key in Program.Manager.Replacements)
                AddReplacement(key);
            Program.Manager.Replaced += KeyReplaced;
            Program.Manager.Hit += KeyHit;
        }

        private void KeyHit(object sender, KeyManager.KeyStatsEventArgs e)
        {
            var item = ltvKeyConfiguration.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Tag == e.Replacement);
            if (item == null)
                return;

            item.SubItems[2].Text = e.Statistics.Hits.ToString();
        }

        private void KeyReplaced(object sender, KeyManager.KeyStatsEventArgs e)
        {
            var item = ltvKeyConfiguration.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Tag == e.Replacement);
            if (item == null)
                return;

            item.SubItems[3].Text = e.Statistics.Replacements.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cfgKey.SelectedKey == Keys.None)
                return;

            var key = new KeyReplacement()
            {
                Key = cfgKey.SelectedKey,
                Replacement = cfgReplacement.SelectedKey,
                AltActive = cfgAlt.Checked,
                ControlActive = cfgCtrl.Checked,
                ShiftActive = cfgShift.Checked
            };

            try
            {
                Program.Manager.AddReplacement(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register replacement:\n{ex.Message}", "KWAKF");
                return;
            }
            AddReplacement(key);
        }

        public void AddReplacement(KeyReplacement key)
        {

            var item = new ListViewItem();
            item.Tag = key;
            item.Text = key.GetKeyString();
            item.SubItems.Add(key.GetReplacementString());
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            ltvKeyConfiguration.Items.Add(item);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var items = ltvKeyConfiguration.SelectedItems.Cast<ListViewItem>();
            
            ltvKeyConfiguration.SuspendLayout();
            foreach (var item in items)
            {
                ltvKeyConfiguration.Items.Remove(item);
                Program.Manager.RemoveReplacement((KeyReplacement)item.Tag);
            }
            ltvKeyConfiguration.ResumeLayout();
        }

        private void ltvKeyConfiguration_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = ltvKeyConfiguration.SelectedItems.Count > 0;
        }
    }
}
