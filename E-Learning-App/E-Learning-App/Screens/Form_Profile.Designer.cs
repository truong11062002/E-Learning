
namespace E_Learning_App.Screens
{
    partial class Form_Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new E_Learning_App.CustomControls.GradientPanel();
            this.label_college = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_address = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_learner = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_achieve = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_learner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.gradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 864);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.flowLayoutPanel_achieve);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(450, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 401);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Achievements";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Gray;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label_college);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.label_address);
            this.gradientPanel1.Controls.Add(this.label_phone);
            this.gradientPanel1.Controls.Add(this.label_name);
            this.gradientPanel1.Controls.Add(this.pictureBox_learner);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1682, 490);
            this.gradientPanel1.TabIndex = 14;
            this.gradientPanel1.TopColor = System.Drawing.Color.PaleTurquoise;
            // 
            // label_college
            // 
            this.label_college.AutoSize = true;
            this.label_college.BackColor = System.Drawing.Color.Transparent;
            this.label_college.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_college.ForeColor = System.Drawing.Color.White;
            this.label_college.Location = new System.Drawing.Point(888, 299);
            this.label_college.Name = "label_college";
            this.label_college.Size = new System.Drawing.Size(114, 32);
            this.label_college.TabIndex = 6;
            this.label_college.Text = "college";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(855, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 50);
            this.panel2.TabIndex = 5;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.Color.Transparent;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.White;
            this.label_address.Location = new System.Drawing.Point(626, 371);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(213, 32);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Phone number";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.Transparent;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(626, 299);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(213, 32);
            this.label_phone.TabIndex = 2;
            this.label_phone.Text = "Phone number";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(626, 232);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(94, 32);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // pictureBox_learner
            // 
            this.pictureBox_learner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_learner.BackgroundImage")));
            this.pictureBox_learner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_learner.Location = new System.Drawing.Point(695, 23);
            this.pictureBox_learner.Name = "pictureBox_learner";
            this.pictureBox_learner.Size = new System.Drawing.Size(184, 184);
            this.pictureBox_learner.TabIndex = 0;
            this.pictureBox_learner.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 2);
            this.panel3.TabIndex = 6;
            // 
            // flowLayoutPanel_achieve
            // 
            this.flowLayoutPanel_achieve.Location = new System.Drawing.Point(3, 94);
            this.flowLayoutPanel_achieve.Name = "flowLayoutPanel_achieve";
            this.flowLayoutPanel_achieve.Size = new System.Drawing.Size(808, 304);
            this.flowLayoutPanel_achieve.TabIndex = 7;
            // 
            // Form_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1682, 864);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Profile";
            this.Text = "Form_Profile";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_learner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label_college;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_learner;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_achieve;
    }
}