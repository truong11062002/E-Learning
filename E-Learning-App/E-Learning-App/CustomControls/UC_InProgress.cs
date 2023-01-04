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
    public partial class UC_InProgress : UserControl
    {
        DataProvider provider = new DataProvider();
        string _sum = "";
        string _prog = "";
        private Form activeForm = null;
        bool isClicked = false;
        public UC_InProgress()
        {
            InitializeComponent();
        }

        public UC_InProgress(Bitmap bm, string id_course, string sum, string prog) : this()
        {
            
            _sum = sum;
            _prog = prog;

            pictureBox_course.Name = id_course;
            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            string query = $"SELECT * FROM COURSE " +
            $"INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id " +
            $"WHERE DETAIL_COURSE.course_id = '{id_course}' " +
            $"and course_detail_completed = 0 order by course_detail_id asc";

            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            label_prog.Text = (Convert.ToInt32(float.Parse(prog) / float.Parse(sum) * 100)).ToString() + "%";
            
            label_taught_by.Text = dr["course_taught_by"].ToString();
            label_name_course.Text = dr["course_name"].ToString();
            label_thoiluong.Text = dr["course_detail_time"].ToString();
            label_next_name_course.Text = dr["course_detail_name"].ToString();
            //int next_course = Convert.ToInt32(dr["course_id"].ToString().Substring(3)) + 1;
            //string next_course_id = dr["course_id"].ToString().Substring(0, 3) + next_course.ToString();
        }

        private void UC_InProgress_Load(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(float.Parse(_prog) / float.Parse(_sum) * 100);
            
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
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
        private void label_name_course_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)image.ResourceManager.GetObject(pictureBox_course.Name);
            string query = $"select * from COURSE where course_id like '{pictureBox_course.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            openChildForm(new Screens.Form_Detail_Course(myImage, dtShowMovieDetail));
        }

        private void label_name_course_MouseEnter(object sender, EventArgs e)
        {
            label_name_course.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_name_course_MouseLeave(object sender, EventArgs e)
        {
            label_name_course.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
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

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Blue;
            iconButton1.ForeColor = Color.White;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.White;
            iconButton1.ForeColor = Color.Black;
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
