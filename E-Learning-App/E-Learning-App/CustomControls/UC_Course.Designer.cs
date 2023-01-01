
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name_course = new System.Windows.Forms.Label();
            this.label_taught_by = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new E_Learning_App.CustomControls.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).BeginInit();
            this.panel1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_course
            // 
            this.pictureBox_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_course.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_course.Name = "pictureBox_course";
            this.pictureBox_course.Size = new System.Drawing.Size(408, 98);
            this.pictureBox_course.TabIndex = 0;
            this.pictureBox_course.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_taught_by);
            this.panel1.Controls.Add(this.label_name_course);
            this.panel1.Location = new System.Drawing.Point(41, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 109);
            this.panel1.TabIndex = 1;
            // 
            // label_name_course
            // 
            this.label_name_course.AutoSize = true;
            this.label_name_course.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_name_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_course.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_name_course.Location = new System.Drawing.Point(0, 0);
            this.label_name_course.Name = "label_name_course";
            this.label_name_course.Size = new System.Drawing.Size(170, 29);
            this.label_name_course.TabIndex = 0;
            this.label_name_course.Text = "name_course";
            // 
            // label_taught_by
            // 
            this.label_taught_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taught_by.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_taught_by.Location = new System.Drawing.Point(0, 72);
            this.label_taught_by.Name = "label_taught_by";
            this.label_taught_by.Size = new System.Drawing.Size(330, 31);
            this.label_taught_by.TabIndex = 1;
            this.label_taught_by.Text = "taught_by";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "100% Online";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 254);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(408, 53);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.DarkGray;
            // 
            // UC_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_course);
            this.Name = "UC_Course";
            this.Size = new System.Drawing.Size(408, 307);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_course;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_taught_by;
        private System.Windows.Forms.Label label_name_course;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
    }
}
