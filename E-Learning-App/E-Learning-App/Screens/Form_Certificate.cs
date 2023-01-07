using E_Learning_App.DAO;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Learning_App.Screens
{
    public partial class Form_Certificate : Form
    {
        DataProvider provider = new DataProvider();
        DataTable dt;
        public Form_Certificate()
        {
            
            InitializeComponent();
        }

        public Form_Certificate(string id_course): this()
        {
            string query = $"SELECT DISTINCT LEARNER_NAME, COURSE_NAME, course_skill FROM CERTIFICATE JOIN LEARNER ON CERTIFICATE.LEARNER_ID = LEARNER.LEARNER_ID JOIN COURSE ON COURSE.course_id = CERTIFICATE.course_id WHERE LEARNER.LEARNER_ID = 'le01' and COURSE.course_id = '{id_course}'";
            dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];

            label_name.Text = dr["LEARNER_NAME"].ToString();
            label_name_course.Text = dr["COURSE_NAME"].ToString();
            label_name_learner.Text = dr["LEARNER_NAME"].ToString();
            label_skill.Text = dr["course_skill"].ToString();
        }

        private void Load_Info(string id_course)
        {
            string query = $"";
        }

        private void Form_Certificate_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void LoadReport()
        {
            string query = "SELECT * FROM SHOPPINGPRODUCT";

            DataProvider dp = new DataProvider();
            DataTable f_dt = dp.ExecuteQuery(query);
            //-------------------------------------

            System.Data.DataSet ds = new System.Data.DataSet();
            ds.Tables.Add(f_dt);
            //-------------------------------------
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dataset_report";
                rds.Value = ds.Tables[0];

                //------------------------------------------
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.RefreshReport();
            }


            ReportParameter para1 = new ReportParameter();
            para1.Name = "name"; //Đặt đúng tên khi đặt trong report
            //para1.Values.Add(User.name);

            ReportParameter para2 = new ReportParameter();
            para2.Name = "address";
            //para2.Values.Add(User.address);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "phone";
            //para3.Values.Add(User.phone);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3 });
        }

        private void ResetDB()
        {
            string connectionString = "Data Source=DESKTOP-IUEIHA4;Initial Catalog=ShoppingOnline;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "TRUNCATE TABLE SHOPPINGPRODUCT";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
