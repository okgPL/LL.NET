using System;
using System.Reflection;
using System.Windows.Forms;

namespace LL.NET
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LL_NET;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label1.Text = "LL.NET\n" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\nCopyright © 2019 Oskar Kaczmarek";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
