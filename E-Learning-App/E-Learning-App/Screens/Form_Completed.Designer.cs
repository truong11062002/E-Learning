﻿
namespace E_Learning_App.Screens
{
    partial class Form_Completed
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
            this.flowLayoutPanel_completed = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_completed
            // 
            this.flowLayoutPanel_completed.AutoScroll = true;
            this.flowLayoutPanel_completed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_completed.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_completed.Name = "flowLayoutPanel_completed";
            this.flowLayoutPanel_completed.Size = new System.Drawing.Size(1682, 864);
            this.flowLayoutPanel_completed.TabIndex = 0;
            // 
            // Form_Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 864);
            this.Controls.Add(this.flowLayoutPanel_completed);
            this.Name = "Form_Completed";
            this.Text = "Form_Completed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_completed;
    }
}