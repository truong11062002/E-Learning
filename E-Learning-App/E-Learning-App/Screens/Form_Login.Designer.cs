
namespace E_Learning_App.Screens
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton_SignUp = new FontAwesome.Sharp.IconButton();
            this.iconButton_login = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton_SignUp);
            this.panel1.Controls.Add(this.iconButton_login);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(21, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 702);
            this.panel1.TabIndex = 2;
            // 
            // iconButton_SignUp
            // 
            this.iconButton_SignUp.BackColor = System.Drawing.Color.White;
            this.iconButton_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_SignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_SignUp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_SignUp.IconColor = System.Drawing.Color.Black;
            this.iconButton_SignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_SignUp.Location = new System.Drawing.Point(25, 538);
            this.iconButton_SignUp.Name = "iconButton_SignUp";
            this.iconButton_SignUp.Size = new System.Drawing.Size(449, 60);
            this.iconButton_SignUp.TabIndex = 7;
            this.iconButton_SignUp.Text = "Sign-Up";
            this.iconButton_SignUp.UseVisualStyleBackColor = false;
            // 
            // iconButton_login
            // 
            this.iconButton_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_login.IconColor = System.Drawing.Color.Black;
            this.iconButton_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_login.Location = new System.Drawing.Point(25, 472);
            this.iconButton_login.Name = "iconButton_login";
            this.iconButton_login.Size = new System.Drawing.Size(449, 60);
            this.iconButton_login.TabIndex = 6;
            this.iconButton_login.Text = "Login";
            this.iconButton_login.UseVisualStyleBackColor = false;
            this.iconButton_login.Click += new System.EventHandler(this.iconButton_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(21, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forgot passcode?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TextBox_Email);
            this.panel2.Location = new System.Drawing.Point(24, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 59);
            this.panel2.TabIndex = 2;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Email.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_Email.Location = new System.Drawing.Point(19, 12);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(322, 31);
            this.TextBox_Email.TabIndex = 2;
            this.TextBox_Email.Text = "name@email.com";
            this.TextBox_Email.Enter += new System.EventHandler(this.TextBox_Email_Enter);
            this.TextBox_Email.Leave += new System.EventHandler(this.TextBox_Email_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_Password);
            this.panel3.Location = new System.Drawing.Point(24, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 59);
            this.panel3.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.Color.Gray;
            this.textBox_Password.Location = new System.Drawing.Point(19, 12);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(322, 31);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "Enter your password";
            this.textBox_Password.Enter += new System.EventHandler(this.textBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Email;
        private FontAwesome.Sharp.IconButton iconButton_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_Password;
        private FontAwesome.Sharp.IconButton iconButton_SignUp;
    }
}