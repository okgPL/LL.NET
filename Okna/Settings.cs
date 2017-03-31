using System;
using System.Windows.Forms;

namespace LL.NET.Okna
{
    public partial class Settings : Form
    {
        public string selected;
        public Settings()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "English", "Polski" });
            comboBox2.Items.AddRange(new object[] { "+1", "+2", "+5", "+10"});
        }

        private void OK_Click(object sender, EventArgs e)
        {
            selected = comboBox2.GetItemText(comboBox2.SelectedItem);
            Close();
        }
    }
}
