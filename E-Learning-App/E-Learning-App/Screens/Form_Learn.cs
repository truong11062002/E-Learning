using E_Learning_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_App.Screens
{
    public partial class Form_Learn : Form
    {
        DataProvider provider = new DataProvider();
        public string id_course_global;
        public string id_course_detail_global;
        private int _like;
        public Form_Learn()
        {
            //InitializeComponent();
        }

        public Form_Learn(string id_course, string id_course_detail) : this()
        {
            id_course_global = id_course;
            id_course_detail_global = id_course_detail;
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

        private void iconButton6_Click(object sender, EventArgs e)
        {
            //DataRow dr = dt_global.Rows[0];
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                using (var client = new WebClient())
                {
                    client.DownloadFile($"{id_course_global}/" + id_course_detail_global + ".mp4", folderPath + $"/{id_course_detail_global}.mp4");
                }
                MessageBox.Show("Tải phim thành công!");
            }
            else
                MessageBox.Show("Tải phim thất bại!");
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                string query = $"update DETAIL_COURSE set course_detail_completed = 1 " +
                    $"where DETAIL_COURSE.course_detail_id = '{id_course_detail_global}' " +
                    $"and DETAIL_COURSE.course_id = '{id_course_global}'";

                provider.ExecuteNonQuery(query);

                query = $"SELECT * FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id " +
                    $"WHERE DETAIL_COURSE.course_id = '{id_course_global}' order by course_detail_id asc";
                DataTable dt = provider.ExecuteQuery(query);
                Load_VideoInCourse(dt);
                Load_AllVideo(id_course_global, id_course_detail_global);
            }
        }

        private void circularButton_like_Click(object sender, EventArgs e)
        {
            _like++;
            this.circularButton_unlike.Visible = true;
            this.circularButton_like.Visible = false;

            string query = $"update DETAIL_COURSE set course_detail_like = {_like} " +
                $"where DETAIL_COURSE.course_detail_id = '{id_course_detail_global}' " +
                $"and DETAIL_COURSE.course_id = '{id_course_global}'";

            provider.ExecuteNonQuery(query);
        }

        private void circularButton_unlike_Click(object sender, EventArgs e)
        {
            _like--;
            this.circularButton_unlike.Visible = false;
            this.circularButton_like.Visible = true;

            string query = $"update DETAIL_COURSE set course_detail_like = {_like} " +
                $"where DETAIL_COURSE.course_detail_id = '{id_course_detail_global}' " +
                $"and DETAIL_COURSE.course_id = '{id_course_global}'";

            provider.ExecuteNonQuery(query);
        }
    }
}
