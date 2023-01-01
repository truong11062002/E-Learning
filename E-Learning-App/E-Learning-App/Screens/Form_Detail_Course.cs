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
        public Form_Detail_Course()
        {
            
        }

        public Form_Detail_Course(Bitmap bm, DataTable dt): this()
        {
            InitializeComponent();

            DataRow dr = dt.Rows[0];

            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            label_name_course.Text = dr["course_name"].ToString();
            label_des.Text = dr["course_des"].ToString();
            label_taught_by.Text = dr["course_taught_by"].ToString();
            
        }
    }
}
