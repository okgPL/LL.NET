﻿using System;
using System.IO;
using System.Windows.Forms;

namespace LL.NET
{
    public partial class LL : Form
    {
        int ll = 0;
        public LL()
        {
            InitializeComponent();
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
        }

        private void save()
        {
            String text = ll.ToString();
            licznik.Text = text;
            StreamWriter sr = new StreamWriter("LL.bin");
            sr.Write(text);
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++ll;
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
                --ll;
                save();
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
            about.Show();
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
    }
}
