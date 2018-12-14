namespace KeyboardWitchcraftAndKeyFuckery
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ltvKeyConfiguration = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cfgAlt = new System.Windows.Forms.CheckBox();
            this.cfgShift = new System.Windows.Forms.CheckBox();
            this.cfgCtrl = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.abtVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.abtArchitecture = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.abtFullName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.abtCodeBase = new System.Windows.Forms.Label();
            this.cfgKey = new KeyboardWitchcraftAndKeyFuckery.UI.KeyComboBox();
            this.cfgReplacement = new KeyboardWitchcraftAndKeyFuckery.UI.KeyComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ltvKeyConfiguration);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ltvKeyConfiguration
            // 
            this.ltvKeyConfiguration.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvKeyConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvKeyConfiguration.FullRowSelect = true;
            this.ltvKeyConfiguration.Location = new System.Drawing.Point(3, 3);
            this.ltvKeyConfiguration.Name = "ltvKeyConfiguration";
            this.ltvKeyConfiguration.Size = new System.Drawing.Size(418, 376);
            this.ltvKeyConfiguration.TabIndex = 0;
            this.ltvKeyConfiguration.UseCompatibleStateImageBehavior = false;
            this.ltvKeyConfiguration.View = System.Windows.Forms.View.Details;
            this.ltvKeyConfiguration.SelectedIndexChanged += new System.EventHandler(this.ltvKeyConfiguration_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Replacement";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "# Hits";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "# Replacements";
            this.columnHeader4.Width = 99;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cfgKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cfgReplacement, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 58);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replacement";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(340, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(340, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.cfgAlt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cfgShift, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cfgCtrl, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 23);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cfgAlt
            // 
            this.cfgAlt.AutoSize = true;
            this.cfgAlt.Location = new System.Drawing.Point(3, 3);
            this.cfgAlt.Name = "cfgAlt";
            this.cfgAlt.Size = new System.Drawing.Size(46, 17);
            this.cfgAlt.TabIndex = 0;
            this.cfgAlt.Text = "ALT";
            this.cfgAlt.UseVisualStyleBackColor = true;
            // 
            // cfgShift
            // 
            this.cfgShift.AutoSize = true;
            this.cfgShift.Location = new System.Drawing.Point(115, 3);
            this.cfgShift.Name = "cfgShift";
            this.cfgShift.Size = new System.Drawing.Size(57, 17);
            this.cfgShift.TabIndex = 0;
            this.cfgShift.Text = "SHIFT";
            this.cfgShift.UseVisualStyleBackColor = true;
            // 
            // cfgCtrl
            // 
            this.cfgCtrl.AutoSize = true;
            this.cfgCtrl.Location = new System.Drawing.Point(227, 3);
            this.cfgCtrl.Name = "cfgCtrl";
            this.cfgCtrl.Size = new System.Drawing.Size(54, 17);
            this.cfgCtrl.TabIndex = 0;
            this.cfgCtrl.Text = "CTRL";
            this.cfgCtrl.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.abtVersion, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.abtArchitecture, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.abtFullName, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.abtCodeBase, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 434);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel3.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Keyboad Witchcraft && Key Fuckery";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "[KWAKF]";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Version";
            // 
            // abtVersion
            // 
            this.abtVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.abtVersion.AutoSize = true;
            this.abtVersion.Location = new System.Drawing.Point(137, 138);
            this.abtVersion.Margin = new System.Windows.Forms.Padding(3);
            this.abtVersion.Name = "abtVersion";
            this.abtVersion.Size = new System.Drawing.Size(10, 13);
            this.abtVersion.TabIndex = 1;
            this.abtVersion.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Architecture";
            // 
            // abtArchitecture
            // 
            this.abtArchitecture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.abtArchitecture.AutoSize = true;
            this.abtArchitecture.Location = new System.Drawing.Point(137, 160);
            this.abtArchitecture.Margin = new System.Windows.Forms.Padding(3);
            this.abtArchitecture.Name = "abtArchitecture";
            this.abtArchitecture.Size = new System.Drawing.Size(10, 13);
            this.abtArchitecture.TabIndex = 1;
            this.abtArchitecture.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "FullName";
            // 
            // abtFullName
            // 
            this.abtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.abtFullName.AutoSize = true;
            this.abtFullName.Location = new System.Drawing.Point(137, 182);
            this.abtFullName.Margin = new System.Windows.Forms.Padding(3);
            this.abtFullName.Name = "abtFullName";
            this.abtFullName.Size = new System.Drawing.Size(10, 13);
            this.abtFullName.TabIndex = 1;
            this.abtFullName.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "CodeBase";
            // 
            // abtCodeBase
            // 
            this.abtCodeBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.abtCodeBase.AutoSize = true;
            this.abtCodeBase.Location = new System.Drawing.Point(137, 204);
            this.abtCodeBase.Margin = new System.Windows.Forms.Padding(3);
            this.abtCodeBase.Name = "abtCodeBase";
            this.abtCodeBase.Size = new System.Drawing.Size(10, 13);
            this.abtCodeBase.TabIndex = 1;
            this.abtCodeBase.Text = "-";
            // 
            // cfgKey
            // 
            this.cfgKey.FormattingEnabled = true;
            this.cfgKey.Location = new System.Drawing.Point(34, 3);
            this.cfgKey.Name = "cfgKey";
            this.cfgKey.SelectedKey = System.Windows.Forms.Keys.None;
            this.cfgKey.Size = new System.Drawing.Size(109, 21);
            this.cfgKey.TabIndex = 4;
            // 
            // cfgReplacement
            // 
            this.cfgReplacement.FormattingEnabled = true;
            this.cfgReplacement.Location = new System.Drawing.Point(225, 3);
            this.cfgReplacement.Name = "cfgReplacement";
            this.cfgReplacement.SelectedKey = System.Windows.Forms.Keys.None;
            this.cfgReplacement.Size = new System.Drawing.Size(109, 21);
            this.cfgReplacement.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Coded by Moritz Thomas";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Keyboard Witchcraft & Key Fuckery";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView ltvKeyConfiguration;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cfgAlt;
        private System.Windows.Forms.CheckBox cfgShift;
        private System.Windows.Forms.CheckBox cfgCtrl;
        private UI.KeyComboBox cfgKey;
        private UI.KeyComboBox cfgReplacement;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label abtVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label abtArchitecture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label abtFullName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label abtCodeBase;
        private System.Windows.Forms.Label label7;
    }
}

