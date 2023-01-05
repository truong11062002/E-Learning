using E_Learning_App.DAO;
using FontAwesome.Sharp;
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
    public partial class Form_Detail_Course : Form
    {
        private Form activeForm = null;
        DataTable dt_global;
        string id_course = "";
        string id_course_detail = "";
        public Form_Detail_Course()
        {
            
        }

        public Form_Detail_Course(Bitmap bm, DataTable dt): this()
        {
            InitializeComponent();
            
            dt_global = dt;
            DataRow dr = dt.Rows[0];

            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            label_name_course.Text = dr["course_name"].ToString();
            label_des.Text = dr["course_des"].ToString();
            label_taught_by.Text = dr["course_taught_by"].ToString();
            label_skill.Text = dr["course_skill"].ToString();
            label_about.Text = dr["course_about"].ToString();
            label_luotxem.Text = dr["course_freq"].ToString();

            id_course = dr["course_id"].ToString();
            id_course_detail = dr["course_id"].ToString() + "_01";
            LoadStars(id_course);

            //Panel pa = new Panel();
            
            //panel_body.Controls.Add(pa);

            //pa.Dock = DockStyle.Bottom;
            //pa.Size = new Size(panel_body.Width, 1000);
            //pa.BackColor = Color.WhiteSmoke;
            //Panel pan = new Panel();
            //pa.Controls.Add(pan);

            //pan.Size = new Size(panel_body.Width, 300);
            //pan.BackColor = Color.Transparent;
            //pan.Dock = DockStyle.Top;

            //Label lb = new Label();
            //lb.Text = "Reviews";
            //lb.ForeColor = Color.DarkGray;
            //lb.Font = new Font("Arial", 14, FontStyle.Bold);
            //lb.Left = 55;
            //lb.Top = 30;
            //lb.AutoSize = true;
            //pan.Controls.Add(lb);

            //TextBox tb = new TextBox();
            //tb.Size = new Size(550, 120);
            //tb.Left = 200;
            //tb.Top = 150;
            //tb.Font = new Font("Arial", 30, FontStyle.Regular);
            //pan.Controls.Add(tb);

            //IconButton icBtn = new IconButton();
            //icBtn.Text = "Đánh giá";
            //icBtn.Left = 200;
            //icBtn.Top = 100;
            //icBtn.BackColor = Color.Green;
            //icBtn.Size = new Size(130,60);

            //FlowLayoutPanel flp = new FlowLayoutPanel();
            //pa.Controls.Add(flp);

            //flp.BackColor = Color.Gray;
            //flp.Dock = DockStyle.Fill;

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

        private void iconButton_enroll_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Learn(id_course, id_course_detail));
        }

        private void LoadStars(string id)
        {
            DataProvider provider = new DataProvider();
            string query = $"select [course_stars] from COURSE where course_id = '{id}'";
            DataTable dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            string numberStar = dr["course_stars"].ToString();

            foreach (IconButton item in flowLayoutPanel1.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(numberStar))
                    item.IconColor = Color.DarkRed;
                else
                    item.IconColor = Color.Black;
            }

            label_danhgia.Text = dr["course_stars"].ToString();
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            LoadStars(id_course);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            
            IconButton btn = (IconButton)sender;
            DataProvider provider = new DataProvider();
            string query = $"update COURSE set course_stars = {btn.Name.Substring(1)} where course_id = '{id_course}'";
            provider.ExecuteNonQuery(query);
            MessageBox.Show("Đánh giá thành công!");
            LoadStars(id_course);
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            string numberStar = btn.Name.Substring(1);

            foreach (IconButton item in flowLayoutPanel1.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(numberStar))
                    item.IconColor = Color.DarkRed;
                else
                    item.IconColor = Color.Black;
            }
        }

        private void Form_Detail_Course_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton_review_Click(object sender, EventArgs e)
        {
            Form FormReview = new Screens.Form_Reviews();
            FormReview.Show();
        }
    }
}
