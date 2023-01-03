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
        public UC_InProgress()
        {
            InitializeComponent();
        }

        public UC_InProgress(Bitmap bm, DataRow dr) : this()
        {
            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            label_taught_by.Text = dr["course_taught_by"].ToString();
            label_name_course.Text = dr["course_name"].ToString();
            label_thoiluong.Text = dr["course_detail_time"].ToString();
        }

        private void UC_InProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
