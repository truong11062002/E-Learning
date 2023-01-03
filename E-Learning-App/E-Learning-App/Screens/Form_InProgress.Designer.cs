
namespace E_Learning_App.Screens
{
    partial class Form_InProgress
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
            this.flowLayoutPanel_InProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_InProgress
            // 
            this.flowLayoutPanel_InProgress.AutoScroll = true;
            this.flowLayoutPanel_InProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_InProgress.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_InProgress.Name = "flowLayoutPanel_InProgress";
            this.flowLayoutPanel_InProgress.Size = new System.Drawing.Size(1682, 864);
            this.flowLayoutPanel_InProgress.TabIndex = 0;
            // 
            // Form_InProgress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1682, 864);
            this.Controls.Add(this.flowLayoutPanel_InProgress);
            this.Name = "Form_InProgress";
            this.Text = "Form_InProgress";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_InProgress;
    }
}