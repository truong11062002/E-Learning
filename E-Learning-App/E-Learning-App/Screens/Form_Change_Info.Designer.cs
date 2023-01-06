
namespace E_Learning_App.Screens
{
    partial class Form_Change_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Change_Info));
            this.circularButton1 = new E_Learning_App.CustomControls.CircularButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.circularButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circularButton1.BackgroundImage")));
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(946, -1);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(53, 49);
            this.circularButton1.TabIndex = 0;
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change your profile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Location = new System.Drawing.Point(284, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 51);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox_phone);
            this.panel2.Location = new System.Drawing.Point(284, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 51);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(27, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox_address);
            this.panel3.Location = new System.Drawing.Point(284, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 51);
            this.panel3.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Blue;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(33, 497);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 76);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Save changes";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_name.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_name.Location = new System.Drawing.Point(40, 12);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(411, 27);
            this.TextBox_name.TabIndex = 2;
            this.TextBox_name.Text = "Full name";
            // 
            // textBox_phone
            // 
            this.textBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.ForeColor = System.Drawing.Color.Gray;
            this.textBox_phone.Location = new System.Drawing.Point(40, 12);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(411, 27);
            this.textBox_phone.TabIndex = 2;
            this.textBox_phone.Text = "Phone number";
            // 
            // textBox_address
            // 
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.ForeColor = System.Drawing.Color.Gray;
            this.textBox_address.Location = new System.Drawing.Point(40, 12);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(411, 27);
            this.textBox_address.TabIndex = 2;
            this.textBox_address.Text = "Address";
            // 
            // Form_Change_Info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1000, 603);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Change_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Change_Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CircularButton circularButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_address;
    }
}