
namespace E_Learning_App.CustomControls
{
    partial class UC_Reviews
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
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_review = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_name.Location = new System.Drawing.Point(36, 10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 29);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datetime.ForeColor = System.Drawing.Color.DimGray;
            this.label_datetime.Location = new System.Drawing.Point(1033, 129);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(109, 29);
            this.label_datetime.TabIndex = 1;
            this.label_datetime.Text = "Datetime";
            // 
            // label_review
            // 
            this.label_review.AutoSize = true;
            this.label_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_review.ForeColor = System.Drawing.Color.Black;
            this.label_review.Location = new System.Drawing.Point(36, 58);
            this.label_review.MaximumSize = new System.Drawing.Size(975, 0);
            this.label_review.Name = "label_review";
            this.label_review.Size = new System.Drawing.Size(64, 25);
            this.label_review.TabIndex = 2;
            this.label_review.Text = "Name";
            // 
            // UC_Reviews
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label_review);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.label_name);
            this.Name = "UC_Reviews";
            this.Size = new System.Drawing.Size(1325, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_review;
    }
}
