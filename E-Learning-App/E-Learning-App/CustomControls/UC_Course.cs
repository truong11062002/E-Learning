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
    public partial class UC_Course : UserControl
    {
        private Form activeForm = null;
        int countNumOfView;
        public UC_Course()
        {
            InitializeComponent();
        }

        public UC_Course(string id, string name, string taught, string freq): this()
        {
            
            Bitmap bm1 = (Bitmap)image.ResourceManager.GetObject(id);

            pictureBox_course.BackgroundImage = bm1;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox_course.Name = id;
            label_name_course.Text = name;
            label_taught_by.Text = taught;
            countNumOfView = Convert.ToInt32(freq);
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

        private void pictureBox_course_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)image.ResourceManager.GetObject(pictureBox_course.Name);
            string query = $"select * from COURSE where course_id like '{pictureBox_course.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            openChildForm(new Screens.Form_Detail_Course(myImage, dtShowMovieDetail));
            // -------- COUNT VIEW ------------
            CountView(pictureBox_course.Name, ++countNumOfView);
        }
        private void CountView(string id, int count)
        {
            DataProvider provider = new DataProvider();
            string query = $"update COURSE set course_freq = {count} where course_id = '{id}'";
            provider.ExecuteNonQuery(query);
        }

        private void UC_Course_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FloralWhite;
            label_name_course.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            pictureBox_course.Dock = DockStyle.Top;
        }

        private void UC_Course_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            label_name_course.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            pictureBox_course.Dock = DockStyle.None;

        }
    }
}
