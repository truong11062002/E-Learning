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
    public partial class UC_Achievements : UserControl
    {
        DataProvider provider = new DataProvider();
        public UC_Achievements()
        {
            InitializeComponent();
        }

        public UC_Achievements(Bitmap bm, string id_course) : this()
        {
            string query = $"SELECT * FROM COURSE " +
            $"INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id " +
            $"WHERE DETAIL_COURSE.course_id = '{id_course}' " +
            $"and course_detail_completed = 1 order by course_detail_id asc";

            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            label_name.Text = dr["course_name"].ToString();
        }
    }
}
