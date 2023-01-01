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
    public partial class Form_Home : Form
    {
        private DataTable dt;
        private Form activeForm = null;
        public Form_Home()
        {
            InitializeComponent();
            Variables.ListFormPanel.ListFormsPanel.Add(panel_main);
            Loading();
        }

        private void ShowAllCourses(string query)
        {
            foreach (Control item in panel_main.Controls.OfType<FlowLayoutPanel>().ToList())
                Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            foreach (Control item in panel_main.Controls.OfType<Form>().ToList())
                Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            foreach (DataRow row in dtShowProduct.Rows)
            {

                //CustomControls.item items = new CustomControls.item(
                //    row["music_id"].ToString(),
                //    row["music_name"].ToString(),
                //    row["singer_name"].ToString()
                //);
                //flpShowProduct.Controls.Add(items);
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Loading()
        {
            string query = "select * from COURSE";

            DataProvider provider = new DataProvider();
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Form LoginForm = new Form_Login();
            Hide();
            LoginForm.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void iconButton_home_MouseEnter(object sender, EventArgs e)
        {
            iconButton_home.BackColor = Color.DarkBlue;
            iconButton_home.ForeColor = Color.White;
            iconButton_home.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void iconButton_home_MouseLeave(object sender, EventArgs e)
        {
            iconButton_home.BackColor = Color.AliceBlue;
            iconButton_home.ForeColor = Color.Black;
            iconButton_home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton_InProgress_MouseEnter(object sender, EventArgs e)
        {
            iconButton_InProgress.BackColor = Color.DarkBlue;
            iconButton_InProgress.ForeColor = Color.White;
            iconButton_InProgress.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
        }

        private void iconButton_InProgress_MouseLeave(object sender, EventArgs e)
        {
            iconButton_InProgress.BackColor = Color.AliceBlue;
            iconButton_InProgress.ForeColor = Color.Black;
            iconButton_InProgress.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton_Completed_MouseEnter(object sender, EventArgs e)
        {
            iconButton_Completed.BackColor = Color.DarkBlue;
            iconButton_Completed.ForeColor = Color.White;
            iconButton_Completed.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
        }

        private void iconButton_Completed_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Completed.BackColor = Color.AliceBlue;
            iconButton_Completed.ForeColor = Color.Black;
            iconButton_Completed.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton_Cer_MouseEnter(object sender, EventArgs e)
        {
            iconButton_Cer.BackColor = Color.DarkBlue;
            iconButton_Cer.ForeColor = Color.White;
            iconButton_Cer.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void iconButton_Cer_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Cer.BackColor = Color.AliceBlue;
            iconButton_Cer.ForeColor = Color.Black;
            iconButton_Cer.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton_Prof_MouseEnter(object sender, EventArgs e)
        {
            iconButton_Prof.BackColor = Color.DarkBlue;
            iconButton_Prof.ForeColor = Color.White;
            iconButton_Prof.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void iconButton_Prof_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Prof.BackColor = Color.AliceBlue;
            iconButton_Prof.ForeColor = Color.Black;
            iconButton_Prof.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton_about_MouseEnter(object sender, EventArgs e)
        {
            iconButton_about.BackColor = Color.DarkBlue;
            iconButton_about.ForeColor = Color.White;
            iconButton_about.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void iconButton_about_MouseLeave(object sender, EventArgs e)
        {
            iconButton_about.BackColor = Color.AliceBlue;
            iconButton_about.ForeColor = Color.Black;
            iconButton_about.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void iconButton6_MouseEnter(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.DarkBlue;
            iconButton6.ForeColor = Color.White;
            iconButton6.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.AliceBlue;
            iconButton6.ForeColor = Color.Black;
            iconButton6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void TextBox_CourseSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_CourseSearch.Text == "What do you want to learn?" && TextBox_CourseSearch.ForeColor == Color.Gray)
            {
                TextBox_CourseSearch.Text = "";
                TextBox_CourseSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_CourseSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_CourseSearch.Text == "")
            {
                TextBox_CourseSearch.Text = "What do you want to learn?";
                TextBox_CourseSearch.ForeColor = Color.Gray;
            }
        }


    }
}
