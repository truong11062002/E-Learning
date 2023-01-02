
namespace E_Learning_App.CustomControls
{
    partial class UC_VideoInCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VideoInCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_name_video = new System.Windows.Forms.Label();
            this.label_thoiluong = new System.Windows.Forms.Label();
            this.pictureBox_completed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_completed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video:";
            this.label1.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            // 
            // label_name_video
            // 
            this.label_name_video.AutoSize = true;
            this.label_name_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_video.Location = new System.Drawing.Point(124, 6);
            this.label_name_video.MaximumSize = new System.Drawing.Size(174, 0);
            this.label_name_video.Name = "label_name_video";
            this.label_name_video.Size = new System.Drawing.Size(50, 20);
            this.label_name_video.TabIndex = 2;
            this.label_name_video.Text = "name";
            this.label_name_video.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.label_name_video.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            // 
            // label_thoiluong
            // 
            this.label_thoiluong.AutoSize = true;
            this.label_thoiluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thoiluong.Location = new System.Drawing.Point(63, 62);
            this.label_thoiluong.Name = "label_thoiluong";
            this.label_thoiluong.Size = new System.Drawing.Size(76, 20);
            this.label_thoiluong.TabIndex = 3;
            this.label_thoiluong.Text = "thoiluong";
            this.label_thoiluong.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.label_thoiluong.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            // 
            // pictureBox_completed
            // 
            this.pictureBox_completed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_completed.BackgroundImage")));
            this.pictureBox_completed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_completed.Location = new System.Drawing.Point(16, 6);
            this.pictureBox_completed.Name = "pictureBox_completed";
            this.pictureBox_completed.Size = new System.Drawing.Size(41, 38);
            this.pictureBox_completed.TabIndex = 4;
            this.pictureBox_completed.TabStop = false;
            this.pictureBox_completed.Visible = false;
            this.pictureBox_completed.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.pictureBox_completed.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            // 
            // UC_VideoInCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox_completed);
            this.Controls.Add(this.label_thoiluong);
            this.Controls.Add(this.label_name_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_VideoInCourse";
            this.Size = new System.Drawing.Size(348, 91);
            this.Load += new System.EventHandler(this.UC_VideoInCourse_Load);
            this.Click += new System.EventHandler(this.UC_VideoInCourse_Click);
            this.MouseEnter += new System.EventHandler(this.UC_VideoInCourse_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_VideoInCourse_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_completed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name_video;
        private System.Windows.Forms.Label label_thoiluong;
        private System.Windows.Forms.PictureBox pictureBox_completed;
    }
}
