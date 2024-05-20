using GameRetailerManagement.Source.Utilities;
using System.Windows.Forms;

namespace GameRetailerManagement.Source.Forms.Main
{
    public partial class Form_Login : Form
    {
        private int atemptLoginCount;
        public Form_Login()
        {
            InitializeComponent();
            textBox_Account.Text = string.Empty;
            textBox_Password.Text = string.Empty;
            atemptLoginCount = 0;
        }

        private void button_Login_Click(object sender, System.EventArgs e)
        {
            if (int.Parse(new QueryGRDB().ExecuteScalar(
                $"select count(*) from [USER] " +
                $"where [USER_ACCOUNT] = '{textBox_Account.Text}' " +
                $"and [USER_PASSWORD] = '{textBox_Password.Text}'").ToString()) >= 1)
            {
                Hide();
                Form_GameRetailer form_GameRetailer = new Form_GameRetailer();
                form_GameRetailer.ShowDialog();
                Show();
            }
            else
            {
                atemptLoginCount += 1;
                MessageBox.Show($"LOGIN FAILED: Atempt {atemptLoginCount}/3", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (atemptLoginCount == 3)
                Application.Exit();
        }

        private void button_RESET_Click(object sender, System.EventArgs e)
        {
            textBox_Account.Text = string.Empty;
            textBox_Password.Text = string.Empty;
        }

        private void button_Exit_Click(object sender, System.EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure want to exit!", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
