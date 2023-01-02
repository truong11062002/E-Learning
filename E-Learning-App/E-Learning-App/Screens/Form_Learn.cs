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
        DataProvider provider = new DataProvider();
        public string id;
        public Form_Learn()
        {
            //InitializeComponent();
        }

        public Form_Learn(string id_course, string id_course_detail) : this()
        {
            InitializeComponent();

            string query = $"SELECT * FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id WHERE DETAIL_COURSE.course_id = '{id_course}' order by course_detail_id asc";
            DataTable dt = provider.ExecuteQuery(query);
            Load_VideoInCourse(dt);
            Load_AllVideo(id_course, id_course_detail);
            query = $"SELECT * FROM DETAIL_COURSE where course_detail_id = '{id_course_detail}' and course_id = '{id_course}'";
            
            label_name_video.Text = provider.ExecuteQuery(query).Rows[0]["course_detail_name"].ToString();
        }

        private void Load_VideoInCourse(DataTable dtShowMyList)
        {
            flowLayoutPanel_videoInCourse.Controls.Clear();
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

        private void Load_AllVideo(string id_course, string id_course_detail)
        {
            axWindowsMediaPlayer1.URL = $"{id_course}/" + id_course_detail + ".mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form_Learn_Load(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<Screens.Form_Learn>().Count() == 1)
            //    Application.OpenForms.OfType<Screens.Form_Learn>().First().Close();
        }
    }
}
