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
    public partial class Form_Profile : Form
    {
        DataTable dt;
        DataProvider provider = new DataProvider();
        public Form_Profile()
        {
            InitializeComponent();
            Load_Profile();
            Load_MyAchieve();
        }

        private void Load_Profile()
        {
            string query = $"SELECT * FROM LEARNER WHERE LEARNER_ID = 'le01'";
            
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            label_name.Text = dr["LEARNER_NAME"].ToString();
            label_college.Text = dr["LEARNER_COLLEGE"].ToString();
            label_address.Text = dr["LEARNER_ADDRESS"].ToString();
            label_phone.Text = dr["LEARNER_PHONE_NUMBER"].ToString();
        }

        private void Load_MyAchieve()
        {
            string query = $"SELECT course_id, COUNT(course_id) as numOfCourseDetail " +
                $"FROM DETAIL_COURSE GROUP BY course_id";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);


            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    query = $"SELECT course_id, COUNT(course_id) as numOfCourseDetail " +
                        $"FROM DETAIL_COURSE " +
                        $"WHERE course_detail_completed = 1 and course_id = '{row["course_id"]}' GROUP BY course_id HAVING COUNT(course_id) = {row["numOfCourseDetail"]}";

                    DataTable dt_completed = provider.ExecuteQuery(query);
                    if (dt_completed.Rows.Count > 0)
                    {
                        rm = image.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(row["course_id"].ToString());

                        CustomControls.UC_Achievements item = new CustomControls.UC_Achievements(
                            myImage,
                            row["course_id"].ToString()
                        );
                        flowLayoutPanel_achieve.Controls.Add(item);
                    }

                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
