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
    public partial class UC_Completed : UserControl
    {
        public UC_Completed()
        {
            InitializeComponent();
        }

        public UC_Completed(Bitmap bm, DataRow dr) : this()
        {
            pictureBox_course.BackgroundImage = bm;
            pictureBox_course.BackgroundImageLayout = ImageLayout.Stretch;

            label_taught_by.Text = dr["course_taught_by"].ToString();
        }
    }
}
