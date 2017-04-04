using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LL.NET.Okna
{
    public partial class Settings : Form
    {
        public string buttf;
        public string slang;
        private int oldlang;
        public Settings(int bf = 0, int lang = 0)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "English", "Polski" });
            comboBox2.Items.AddRange(new object[] { "+1", "+2", "+5", "+10"});
            comboBox1.SelectedIndex = lang;
            comboBox2.SelectedIndex = bf;
            oldlang = lang;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            buttf = comboBox2.GetItemText(comboBox2.SelectedItem);
            slang = comboBox1.GetItemText(comboBox1.SelectedItem);
            int x = Convert.ToInt32(comboBox2.SelectedIndex);
            int y = Convert.ToInt32(comboBox1.SelectedIndex);
            if(buttf != "+1" && buttf != "+2" && buttf != "+5" && buttf != "+10")
            {
                MessageBox.Show("Incorrect value!", "LL");
                return;
            }
            if (slang != "English" && slang != "Polski")
            {
                MessageBox.Show("Incorrect value!", "LL");
                return;
            }
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "button", x);
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\LL.NET", "lang", y);

            if(y != oldlang)
            {
                switch (y)
                {
                    case 0:
                        {
                            MessageBox.Show("Changes will be applied after restarting.", "LL");
                            break;
                        }
                    case 1:
                        {
                            MessageBox.Show("Zmiany zostaną zastosowane po ponownym uruchomieniu aplikacji", "LL");
                            break;
                        }
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}