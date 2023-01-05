
namespace E_Learning_App.Screens
{
    partial class Form_Reviews
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ShowReview = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_review = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 360);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Blue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(53, 57);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(184, 64);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Go to course";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Learner Reviews and Feedback";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel_ShowReview
            // 
            this.flowLayoutPanel_ShowReview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_ShowReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_ShowReview.Location = new System.Drawing.Point(0, 360);
            this.flowLayoutPanel_ShowReview.Name = "flowLayoutPanel_ShowReview";
            this.flowLayoutPanel_ShowReview.Size = new System.Drawing.Size(1332, 493);
            this.flowLayoutPanel_ShowReview.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(50, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Review";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBox_review);
            this.panel2.Location = new System.Drawing.Point(54, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 157);
            this.panel2.TabIndex = 5;
            // 
            // TextBox_review
            // 
            this.TextBox_review.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_review.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_review.Location = new System.Drawing.Point(18, 12);
            this.TextBox_review.Name = "TextBox_review";
            this.TextBox_review.Size = new System.Drawing.Size(314, 27);
            this.TextBox_review.TabIndex = 2;
            this.TextBox_review.Text = "Enter review for this course";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Blue;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(525, 258);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(156, 64);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Review";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1332, 2);
            this.panel3.TabIndex = 7;
            // 
            // Form_Reviews
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 853);
            this.Controls.Add(this.flowLayoutPanel_ShowReview);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Reviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Reviews";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ShowReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox TextBox_review;
        private System.Windows.Forms.Panel panel3;
    }
}