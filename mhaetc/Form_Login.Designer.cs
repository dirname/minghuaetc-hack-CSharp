namespace mhaetc
{
    partial class Form_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_study_id = new System.Windows.Forms.Label();
            this.textBox_study_id = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox_study_pwd = new System.Windows.Forms.TextBox();
            this.label_stu_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_study_id
            // 
            this.label_study_id.AutoSize = true;
            this.label_study_id.Location = new System.Drawing.Point(28, 29);
            this.label_study_id.Name = "label_study_id";
            this.label_study_id.Size = new System.Drawing.Size(35, 12);
            this.label_study_id.TabIndex = 0;
            this.label_study_id.Text = "学号:";
            // 
            // textBox_study_id
            // 
            this.textBox_study_id.Location = new System.Drawing.Point(64, 25);
            this.textBox_study_id.Name = "textBox_study_id";
            this.textBox_study_id.Size = new System.Drawing.Size(166, 21);
            this.textBox_study_id.TabIndex = 1;
            this.textBox_study_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(97, 100);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_ClickAsync);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(28, 137);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(209, 36);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "本工具仅供交流学习使用，请于下载的\r\n24小时内删除，否则造成的一切法律责\r\n任与作者无关";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // textBox_study_pwd
            // 
            this.textBox_study_pwd.Location = new System.Drawing.Point(64, 67);
            this.textBox_study_pwd.Name = "textBox_study_pwd";
            this.textBox_study_pwd.PasswordChar = '*';
            this.textBox_study_pwd.Size = new System.Drawing.Size(166, 21);
            this.textBox_study_pwd.TabIndex = 3;
            this.textBox_study_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_stu_pwd
            // 
            this.label_stu_pwd.AutoSize = true;
            this.label_stu_pwd.Location = new System.Drawing.Point(28, 71);
            this.label_stu_pwd.Name = "label_stu_pwd";
            this.label_stu_pwd.Size = new System.Drawing.Size(35, 12);
            this.label_stu_pwd.TabIndex = 7;
            this.label_stu_pwd.Text = "密码:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 181);
            this.Controls.Add(this.textBox_study_pwd);
            this.Controls.Add(this.label_stu_pwd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_study_id);
            this.Controls.Add(this.label_study_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MinghuaEtc Online";
            this.Load += new System.EventHandler(this.Form_Login_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_study_id;
        private System.Windows.Forms.TextBox textBox_study_id;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox_study_pwd;
        private System.Windows.Forms.Label label_stu_pwd;
    }
}

