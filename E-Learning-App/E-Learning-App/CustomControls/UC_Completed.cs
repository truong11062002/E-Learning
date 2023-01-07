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

namespace E_Learning_App.CustomControls
{
    public partial class UC_Completed : UserControl
    {
        DataProvider provider = new DataProvider();
        private Form activeForm = null;
        bool isClicked = false;
        public UC_Completed()
        {
            InitializeComponent();
        }

        public UC_Completed(Bitmap bm, string id_course) : this()
        {
            pictureBox_course.Name = id_course;
            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            string query = $"SELECT * FROM COURSE " +
            $"INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id " +
            $"WHERE DETAIL_COURSE.course_id = '{id_course}' " +
            $"and course_detail_completed = 1 order by course_detail_id asc";

            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            label_name_course.Text = dr["course_name"].ToString();
            label_taught_by.Text = dr["course_taught_by"].ToString();

            
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

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.DarkBlue;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(8, 84, 212);
        }

        private void label_name_course_MouseEnter(object sender, EventArgs e)
        {
            label_name_course.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_name_course_MouseLeave(object sender, EventArgs e)
        {
            label_name_course.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        }

        private void label_name_course_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)image.ResourceManager.GetObject(pictureBox_course.Name);
            string query = $"select * from COURSE where course_id like '{pictureBox_course.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            openChildForm(new Screens.Form_Detail_Course(myImage, dtShowMovieDetail));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Certificate(pictureBox_course.Name));
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label_rate.ForeColor = Color.DarkBlue;
        }

        private void label_rate_MouseLeave(object sender, EventArgs e)
        {
            label_rate.ForeColor = Color.FromArgb(8, 84, 212);
        }

        private void label_rate_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)image.ResourceManager.GetObject(pictureBox_course.Name);
            string query = $"select * from COURSE where course_id like '{pictureBox_course.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            openChildForm(new Screens.Form_Detail_Course(myImage, dtShowMovieDetail));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;
            if (isClicked)
            {
                this.panel4.Visible = true;

            }
            else
            {
                this.panel4.Visible = false;
            }
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)
        {
            iconButton3.BackColor = Color.Blue;
            iconButton3.ForeColor = Color.White;
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.BackColor = Color.White;
            iconButton3.ForeColor = Color.Black;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.Blue;
            iconButton2.ForeColor = Color.White;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.White;
            iconButton2.ForeColor = Color.Black;
        }
    }
}
