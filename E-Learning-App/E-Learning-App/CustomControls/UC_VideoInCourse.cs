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
    public partial class UC_VideoInCourse : UserControl
    {
        private Form activeForm = null;
        public UC_VideoInCourse()
        {
            InitializeComponent();
        }

        public UC_VideoInCourse(DataRow dr): this()
        {
            Name = dr["course_detail_id"].ToString();
            label_name_video.Text = dr["course_detail_name"].ToString();
            label_thoiluong.Text = dr["course_detail_time"].ToString();
            if(dr["course_detail_completed"].ToString() == "1")
            {
                pictureBox_completed.Visible = true;
                pictureBox_uncompleted.Visible = false;
            }
            else
            {
                pictureBox_completed.Visible = false;
                pictureBox_uncompleted.Visible = true;
            }
            
        }

        private void UC_VideoInCourse_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void UC_VideoInCourse_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void UC_VideoInCourse_Load(object sender, EventArgs e)
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

        private void UC_VideoInCourse_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Screens.Form_Learn>().Count() == 1)
                Application.OpenForms.OfType<Screens.Form_Learn>().First().Close();
            openChildForm(new Screens.Form_Learn(Name.Substring(0, 4), Name));
        }
    }
}
