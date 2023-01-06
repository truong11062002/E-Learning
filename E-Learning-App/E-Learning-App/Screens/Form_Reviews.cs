using E_Learning_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_App.Screens
{
    public partial class Form_Reviews : Form
    {
        DataProvider provider = new DataProvider();
        string id_course;
        private Form activeForm = null;
        public Form_Reviews()
        {
            InitializeComponent();
            id_course = Screens.Form_Detail_Course.Id_course;
            Load_MyReview();
        }

        private void Load_MyReview()
        {
            flowLayoutPanel_ShowReview.Controls.Clear();
            string query = $"SELECT course_id, LEARNER_NAME, COMMENT_TIME, COMMENT_TEXT FROM COMMENT " +
                $"JOIN LEARNER ON COMMENT.LEARNER_ID = LEARNER.LEARNER_ID " +
                $"JOIN COURSE ON COURSE.course_id = COMMENT.COMMENT_COURSE_ID " +
                $"WHERE COURSE.course_id = '{id_course}' order by COMMENT_TIME desc;";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);


            //ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    //query = $"SELECT course_id, COUNT(course_id) as numOfCourseDetail " +
                    //    $"FROM DETAIL_COURSE " +
                    //    $"WHERE course_detail_completed = 1 and course_id = '{row["course_id"]}' GROUP BY course_id HAVING COUNT(course_id) = {row["numOfCourseDetail"]}";

                    //DataTable dt_completed = provider.ExecuteQuery(query);
                    if (dtShowMyList.Rows.Count > 0)
                    {
                        //rm = image.ResourceManager;
                        //Bitmap myImage = (Bitmap)rm.GetObject(row["course_id"].ToString());

                        CustomControls.UC_Reviews item = new CustomControls.UC_Reviews(
                            row
                        );
                        flowLayoutPanel_ShowReview.Controls.Add(item);
                    }

                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Bitmap myImage = (Bitmap)image.ResourceManager.GetObject(id_course);
            //string query = $"select * from COURSE where course_id like '{id_course}'";
            //DataProvider provider = new DataProvider();
            //DataTable dtShowMovieDetail = provider.ExecuteQuery(query);

            //openChildForm(new Screens.Form_Detail_Course(myImage, dtShowMovieDetail));
            this.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (TextBox_review.Text == "Enter review for this course" && TextBox_review.ForeColor == Color.Gray)
            {
                TextBox_review.Text = "";
                TextBox_review.ForeColor = Color.Black;
            }
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (TextBox_review.Text == "")
            {
                TextBox_review.Text = "Enter review for this course";
                TextBox_review.ForeColor = Color.Gray;
            }
        }
        private void Comment()
        {
            string query = $"insert into COMMENT values('{id_course}', 'le01', N'{TextBox_review.Text}', '{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}')";
            provider.ExecuteNonQuery(query);
            Load_MyReview();
            TextBox_review.Text = "";
        }
        private void iconButton_review_Click(object sender, EventArgs e)
        {
            if (TextBox_review.Text == "Enter review for this course" || TextBox_review.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đánh giá!");
            }
            else
                Comment();
        }

        private void TextBox_review_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;
            //if (ch == (char)13)
            //{
            //    Comment();
            //}
        }
    }
}
