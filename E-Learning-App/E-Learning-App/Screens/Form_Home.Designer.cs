
namespace E_Learning_App.Screens
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_CourseSearch = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.iconButton_name_leaner = new FontAwesome.Sharp.IconButton();
            this.circularButton_avt = new E_Learning_App.CustomControls.CircularButton();
            this.iconButton_search = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton_Prof = new FontAwesome.Sharp.IconButton();
            this.iconButton_about = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton_Cer = new FontAwesome.Sharp.IconButton();
            this.iconButton_Completed = new FontAwesome.Sharp.IconButton();
            this.iconButton_InProgress = new FontAwesome.Sharp.IconButton();
            this.iconButton_home = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 1032);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton_Prof);
            this.panel4.Controls.Add(this.iconButton_about);
            this.panel4.Controls.Add(this.iconButton6);
            this.panel4.Controls.Add(this.iconButton_Cer);
            this.panel4.Controls.Add(this.iconButton_Completed);
            this.panel4.Controls.Add(this.iconButton_InProgress);
            this.panel4.Controls.Add(this.iconButton_home);
            this.panel4.Location = new System.Drawing.Point(3, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 797);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.iconButton_name_leaner);
            this.panel1.Controls.Add(this.circularButton_avt);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(201, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 121);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1451, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 60);
            this.panel2.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.iconButton_search);
            this.panel5.Controls.Add(this.TextBox_CourseSearch);
            this.panel5.Location = new System.Drawing.Point(32, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 64);
            this.panel5.TabIndex = 12;
            // 
            // TextBox_CourseSearch
            // 
            this.TextBox_CourseSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_CourseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CourseSearch.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_CourseSearch.Location = new System.Drawing.Point(14, 19);
            this.TextBox_CourseSearch.Name = "TextBox_CourseSearch";
            this.TextBox_CourseSearch.Size = new System.Drawing.Size(411, 27);
            this.TextBox_CourseSearch.TabIndex = 1;
            this.TextBox_CourseSearch.Text = "What do you want to learn?";
            this.TextBox_CourseSearch.Enter += new System.EventHandler(this.TextBox_CourseSearch_Enter);
            this.TextBox_CourseSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_CourseSearch_KeyPress);
            this.TextBox_CourseSearch.Leave += new System.EventHandler(this.TextBox_CourseSearch_Leave);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(201, 121);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1700, 911);
            this.panel_main.TabIndex = 2;
            // 
            // iconButton_name_leaner
            // 
            this.iconButton_name_leaner.FlatAppearance.BorderSize = 0;
            this.iconButton_name_leaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_name_leaner.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_name_leaner.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton_name_leaner.IconColor = System.Drawing.Color.Black;
            this.iconButton_name_leaner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_name_leaner.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_name_leaner.Location = new System.Drawing.Point(1455, 43);
            this.iconButton_name_leaner.Name = "iconButton_name_leaner";
            this.iconButton_name_leaner.Size = new System.Drawing.Size(239, 49);
            this.iconButton_name_leaner.TabIndex = 15;
            this.iconButton_name_leaner.Text = "Truong Nguyen Nhat";
            this.iconButton_name_leaner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_name_leaner.UseVisualStyleBackColor = true;
            this.iconButton_name_leaner.Click += new System.EventHandler(this.iconButton_name_leaner_Click);
            // 
            // circularButton_avt
            // 
            this.circularButton_avt.BackColor = System.Drawing.Color.DarkGray;
            this.circularButton_avt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton_avt.BackgroundImage")));
            this.circularButton_avt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton_avt.FlatAppearance.BorderSize = 0;
            this.circularButton_avt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton_avt.Location = new System.Drawing.Point(1379, 39);
            this.circularButton_avt.Name = "circularButton_avt";
            this.circularButton_avt.Size = new System.Drawing.Size(60, 56);
            this.circularButton_avt.TabIndex = 14;
            this.circularButton_avt.UseVisualStyleBackColor = false;
            // 
            // iconButton_search
            // 
            this.iconButton_search.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton_search.IconColor = System.Drawing.Color.White;
            this.iconButton_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_search.Location = new System.Drawing.Point(644, 0);
            this.iconButton_search.Name = "iconButton_search";
            this.iconButton_search.Size = new System.Drawing.Size(63, 62);
            this.iconButton_search.TabIndex = 2;
            this.iconButton_search.UseVisualStyleBackColor = false;
            this.iconButton_search.Click += new System.EventHandler(this.iconButton_search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 160);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // iconButton_Prof
            // 
            this.iconButton_Prof.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_Prof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Prof.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Prof.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButton_Prof.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_Prof.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Prof.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Prof.Location = new System.Drawing.Point(0, 224);
            this.iconButton_Prof.Name = "iconButton_Prof";
            this.iconButton_Prof.Size = new System.Drawing.Size(192, 56);
            this.iconButton_Prof.TabIndex = 14;
            this.iconButton_Prof.Text = "Profile";
            this.iconButton_Prof.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Prof.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Prof.UseVisualStyleBackColor = false;
            this.iconButton_Prof.Click += new System.EventHandler(this.iconButton_Prof_Click);
            this.iconButton_Prof.MouseEnter += new System.EventHandler(this.iconButton_Prof_MouseEnter);
            this.iconButton_Prof.MouseLeave += new System.EventHandler(this.iconButton_Prof_MouseLeave);
            // 
            // iconButton_about
            // 
            this.iconButton_about.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_about.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_about.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton_about.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_about.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_about.Location = new System.Drawing.Point(0, 685);
            this.iconButton_about.Name = "iconButton_about";
            this.iconButton_about.Size = new System.Drawing.Size(192, 56);
            this.iconButton_about.TabIndex = 13;
            this.iconButton_about.Text = "About us";
            this.iconButton_about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_about.UseVisualStyleBackColor = false;
            this.iconButton_about.MouseEnter += new System.EventHandler(this.iconButton_about_MouseEnter);
            this.iconButton_about.MouseLeave += new System.EventHandler(this.iconButton_about_MouseLeave);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton6.IconColor = System.Drawing.Color.Crimson;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 741);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(192, 56);
            this.iconButton6.TabIndex = 11;
            this.iconButton6.Text = "Log Out";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            this.iconButton6.MouseEnter += new System.EventHandler(this.iconButton6_MouseEnter);
            this.iconButton6.MouseLeave += new System.EventHandler(this.iconButton6_MouseLeave);
            // 
            // iconButton_Cer
            // 
            this.iconButton_Cer.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_Cer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Cer.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Cer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Cer.IconChar = FontAwesome.Sharp.IconChar.FileLines;
            this.iconButton_Cer.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_Cer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Cer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Cer.Location = new System.Drawing.Point(0, 168);
            this.iconButton_Cer.Name = "iconButton_Cer";
            this.iconButton_Cer.Size = new System.Drawing.Size(192, 56);
            this.iconButton_Cer.TabIndex = 10;
            this.iconButton_Cer.Text = "Certificate";
            this.iconButton_Cer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Cer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Cer.UseVisualStyleBackColor = false;
            this.iconButton_Cer.Click += new System.EventHandler(this.iconButton_Cer_Click);
            this.iconButton_Cer.MouseEnter += new System.EventHandler(this.iconButton_Cer_MouseEnter);
            this.iconButton_Cer.MouseLeave += new System.EventHandler(this.iconButton_Cer_MouseLeave);
            // 
            // iconButton_Completed
            // 
            this.iconButton_Completed.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_Completed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_Completed.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Completed.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton_Completed.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_Completed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Completed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Completed.Location = new System.Drawing.Point(0, 112);
            this.iconButton_Completed.Name = "iconButton_Completed";
            this.iconButton_Completed.Size = new System.Drawing.Size(192, 56);
            this.iconButton_Completed.TabIndex = 9;
            this.iconButton_Completed.Text = "Completed";
            this.iconButton_Completed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Completed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Completed.UseVisualStyleBackColor = false;
            this.iconButton_Completed.Click += new System.EventHandler(this.iconButton_Completed_Click);
            this.iconButton_Completed.MouseEnter += new System.EventHandler(this.iconButton_Completed_MouseEnter);
            this.iconButton_Completed.MouseLeave += new System.EventHandler(this.iconButton_Completed_MouseLeave);
            // 
            // iconButton_InProgress
            // 
            this.iconButton_InProgress.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_InProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_InProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_InProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_InProgress.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.iconButton_InProgress.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_InProgress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_InProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_InProgress.Location = new System.Drawing.Point(0, 56);
            this.iconButton_InProgress.Name = "iconButton_InProgress";
            this.iconButton_InProgress.Size = new System.Drawing.Size(192, 56);
            this.iconButton_InProgress.TabIndex = 8;
            this.iconButton_InProgress.Text = "In Progress";
            this.iconButton_InProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_InProgress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_InProgress.UseVisualStyleBackColor = false;
            this.iconButton_InProgress.Click += new System.EventHandler(this.iconButton_InProgress_Click);
            this.iconButton_InProgress.MouseEnter += new System.EventHandler(this.iconButton_InProgress_MouseEnter);
            this.iconButton_InProgress.MouseLeave += new System.EventHandler(this.iconButton_InProgress_MouseLeave);
            // 
            // iconButton_home
            // 
            this.iconButton_home.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButton_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton_home.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.Location = new System.Drawing.Point(0, 0);
            this.iconButton_home.Name = "iconButton_home";
            this.iconButton_home.Size = new System.Drawing.Size(192, 56);
            this.iconButton_home.TabIndex = 7;
            this.iconButton_home.Text = "Home";
            this.iconButton_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_home.UseVisualStyleBackColor = false;
            this.iconButton_home.Click += new System.EventHandler(this.iconButton_home_Click);
            this.iconButton_home.MouseEnter += new System.EventHandler(this.iconButton_home_MouseEnter);
            this.iconButton_home.MouseLeave += new System.EventHandler(this.iconButton_home_MouseLeave);
            // 
            // Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1901, 1032);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Home_FormClosing);
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBox_CourseSearch;
        private FontAwesome.Sharp.IconButton iconButton_search;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton_Prof;
        private FontAwesome.Sharp.IconButton iconButton_about;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton_Cer;
        private FontAwesome.Sharp.IconButton iconButton_Completed;
        private FontAwesome.Sharp.IconButton iconButton_InProgress;
        private FontAwesome.Sharp.IconButton iconButton_home;
        private FontAwesome.Sharp.IconButton iconButton_name_leaner;
        private CustomControls.CircularButton circularButton_avt;
        private System.Windows.Forms.Panel panel2;
    }
}