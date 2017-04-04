using LL.NET.Okna;
using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;

namespace LL.NET
{
    public partial class LL : Form
    {
        int buttonfunc =0;
        int ll = 0;
        int lang = 0;
        public LL()
        {
            //Language applying
            object y = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "lang", null);
            if (y == null)
            {
                 Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "lang", 0);
                y = 0;
            }
            lang = Convert.ToInt32(y);
            switch(lang)
            {
                case 0:
                    {
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        break;
                    }
                case 1:
                    {
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
                        break;
                    }
            }

            //Initialization and setting the icon
            InitializeComponent();
            Icon = Properties.Resources.LL_ICON;

            //Reading / creating counter file
            licznik.Text = ll.ToString();
            if (File.Exists("LL.bin"))
            {
                using (StreamReader sr = new StreamReader("LL.bin"))
                {
                    String line = sr.ReadToEnd();
                    ll = Convert.ToInt32(line);
                    sr.Close();
                }
            }
            else
            {
                using (StreamWriter sr = new StreamWriter("LL.bin"))
                {
                    sr.Write("0");
                    ll = 0;
                    sr.Close();
                }
            }
            licznik.Text = ll.ToString();

            //Setting button function
            object x = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "button", null);
            if (x == null)
            {
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "button", 0);
                x = 0;
            }
            buttonfunc = Convert.ToInt32(x);
            switch (buttonfunc)
            {
                case 0:
                    button1.Text = "+1";
                    break;
                case 1:
                    button1.Text = "+2";
                    break;
                case 2:
                    button1.Text = "+5";
                    break;
                case 3:
                    button1.Text = "+10";
                    break;
            }
        }

        private void save()
        {
            String text = ll.ToString();
            licznik.Text = text;
            StreamWriter sr = new StreamWriter("LL.bin");
            sr.Write(text);
            sr.Close();
            sr = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (buttonfunc)
            {
                case 0:
                    ++ll;
                    break;
                case 1:
                    ll += 2;
                    break;
                case 2:
                    ll += 5;
                    break;
                case 3:
                    ll += 10;
                    break;
            }
            save();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reset the Value?", "LL", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ll = 0;
                save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Oemplus))
            {
                ++ll;
                save();
                return true;
            }
            if (keyData == (Keys.Control | Keys.OemMinus))
            {
                if (ll == 0) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
                else
                {
                    --ll;
                    save();
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                if (MessageBox.Show("Do you really want to reset the Value?", "LL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ll = 0;
                    save();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MenuAdd1_Click(object sender, EventArgs e)
        {
            ++ll;
            save();
        }

        private void MenuAdd2_Click(object sender, EventArgs e)
        {
            ll += 2;
            save();
        }

        private void MenuAdd5_Click(object sender, EventArgs e)
        {
            ll += 5;
            save();
        }

        private void MenuAdd10_Click(object sender, EventArgs e)
        {
            ll += 10;
            save();
        }

        private void MenuMinus1_Click(object sender, EventArgs e)
        {
            if (ll == 0) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
            else
            {
                --ll;
                save();
            }
        }

        private void MenuMinus2_Click(object sender, EventArgs e)
        {
            if (ll <= 1) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
            else
            {
                ll -= 2;
                save();
            }
        }

        private void MenuMinus5_Click(object sender, EventArgs e)
        {
            if (ll <= 4) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
            else
            {
                ll -= 5;
                save();
            }
        }

        private void MenuMinus10_Click(object sender, EventArgs e)
        {
            if (ll <= 9) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
            else
            {
                ll -= 10 ;
                save();
            }
        }

        private void MenuAddOther_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            if (add.ShowDialog() == DialogResult.OK)
            {
                string x = add.textBox1.Text;
                int buf = Convert.ToInt32(x);
                if (ll+buf <0) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
                else
                {
                    ll += buf;
                    save();
                }
            }
        }

        private void MenuMinusOther_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Text = "Subtract";
            if (add.ShowDialog() == DialogResult.OK)
            {
                string x = add.textBox1.Text;
                int buf = Convert.ToInt32(x);
                if (ll - buf < 0) MessageBox.Show("You cannot set the Counter to negative Value!", "LL");
                else
                {
                    ll -= buf;
                    save();
                }
            }
        }

        private void MenuSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(buttonfunc, lang);
            if( settings.ShowDialog() == DialogResult.OK)
            {
                if (settings.buttf == "+1")
                    buttonfunc = 0;
                if (settings.buttf == "+2")
                    buttonfunc = 1;
                if (settings.buttf == "+5")
                    buttonfunc = 2;
                if (settings.buttf == "+10")
                    buttonfunc = 3;
                button1.Text = settings.buttf;
                if(settings.slang == "English")
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                if (settings.slang == "Polski")
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
            }
        }
    }
}