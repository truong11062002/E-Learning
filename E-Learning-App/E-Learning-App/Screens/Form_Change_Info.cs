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
    public partial class Form_Change_Info : Form
    {
        DataProvider provider = new DataProvider();
        DataRow dr;
        DataTable dt = new DataTable();
        string id;
        public Form_Change_Info()
        {
            InitializeComponent();
            Load_Profile();
        }
        private void Load_Profile() 
        {
            string query = $"SELECT * FROM LEARNER";
            dt = provider.ExecuteQuery(query);
            dr = dt.Rows[0];

            TextBox_name.Text = dr["LEARNER_NAME"].ToString();
            textBox_phone.Text = dr["LEARNER_PHONE_NUMBER"].ToString();
            textBox_address.Text = dr["LEARNER_ADDRESS"].ToString();
            id = dr["LEARNER_ID"].ToString();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string query = $"update LEARNER " +
                $"set LEARNER_NAME = '{TextBox_name.Text}', LEARNER_PHONE_NUMBER = '{textBox_phone.Text}', LEARNER_ADDRESS = '{textBox_address.Text}' " +
                $"WHERE LEARNER_ID = '{id}'";
            provider.ExecuteNonQuery(query);
            this.Close();
            
        }
    }
}
