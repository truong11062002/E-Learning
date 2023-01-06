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
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
            
            WaitLoadingForm();
        }

        public async void WaitLoadingForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new Screens.Form_Login();
            this.Hide();
            LoginForm.Show();
        }
    }
}
