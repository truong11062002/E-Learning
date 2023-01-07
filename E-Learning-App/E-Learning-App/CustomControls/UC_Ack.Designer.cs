
namespace E_Learning_App.CustomControls
{
    partial class UC_Ack
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
            this.label_name = new System.Windows.Forms.Label();
            this.pictureBox_ack = new System.Windows.Forms.PictureBox();
            this.label_taught_by = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ack)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Blue;
            this.label_name.Location = new System.Drawing.Point(252, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(92, 31);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "label1";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            this.label_name.MouseEnter += new System.EventHandler(this.label_name_MouseEnter);
            this.label_name.MouseLeave += new System.EventHandler(this.label_name_MouseLeave);
            // 
            // pictureBox_ack
            // 
            this.pictureBox_ack.Location = new System.Drawing.Point(29, 18);
            this.pictureBox_ack.Name = "pictureBox_ack";
            this.pictureBox_ack.Size = new System.Drawing.Size(128, 111);
            this.pictureBox_ack.TabIndex = 0;
            this.pictureBox_ack.TabStop = false;
            // 
            // label_taught_by
            // 
            this.label_taught_by.AutoSize = true;
            this.label_taught_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taught_by.ForeColor = System.Drawing.Color.Black;
            this.label_taught_by.Location = new System.Drawing.Point(253, 60);
            this.label_taught_by.Name = "label_taught_by";
            this.label_taught_by.Size = new System.Drawing.Size(64, 25);
            this.label_taught_by.TabIndex = 2;
            this.label_taught_by.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(189, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 110);
            this.panel2.TabIndex = 17;
            // 
            // UC_Ack
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_taught_by);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_ack);
            this.Name = "UC_Ack";
            this.Size = new System.Drawing.Size(1682, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ack;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_taught_by;
        private System.Windows.Forms.Panel panel2;
    }
}
