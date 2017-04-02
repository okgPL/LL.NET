using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LL.NET.Okna
{
    public partial class Settings : Form
    {
        public string selected;
        public Settings(int bf = 0, int lang = 0)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "English", "Polski" });
            comboBox2.Items.AddRange(new object[] { "+1", "+2", "+5", "+10"});
            comboBox2.SelectedIndex = bf;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            selected = comboBox2.GetItemText(comboBox2.SelectedItem);
            int x = Convert.ToInt32(comboBox2.SelectedIndex);
            if(selected != "+1" && selected != "+2" && selected != "+5" && selected != "+10")
            {
                MessageBox.Show("Incorrect value!", "LL");
                return;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "button", x);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}