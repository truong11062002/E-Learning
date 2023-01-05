
namespace E_Learning_App.Screens
{
    partial class Form_Learn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Learn));
            this.panel_detail_course = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_videoInCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_video = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_name_video = new System.Windows.Forms.Label();
            this.circularButton_like = new E_Learning_App.CustomControls.CircularButton();
            this.circularButton_unlike = new E_Learning_App.CustomControls.CircularButton();
            this.panel_detail_course.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_detail_course
            // 
            this.panel_detail_course.AutoScroll = true;
            this.panel_detail_course.Controls.Add(this.flowLayoutPanel_videoInCourse);
            this.panel_detail_course.Controls.Add(this.panel1);
            this.panel_detail_course.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_detail_course.Location = new System.Drawing.Point(0, 0);
            this.panel_detail_course.Name = "panel_detail_course";
            this.panel_detail_course.Size = new System.Drawing.Size(397, 864);
            this.panel_detail_course.TabIndex = 0;
            // 
            // flowLayoutPanel_videoInCourse
            // 
            this.flowLayoutPanel_videoInCourse.AutoScroll = true;
            this.flowLayoutPanel_videoInCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_videoInCourse.Location = new System.Drawing.Point(0, 101);
            this.flowLayoutPanel_videoInCourse.Name = "flowLayoutPanel_videoInCourse";
            this.flowLayoutPanel_videoInCourse.Size = new System.Drawing.Size(397, 763);
            this.flowLayoutPanel_videoInCourse.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course introduction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_video
            // 
            this.panel_video.AutoScroll = true;
            this.panel_video.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel_video.Controls.Add(this.panel3);
            this.panel_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_video.Location = new System.Drawing.Point(397, 0);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(1285, 864);
            this.panel_video.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(15, 189);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1258, 675);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.circularButton_unlike);
            this.panel3.Controls.Add(this.circularButton_like);
            this.panel3.Controls.Add(this.iconButton6);
            this.panel3.Controls.Add(this.iconButton5);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1285, 183);
            this.panel3.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.GhostWhite;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.Blue;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton6.IconColor = System.Drawing.Color.Blue;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(486, 121);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(151, 59);
            this.iconButton6.TabIndex = 8;
            this.iconButton6.Text = "DOWNLOAD";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.GhostWhite;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Blue;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.iconButton5.IconColor = System.Drawing.Color.Blue;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(329, 121);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(151, 59);
            this.iconButton5.TabIndex = 7;
            this.iconButton5.Text = "REPORT AN ISSUE";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.GhostWhite;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Blue;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.iconButton2.IconColor = System.Drawing.Color.Blue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(172, 121);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(151, 59);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "DISCUSS";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Blue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton1.IconColor = System.Drawing.Color.Blue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(15, 121);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(151, 59);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "NOTE";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_name_video);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1285, 101);
            this.panel4.TabIndex = 2;
            // 
            // label_name_video
            // 
            this.label_name_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_video.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_name_video.Location = new System.Drawing.Point(0, 0);
            this.label_name_video.Name = "label_name_video";
            this.label_name_video.Size = new System.Drawing.Size(1316, 98);
            this.label_name_video.TabIndex = 1;
            this.label_name_video.Text = "name video";
            this.label_name_video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularButton_like
            // 
            this.circularButton_like.BackColor = System.Drawing.Color.White;
            this.circularButton_like.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton_like.BackgroundImage")));
            this.circularButton_like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton_like.FlatAppearance.BorderSize = 0;
            this.circularButton_like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton_like.Location = new System.Drawing.Point(1207, 125);
            this.circularButton_like.Name = "circularButton_like";
            this.circularButton_like.Size = new System.Drawing.Size(64, 55);
            this.circularButton_like.TabIndex = 9;
            this.circularButton_like.UseVisualStyleBackColor = false;
            this.circularButton_like.Click += new System.EventHandler(this.circularButton_like_Click);
            // 
            // circularButton_unlike
            // 
            this.circularButton_unlike.BackColor = System.Drawing.Color.White;
            this.circularButton_unlike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton_unlike.BackgroundImage")));
            this.circularButton_unlike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton_unlike.FlatAppearance.BorderSize = 0;
            this.circularButton_unlike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton_unlike.Location = new System.Drawing.Point(1207, 125);
            this.circularButton_unlike.Name = "circularButton_unlike";
            this.circularButton_unlike.Size = new System.Drawing.Size(64, 55);
            this.circularButton_unlike.TabIndex = 10;
            this.circularButton_unlike.UseVisualStyleBackColor = false;
            this.circularButton_unlike.Visible = false;
            this.circularButton_unlike.Click += new System.EventHandler(this.circularButton_unlike_Click);
            // 
            // Form_Learn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1682, 864);
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel_detail_course);
            this.Name = "Form_Learn";
            this.Text = "Form_Learn";
            this.Load += new System.EventHandler(this.Form_Learn_Load);
            this.panel_detail_course.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_detail_course;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_name_video;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_videoInCourse;
        private FontAwesome.Sharp.IconButton iconButton6;
        private CustomControls.CircularButton circularButton_like;
        private CustomControls.CircularButton circularButton_unlike;
    }
}