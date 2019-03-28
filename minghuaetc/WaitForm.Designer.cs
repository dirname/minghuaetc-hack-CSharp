namespace minghuaetc
{
    partial class WaitForm
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
            this.progressBar_wait = new System.Windows.Forms.ProgressBar();
            this.label_wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_wait
            // 
            this.progressBar_wait.Location = new System.Drawing.Point(33, 31);
            this.progressBar_wait.Name = "progressBar_wait";
            this.progressBar_wait.Size = new System.Drawing.Size(451, 20);
            this.progressBar_wait.TabIndex = 0;
            // 
            // label_wait
            // 
            this.label_wait.Location = new System.Drawing.Point(33, 67);
            this.label_wait.Name = "label_wait";
            this.label_wait.Size = new System.Drawing.Size(451, 36);
            this.label_wait.TabIndex = 1;
            this.label_wait.Text = "Starting.....";
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 112);
            this.Controls.Add(this.label_wait);
            this.Controls.Add(this.progressBar_wait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please wait ...";
            this.Load += new System.EventHandler(this.WaitForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label_wait;
        public System.Windows.Forms.ProgressBar progressBar_wait;
    }
}