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
        public UC_VideoInCourse()
        {
            InitializeComponent();
        }

        public UC_VideoInCourse(DataRow dr): this()
        {
            label_name_video.Text = dr["course_detail_name"].ToString();
            label_thoiluong.Text = dr["course_detail_time"].ToString();
        }

        private void UC_VideoInCourse_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void UC_VideoInCourse_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
