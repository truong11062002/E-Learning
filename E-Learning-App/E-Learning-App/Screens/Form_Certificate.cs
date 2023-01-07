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

namespace E_Learning_App.Screens
{
    public partial class Form_Certificate : Form
    {
        DataProvider provider = new DataProvider();
        
        public Form_Certificate()
        {
            
            InitializeComponent();
        }

        public Form_Certificate(string id_course): this()
        {
            string query = $"SELECT * FROM LEARNER LEFT JOIN COURSE ON LEARNER.LEARNER_COURSE_ID = COURSE.course_id WHERE course_id = '{id_course}' and LEARNER_ID = 'le01'";
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            label_name_course.Text = dr["course_name"].ToString();
            label_name_learner.Text = dr["LEARNER_NAME"].ToString();
            label_skill.Text = dr["course_skill"].ToString();
            label_name.Text = dr["LEARNER_NAME"].ToString();
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
    }
}
