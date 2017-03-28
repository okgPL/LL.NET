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
            this.MenuPlus1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMinus1 = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // licznik
            // 
            resources.ApplyResources(this.licznik, "licznik");
            this.licznik.Name = "licznik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLL,
            this.MenuHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MenuLL
            // 
            this.MenuLL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuLL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPlus1,
            this.MenuMinus1,
            this.MenuReset,
            this.toolStripSeparator1,
            this.MenuExit});
            this.MenuLL.Name = "MenuLL";
            resources.ApplyResources(this.MenuLL, "MenuLL");
            // 
            // MenuPlus1
            // 
            this.MenuPlus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuPlus1.Name = "MenuPlus1";
            resources.ApplyResources(this.MenuPlus1, "MenuPlus1");
            this.MenuPlus1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MenuMinus1
            // 
            this.MenuMinus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuMinus1.Name = "MenuMinus1";
            resources.ApplyResources(this.MenuMinus1, "MenuMinus1");
            this.MenuMinus1.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // MenuReset
            // 
            this.MenuReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuReset.Name = "MenuReset";
            resources.ApplyResources(this.MenuReset, "MenuReset");
            this.MenuReset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // MenuExit
            // 
            this.MenuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuExit.Name = "MenuExit";
            resources.ApplyResources(this.MenuExit, "MenuExit");
            this.MenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.MenuHelp.Name = "MenuHelp";
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            resources.ApplyResources(this.MenuAbout, "MenuAbout");
            this.MenuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.licznik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LL";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.ToolStripMenuItem MenuPlus1;
        private System.Windows.Forms.ToolStripMenuItem MenuMinus1;
        private System.Windows.Forms.ToolStripMenuItem MenuReset;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
    }
}

