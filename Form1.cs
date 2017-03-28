using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LL.NET
{
    public partial class Form1 : Form
    {
        int ll = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = ll.ToString();
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
            label1.Text = ll.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++ll;
            String text = ll.ToString();
            label1.Text = text;
            StreamWriter sr = new StreamWriter("LL.bin");
            sr.Write(text);
            sr.Close();
        }
    }
}
