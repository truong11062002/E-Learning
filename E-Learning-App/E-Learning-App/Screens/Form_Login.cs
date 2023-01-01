using E_Learning_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_App.Screens
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void TextBox_Email_Enter(object sender, EventArgs e)
        {
            if (TextBox_Email.Text == "name@email.com" && TextBox_Email.ForeColor == Color.Gray)
            {
                TextBox_Email.Text = "";
                TextBox_Email.ForeColor = Color.Black;
            }
        }
        private void TextBox_Email_Leave(object sender, EventArgs e)
        {
            if (TextBox_Email.Text == "")
            {
                TextBox_Email.Text = "name@email.com";
                TextBox_Email.ForeColor = Color.Gray;
            }
        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Enter your password" && textBox_Password.ForeColor == Color.Gray)
            {
                textBox_Password.UseSystemPasswordChar = true;
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
            }
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.UseSystemPasswordChar = false;
                textBox_Password.Text = "Enter your password";
                textBox_Password.ForeColor = Color.Gray;
            }
        }

        private void iconButton_login_Click(object sender, EventArgs e)
        {
            string query = $"select * " +
                "from LEARNER " +
                $"where LEARNER.LEARNER_ACCOUNT = '{TextBox_Email.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                $"and LEARNER.LEARNER_PASSWORD = '{textBox_Password.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataProvider provider = new DataProvider();
            Variables.globalVariablescs.DataTableAccount = provider.ExecuteQuery(query);
            if (Variables.globalVariablescs.DataTableAccount.Rows.Count > 0)
            {
                Form HomeForm = new Form_Home();
                Hide();
                HomeForm.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng nhập lại!");
                textBox_Password.UseSystemPasswordChar = false;
                textBox_Password.Text = "Enter your password";
                textBox_Password.ForeColor = Color.Gray;
            }
            //Variables.globalVariablescs.DataTableAccount.getNumberOfComment();
        }
    }
}
