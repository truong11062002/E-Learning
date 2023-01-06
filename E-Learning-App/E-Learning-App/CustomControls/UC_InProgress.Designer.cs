
namespace E_Learning_App.CustomControls
{
    partial class UC_InProgress
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InProgress));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_taught_by = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_name_course = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_next_name_course = new System.Windows.Forms.Label();
            this.label_thoiluong = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_prog = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_course = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1190, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 155);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(296, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 30);
            this.panel2.TabIndex = 2;
            // 
            // label_taught_by
            // 
            this.label_taught_by.AutoSize = true;
            this.label_taught_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taught_by.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_taught_by.Location = new System.Drawing.Point(320, 31);
            this.label_taught_by.Name = "label_taught_by";
            this.label_taught_by.Size = new System.Drawing.Size(131, 20);
            this.label_taught_by.TabIndex = 3;
            this.label_taught_by.Text = "name_taught_by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1230, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Up";
            // 
            // label_name_course
            // 
            this.label_name_course.AutoSize = true;
            this.label_name_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(194)))));
            this.label_name_course.Location = new System.Drawing.Point(215, 71);
            this.label_name_course.Name = "label_name_course";
            this.label_name_course.Size = new System.Drawing.Size(194, 31);
            this.label_name_course.TabIndex = 6;
            this.label_name_course.Text = "Name_course";
            this.label_name_course.Click += new System.EventHandler(this.label_name_course_Click);
            this.label_name_course.MouseEnter += new System.EventHandler(this.label_name_course_MouseEnter);
            this.label_name_course.MouseLeave += new System.EventHandler(this.label_name_course_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(217, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Overall progress";
            // 
            // label_next_name_course
            // 
            this.label_next_name_course.AutoSize = true;
            this.label_next_name_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_next_name_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(194)))));
            this.label_next_name_course.Location = new System.Drawing.Point(1278, 74);
            this.label_next_name_course.MaximumSize = new System.Drawing.Size(380, 0);
            this.label_next_name_course.Name = "label_next_name_course";
            this.label_next_name_course.Size = new System.Drawing.Size(232, 29);
            this.label_next_name_course.TabIndex = 8;
            this.label_next_name_course.Text = "next_name_course";
            // 
            // label_thoiluong
            // 
            this.label_thoiluong.AutoSize = true;
            this.label_thoiluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thoiluong.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_thoiluong.Location = new System.Drawing.Point(1382, 156);
            this.label_thoiluong.Name = "label_thoiluong";
            this.label_thoiluong.Size = new System.Drawing.Size(76, 20);
            this.label_thoiluong.TabIndex = 11;
            this.label_thoiluong.Text = "thoiluong";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1358, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 30);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1280, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(222, 128);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(596, 17);
            this.progressBar1.TabIndex = 12;
            // 
            // label_prog
            // 
            this.label_prog.AutoSize = true;
            this.label_prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prog.Location = new System.Drawing.Point(835, 122);
            this.label_prog.Name = "label_prog";
            this.label_prog.Size = new System.Drawing.Size(37, 24);
            this.label_prog.TabIndex = 13;
            this.label_prog.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1235, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1614, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_course
            // 
            this.pictureBox_course.Location = new System.Drawing.Point(32, 28);
            this.pictureBox_course.Name = "pictureBox_course";
            this.pictureBox_course.Size = new System.Drawing.Size(155, 155);
            this.pictureBox_course.TabIndex = 0;
            this.pictureBox_course.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Location = new System.Drawing.Point(1547, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 110);
            this.panel4.TabIndex = 15;
            this.panel4.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(87, 52);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Rate";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 52);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(87, 56);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Share";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.MouseEnter += new System.EventHandler(this.iconButton2_MouseEnter);
            this.iconButton2.MouseLeave += new System.EventHandler(this.iconButton2_MouseLeave);
            // 
            // UC_InProgress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_prog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_thoiluong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_next_name_course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_name_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_taught_by);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_course);
            this.Name = "UC_InProgress";
            this.Size = new System.Drawing.Size(1682, 200);
            this.Load += new System.EventHandler(this.UC_InProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_course)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_course;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_taught_by;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_name_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_next_name_course;
        private System.Windows.Forms.Label label_thoiluong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_prog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
