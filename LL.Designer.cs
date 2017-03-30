namespace LL.NET
{
    partial class LL
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LL));
            this.button1 = new System.Windows.Forms.Button();
            this.licznik = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuLL = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd10 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubtract = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinus1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinus2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinus5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinus10 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinusOther = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button1.Location = new System.Drawing.Point(0, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // licznik
            // 
            this.licznik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licznik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.licznik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.licznik.Location = new System.Drawing.Point(0, 24);
            this.licznik.Name = "licznik";
            this.licznik.Size = new System.Drawing.Size(183, 77);
            this.licznik.TabIndex = 1;
            this.licznik.Text = "0";
            this.licznik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLL,
            this.MenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuLL
            // 
            this.MenuLL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuLL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuSubtract,
            this.MenuReset,
            this.toolStripSeparator1,
            this.MenuExit});
            this.MenuLL.Name = "MenuLL";
            this.MenuLL.Size = new System.Drawing.Size(31, 20);
            this.MenuLL.Text = "LL";
            // 
            // MenuAdd
            // 
            this.MenuAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd1,
            this.MenuAdd2,
            this.MenuAdd5,
            this.MenuAdd10,
            this.MenuAddOther});
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.ShortcutKeyDisplayString = "";
            this.MenuAdd.Size = new System.Drawing.Size(152, 22);
            this.MenuAdd.Text = "Add";
            // 
            // MenuAdd1
            // 
            this.MenuAdd1.Name = "MenuAdd1";
            this.MenuAdd1.ShortcutKeyDisplayString = "Ctrl+";
            this.MenuAdd1.Size = new System.Drawing.Size(152, 22);
            this.MenuAdd1.Text = "+1";
            this.MenuAdd1.ToolTipText = "Adds +1 to Counter";
            this.MenuAdd1.Click += new System.EventHandler(this.MenuAdd1_Click);
            // 
            // MenuAdd2
            // 
            this.MenuAdd2.Name = "MenuAdd2";
            this.MenuAdd2.Size = new System.Drawing.Size(152, 22);
            this.MenuAdd2.Text = "+2";
            this.MenuAdd2.ToolTipText = "Adds +2 to Counter";
            this.MenuAdd2.Click += new System.EventHandler(this.MenuAdd2_Click);
            // 
            // MenuAdd5
            // 
            this.MenuAdd5.Name = "MenuAdd5";
            this.MenuAdd5.Size = new System.Drawing.Size(152, 22);
            this.MenuAdd5.Text = "+5";
            this.MenuAdd5.ToolTipText = "Adds +5 to Counter";
            this.MenuAdd5.Click += new System.EventHandler(this.MenuAdd5_Click);
            // 
            // MenuAdd10
            // 
            this.MenuAdd10.Name = "MenuAdd10";
            this.MenuAdd10.Size = new System.Drawing.Size(152, 22);
            this.MenuAdd10.Text = "+10";
            this.MenuAdd10.ToolTipText = "Adds +10 to Counter";
            this.MenuAdd10.Click += new System.EventHandler(this.MenuAdd10_Click);
            // 
            // MenuAddOther
            // 
            this.MenuAddOther.Name = "MenuAddOther";
            this.MenuAddOther.ShowShortcutKeys = false;
            this.MenuAddOther.Size = new System.Drawing.Size(152, 22);
            this.MenuAddOther.Text = "Other value";
            this.MenuAddOther.Click += new System.EventHandler(this.MenuAddOther_Click);
            // 
            // MenuSubtract
            // 
            this.MenuSubtract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuSubtract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMinus1,
            this.MenuMinus2,
            this.MenuMinus5,
            this.MenuMinus10,
            this.MenuMinusOther});
            this.MenuSubtract.Name = "MenuSubtract";
            this.MenuSubtract.ShortcutKeyDisplayString = "";
            this.MenuSubtract.Size = new System.Drawing.Size(152, 22);
            this.MenuSubtract.Text = "Subtract";
            // 
            // MenuMinus1
            // 
            this.MenuMinus1.Name = "MenuMinus1";
            this.MenuMinus1.ShortcutKeyDisplayString = "Ctrl-";
            this.MenuMinus1.Size = new System.Drawing.Size(152, 22);
            this.MenuMinus1.Text = "-1";
            this.MenuMinus1.ToolTipText = "Subtracts -1 to Counter";
            this.MenuMinus1.Click += new System.EventHandler(this.MenuMinus1_Click);
            // 
            // MenuMinus2
            // 
            this.MenuMinus2.Name = "MenuMinus2";
            this.MenuMinus2.Size = new System.Drawing.Size(152, 22);
            this.MenuMinus2.Text = "-2";
            this.MenuMinus2.ToolTipText = "Subtracts -2 to Counter";
            this.MenuMinus2.Click += new System.EventHandler(this.MenuMinus2_Click);
            // 
            // MenuMinus5
            // 
            this.MenuMinus5.Name = "MenuMinus5";
            this.MenuMinus5.Size = new System.Drawing.Size(152, 22);
            this.MenuMinus5.Text = "-5";
            this.MenuMinus5.ToolTipText = "Subtracts -5 to Counter";
            this.MenuMinus5.Click += new System.EventHandler(this.MenuMinus5_Click);
            // 
            // MenuMinus10
            // 
            this.MenuMinus10.Name = "MenuMinus10";
            this.MenuMinus10.Size = new System.Drawing.Size(152, 22);
            this.MenuMinus10.Text = "-10";
            this.MenuMinus10.ToolTipText = "Subtracts -10 to Counter";
            this.MenuMinus10.Click += new System.EventHandler(this.MenuMinus10_Click);
            // 
            // MenuMinusOther
            // 
            this.MenuMinusOther.Name = "MenuMinusOther";
            this.MenuMinusOther.Size = new System.Drawing.Size(152, 22);
            this.MenuMinusOther.Text = "Other value";
            this.MenuMinusOther.Click += new System.EventHandler(this.MenuMinusOther_Click);
            // 
            // MenuReset
            // 
            this.MenuReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuReset.Name = "MenuReset";
            this.MenuReset.ShortcutKeyDisplayString = "Ctrl+R";
            this.MenuReset.Size = new System.Drawing.Size(152, 22);
            this.MenuReset.Text = "Reset";
            this.MenuReset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeyDisplayString = "Alt+F4";
            this.MenuExit.Size = new System.Drawing.Size(152, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(183, 135);
            this.Controls.Add(this.licznik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LL";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label licznik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuLL;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuSubtract;
        private System.Windows.Forms.ToolStripMenuItem MenuReset;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd1;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd2;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd5;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd10;
        private System.Windows.Forms.ToolStripMenuItem MenuAddOther;
        private System.Windows.Forms.ToolStripMenuItem MenuMinus1;
        private System.Windows.Forms.ToolStripMenuItem MenuMinus2;
        private System.Windows.Forms.ToolStripMenuItem MenuMinus5;
        private System.Windows.Forms.ToolStripMenuItem MenuMinus10;
        private System.Windows.Forms.ToolStripMenuItem MenuMinusOther;
    }
}

