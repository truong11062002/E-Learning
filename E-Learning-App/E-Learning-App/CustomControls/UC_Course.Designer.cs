
namespace E_Learning_App.CustomControls
{
    partial class UC_Course
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_course = new System.Windows.Forms.PictureBox();
            this.label_taught_by = new System.Windows.Forms.Label();
            this.label_name_course = new System.Windows.Forms.Label();
            this.gradientPanel1 = new E_Learning_App.CustomControls.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_course
            // 
            this.pictureBox_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_course.Location = new System.Drawing.Point(45, 3);
            this.pictureBox_course.Name = "pictureBox_course";
            this.pictureBox_course.Size = new System.Drawing.Size(341, 135);
            this.pictureBox_course.TabIndex = 0;
            this.pictureBox_course.TabStop = false;
            this.pictureBox_course.Click += new System.EventHandler(this.pictureBox_course_Click);
            this.pictureBox_course.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.pictureBox_course.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            // 
            // label_taught_by
            // 
            this.label_taught_by.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_taught_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taught_by.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_taught_by.Location = new System.Drawing.Point(40, 220);
            this.label_taught_by.Name = "label_taught_by";
            this.label_taught_by.Size = new System.Drawing.Size(346, 59);
            this.label_taught_by.TabIndex = 1;
            this.label_taught_by.Text = "taught_by";
            this.label_taught_by.Click += new System.EventHandler(this.pictureBox_course_Click);
            this.label_taught_by.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.label_taught_by.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            // 
            // label_name_course
            // 
            this.label_name_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_name_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_course.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_name_course.Location = new System.Drawing.Point(40, 160);
            this.label_name_course.Name = "label_name_course";
            this.label_name_course.Size = new System.Drawing.Size(346, 60);
            this.label_name_course.TabIndex = 0;
            this.label_name_course.Text = "name_course";
            this.label_name_course.Click += new System.EventHandler(this.pictureBox_course_Click);
            this.label_name_course.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.label_name_course.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 282);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(422, 53);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.DarkGray;
            this.gradientPanel1.Click += new System.EventHandler(this.pictureBox_course_Click);
            this.gradientPanel1.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.gradientPanel1.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "100% Online";
            this.label1.Click += new System.EventHandler(this.pictureBox_course_Click);
            this.label1.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            // 
            // UC_Course
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label_name_course);
            this.Controls.Add(this.label_taught_by);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.pictureBox_course);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_Course";
            this.Size = new System.Drawing.Size(422, 335);
            this.MouseEnter += new System.EventHandler(this.UC_Course_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Course_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_course;
        private System.Windows.Forms.Label label_taught_by;
        private System.Windows.Forms.Label label_name_course;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
    }
}
