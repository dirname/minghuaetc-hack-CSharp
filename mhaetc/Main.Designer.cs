namespace mhaetc
{
    partial class Main
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
            this.groupBox_user = new System.Windows.Forms.GroupBox();
            this.label_user_name = new System.Windows.Forms.Label();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.groupBox_lesson_info = new System.Windows.Forms.GroupBox();
            this.label_lesson_status = new System.Windows.Forms.Label();
            this.button_crack = new System.Windows.Forms.Button();
            this.label_lesson_size = new System.Windows.Forms.Label();
            this.label_lesson_name = new System.Windows.Forms.Label();
            this.groupBox_lesson_setting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_units = new System.Windows.Forms.Label();
            this.comboBox_lesson = new System.Windows.Forms.ComboBox();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.groupBox_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.groupBox_lesson_info.SuspendLayout();
            this.groupBox_lesson_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_user
            // 
            this.groupBox_user.Controls.Add(this.label_user_name);
            this.groupBox_user.Controls.Add(this.pictureBox_avatar);
            this.groupBox_user.Location = new System.Drawing.Point(13, 12);
            this.groupBox_user.Name = "groupBox_user";
            this.groupBox_user.Size = new System.Drawing.Size(200, 182);
            this.groupBox_user.TabIndex = 1;
            this.groupBox_user.TabStop = false;
            this.groupBox_user.Text = "用户信息:";
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Location = new System.Drawing.Point(59, 143);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(35, 12);
            this.label_user_name.TabIndex = 2;
            this.label_user_name.Text = "姓名:";
            this.label_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Location = new System.Drawing.Point(50, 40);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 1;
            this.pictureBox_avatar.TabStop = false;
            // 
            // groupBox_lesson_info
            // 
            this.groupBox_lesson_info.Controls.Add(this.label_lesson_status);
            this.groupBox_lesson_info.Controls.Add(this.button_crack);
            this.groupBox_lesson_info.Controls.Add(this.label_lesson_size);
            this.groupBox_lesson_info.Controls.Add(this.label_lesson_name);
            this.groupBox_lesson_info.Location = new System.Drawing.Point(219, 111);
            this.groupBox_lesson_info.Name = "groupBox_lesson_info";
            this.groupBox_lesson_info.Size = new System.Drawing.Size(569, 81);
            this.groupBox_lesson_info.TabIndex = 3;
            this.groupBox_lesson_info.TabStop = false;
            this.groupBox_lesson_info.Text = "课程信息:";
            // 
            // label_lesson_status
            // 
            this.label_lesson_status.AutoSize = true;
            this.label_lesson_status.Location = new System.Drawing.Point(253, 44);
            this.label_lesson_status.Name = "label_lesson_status";
            this.label_lesson_status.Size = new System.Drawing.Size(59, 12);
            this.label_lesson_status.TabIndex = 4;
            this.label_lesson_status.Text = "课程状态:";
            // 
            // button_crack
            // 
            this.button_crack.Location = new System.Drawing.Point(460, 39);
            this.button_crack.Name = "button_crack";
            this.button_crack.Size = new System.Drawing.Size(94, 23);
            this.button_crack.TabIndex = 3;
            this.button_crack.Text = "Crack it !!!";
            this.button_crack.UseVisualStyleBackColor = true;
            this.button_crack.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label_lesson_size
            // 
            this.label_lesson_size.AutoSize = true;
            this.label_lesson_size.Location = new System.Drawing.Point(8, 44);
            this.label_lesson_size.Name = "label_lesson_size";
            this.label_lesson_size.Size = new System.Drawing.Size(95, 12);
            this.label_lesson_size.TabIndex = 1;
            this.label_lesson_size.Text = "课程视频分辨率:";
            // 
            // label_lesson_name
            // 
            this.label_lesson_name.AutoSize = true;
            this.label_lesson_name.Location = new System.Drawing.Point(8, 21);
            this.label_lesson_name.Name = "label_lesson_name";
            this.label_lesson_name.Size = new System.Drawing.Size(59, 12);
            this.label_lesson_name.TabIndex = 0;
            this.label_lesson_name.Text = "课程名称:";
            // 
            // groupBox_lesson_setting
            // 
            this.groupBox_lesson_setting.Controls.Add(this.label1);
            this.groupBox_lesson_setting.Controls.Add(this.label_units);
            this.groupBox_lesson_setting.Controls.Add(this.comboBox_lesson);
            this.groupBox_lesson_setting.Controls.Add(this.comboBox_units);
            this.groupBox_lesson_setting.Location = new System.Drawing.Point(219, 26);
            this.groupBox_lesson_setting.Name = "groupBox_lesson_setting";
            this.groupBox_lesson_setting.Size = new System.Drawing.Size(569, 60);
            this.groupBox_lesson_setting.TabIndex = 4;
            this.groupBox_lesson_setting.TabStop = false;
            this.groupBox_lesson_setting.Text = "课程设置:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lesson:";
            // 
            // label_units
            // 
            this.label_units.AutoSize = true;
            this.label_units.Location = new System.Drawing.Point(8, 25);
            this.label_units.Name = "label_units";
            this.label_units.Size = new System.Drawing.Size(41, 12);
            this.label_units.TabIndex = 2;
            this.label_units.Text = "Units:";
            // 
            // comboBox_lesson
            // 
            this.comboBox_lesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lesson.FormattingEnabled = true;
            this.comboBox_lesson.Location = new System.Drawing.Point(291, 21);
            this.comboBox_lesson.Name = "comboBox_lesson";
            this.comboBox_lesson.Size = new System.Drawing.Size(272, 20);
            this.comboBox_lesson.TabIndex = 1;
            this.comboBox_lesson.SelectedIndexChanged += new System.EventHandler(this.comboBox_lesson_SelectedIndexChangedAsync);
            // 
            // comboBox_units
            // 
            this.comboBox_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Location = new System.Drawing.Point(55, 21);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(180, 20);
            this.comboBox_units.TabIndex = 0;
            this.comboBox_units.SelectedIndexChanged += new System.EventHandler(this.comboBox_units_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.groupBox_lesson_setting);
            this.Controls.Add(this.groupBox_lesson_info);
            this.Controls.Add(this.groupBox_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MinghuaEtc Tool";
            this.Shown += new System.EventHandler(this.Main_ShownAsync);
            this.groupBox_user.ResumeLayout(false);
            this.groupBox_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.groupBox_lesson_info.ResumeLayout(false);
            this.groupBox_lesson_info.PerformLayout();
            this.groupBox_lesson_setting.ResumeLayout(false);
            this.groupBox_lesson_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_user;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.GroupBox groupBox_lesson_info;
        private System.Windows.Forms.Label label_lesson_name;
        private System.Windows.Forms.Label label_lesson_size;
        private System.Windows.Forms.Button button_crack;
        private System.Windows.Forms.GroupBox groupBox_lesson_setting;
        private System.Windows.Forms.ComboBox comboBox_units;
        private System.Windows.Forms.ComboBox comboBox_lesson;
        private System.Windows.Forms.Label label_lesson_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_units;
    }
}