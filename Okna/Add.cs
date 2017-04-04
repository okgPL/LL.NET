using System;
using System.Windows.Forms;

namespace LL.NET
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Icon = Properties.Resources.LL_ICON;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Entered value is empty!", "LL");
            else
            {
                try
                {
                    Convert.ToInt32(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect value!\n" + ex, "LL");
                    return;
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
