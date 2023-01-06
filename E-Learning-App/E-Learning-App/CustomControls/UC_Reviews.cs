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
    public partial class UC_Reviews : UserControl
    {
        public UC_Reviews()
        {
            InitializeComponent();
        }

        public UC_Reviews(DataRow dr) : this()
        {
            label_name.Text = dr["LEARNER_NAME"].ToString();
            label_datetime.Text = dr["COMMENT_TIME"].ToString();
            label_review.Text = dr["COMMENT_TEXT"].ToString();
        }
    }
}
