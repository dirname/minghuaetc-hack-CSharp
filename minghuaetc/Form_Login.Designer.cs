namespace minghuaetc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.comboBox_school = new System.Windows.Forms.ComboBox();
            this.label_login_shcool = new System.Windows.Forms.Label();
            this.label_login_username = new System.Windows.Forms.Label();
            this.textBox_login_stuID = new System.Windows.Forms.TextBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.label_login_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_school
            // 
            this.comboBox_school.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_school.FormattingEnabled = true;
            this.comboBox_school.Location = new System.Drawing.Point(109, 42);
            this.comboBox_school.Name = "comboBox_school";
            this.comboBox_school.Size = new System.Drawing.Size(171, 20);
            this.comboBox_school.TabIndex = 0;
            // 
            // label_login_shcool
            // 
            this.label_login_shcool.AutoSize = true;
            this.label_login_shcool.Location = new System.Drawing.Point(14, 45);
            this.label_login_shcool.Name = "label_login_shcool";
            this.label_login_shcool.Size = new System.Drawing.Size(89, 12);
            this.label_login_shcool.TabIndex = 1;
            this.label_login_shcool.Text = "Your School : ";
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.Location = new System.Drawing.Point(14, 79);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(83, 12);
            this.label_login_username.TabIndex = 2;
            this.label_login_username.Text = "Student ID : ";
            // 
            // textBox_login_stuID
            // 
            this.textBox_login_stuID.Location = new System.Drawing.Point(109, 74);
            this.textBox_login_stuID.Name = "textBox_login_stuID";
            this.textBox_login_stuID.Size = new System.Drawing.Size(120, 21);
            this.textBox_login_stuID.TabIndex = 3;
            this.textBox_login_stuID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.Location = new System.Drawing.Point(109, 105);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.PasswordChar = '*';
            this.textBox_login_password.Size = new System.Drawing.Size(120, 21);
            this.textBox_login_password.TabIndex = 5;
            this.textBox_login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_login_password
            // 
            this.label_login_password.AutoSize = true;
            this.label_login_password.Location = new System.Drawing.Point(14, 110);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(71, 12);
            this.label_login_password.TabIndex = 4;
            this.label_login_password.Text = "Password : ";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(235, 73);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(45, 54);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 170);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.textBox_login_stuID);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.label_login_shcool);
            this.Controls.Add(this.comboBox_school);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Your Account";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_school;
        private System.Windows.Forms.Label label_login_shcool;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.TextBox textBox_login_stuID;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Label label_login_password;
        private System.Windows.Forms.Button button_login;
    }
}

