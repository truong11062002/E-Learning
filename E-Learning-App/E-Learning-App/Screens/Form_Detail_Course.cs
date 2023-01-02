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
            openChildForm(new Screens.Form_Learn(dt_global));
        }
    }
}
