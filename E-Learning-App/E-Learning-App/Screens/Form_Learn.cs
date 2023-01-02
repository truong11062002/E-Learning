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
    public partial class Form_Learn : Form
    {
        public Form_Learn()
        {
            InitializeComponent();
            Load_VideoInCourse();
        }

        public Form_Learn(DataTable dt) : this()
        {

        }

        private void Load_VideoInCourse()
        {
            string query = "SELECT DETAIL_COURSE.course_detail_name, DETAIL_COURSE.course_detail_time FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id WHERE DETAIL_COURSE.course_id = 'co01'";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);

            //ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    //rm = image.ResourceManager;
                    //Bitmap myImage = (Bitmap)rm.GetObject(row["history_music_id"].ToString());

                    CustomControls.UC_VideoInCourse item = new CustomControls.UC_VideoInCourse(
                        //myImage,
                        row
                    );
                    flowLayoutPanel_videoInCourse.Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }
    }
}
