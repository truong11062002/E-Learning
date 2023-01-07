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
    public partial class UC_Ack : UserControl
    {
        

        DataProvider provider = new DataProvider();
        private Form activeForm = null;
        public UC_Ack()
        {
            InitializeComponent();
        }

        public UC_Ack(Bitmap bm, string id_course) : this()
        {
            
            pictureBox_ack.Name = id_course;
            pictureBox_ack.BackgroundImage = bm;
            pictureBox_ack.BackgroundImageLayout = ImageLayout.Stretch;

            string query = $"SELECT * FROM COURSE " +
            $"INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id " +
            $"WHERE DETAIL_COURSE.course_id = '{id_course}' " +
            $"and course_detail_completed = 1 order by course_detail_id asc";

            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            label_name.Text = dr["course_name"].ToString();
            label_taught_by.Text = dr["course_taught_by"].ToString();


        }

        private void label_name_MouseEnter(object sender, EventArgs e)
        {
            label_name.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_name_MouseLeave(object sender, EventArgs e)
        {
            label_name.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
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
        private void label_name_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Certificate(pictureBox_ack.Name));
        }
    }
}
