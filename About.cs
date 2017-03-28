using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LL.NET
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("LL.NET.ico");
            label1.Text = "LL.NET\n" + Application.ProductVersion + "\nCopyright © 2017 Oskar Kaczmarek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
