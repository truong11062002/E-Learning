
namespace E_Learning_App.Screens
{
    partial class Form_Acknowledgement
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_certificate = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Courses";
            // 
            // flowLayoutPanel_certificate
            // 
            this.flowLayoutPanel_certificate.AutoScroll = true;
            this.flowLayoutPanel_certificate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel_certificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_certificate.Location = new System.Drawing.Point(0, 84);
            this.flowLayoutPanel_certificate.Name = "flowLayoutPanel_certificate";
            this.flowLayoutPanel_certificate.Size = new System.Drawing.Size(1682, 780);
            this.flowLayoutPanel_certificate.TabIndex = 1;
            // 
            // Form_Acknowledgement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1682, 864);
            this.Controls.Add(this.flowLayoutPanel_certificate);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Acknowledgement";
            this.Text = "Form_Acknowledgement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_certificate;
    }
}