namespace minghuaetc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl_log = new System.Windows.Forms.TabControl();
            this.tabPage_courses = new System.Windows.Forms.TabPage();
            this.textBox_course_info = new System.Windows.Forms.TextBox();
            this.label_course_info = new System.Windows.Forms.Label();
            this.button_course_complete = new System.Windows.Forms.Button();
            this.treeView_course = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.forwardToExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_courses_refresh = new System.Windows.Forms.Button();
            this.comboBox_main_courses = new System.Windows.Forms.ComboBox();
            this.label_main_courses = new System.Windows.Forms.Label();
            this.tabPage_exam = new System.Windows.Forms.TabPage();
            this.button_submit_question = new System.Windows.Forms.Button();
            this.listView_exam_list = new System.Windows.Forms.ListView();
            this.columnHeader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_exam_get = new System.Windows.Forms.Button();
            this.textBox_exam_itemid = new System.Windows.Forms.TextBox();
            this.label_exam_tips = new System.Windows.Forms.Label();
            this.label_exam_itemid = new System.Windows.Forms.Label();
            this.backgroundWorker_main = new System.ComponentModel.BackgroundWorker();
            this.menuStrip_app = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_log.SuspendLayout();
            this.tabPage_courses.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tabPage_exam.SuspendLayout();
            this.menuStrip_app.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_log
            // 
            this.tabControl_log.Controls.Add(this.tabPage_courses);
            this.tabControl_log.Controls.Add(this.tabPage_exam);
            this.tabControl_log.Location = new System.Drawing.Point(12, 37);
            this.tabControl_log.Name = "tabControl_log";
            this.tabControl_log.SelectedIndex = 0;
            this.tabControl_log.Size = new System.Drawing.Size(759, 414);
            this.tabControl_log.TabIndex = 0;
            // 
            // tabPage_courses
            // 
            this.tabPage_courses.Controls.Add(this.textBox_course_info);
            this.tabPage_courses.Controls.Add(this.label_course_info);
            this.tabPage_courses.Controls.Add(this.button_course_complete);
            this.tabPage_courses.Controls.Add(this.treeView_course);
            this.tabPage_courses.Controls.Add(this.button_courses_refresh);
            this.tabPage_courses.Controls.Add(this.comboBox_main_courses);
            this.tabPage_courses.Controls.Add(this.label_main_courses);
            this.tabPage_courses.Location = new System.Drawing.Point(4, 22);
            this.tabPage_courses.Name = "tabPage_courses";
            this.tabPage_courses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_courses.Size = new System.Drawing.Size(751, 388);
            this.tabPage_courses.TabIndex = 0;
            this.tabPage_courses.Text = "Courses";
            this.tabPage_courses.UseVisualStyleBackColor = true;
            // 
            // textBox_course_info
            // 
            this.textBox_course_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_course_info.Location = new System.Drawing.Point(578, 60);
            this.textBox_course_info.Multiline = true;
            this.textBox_course_info.Name = "textBox_course_info";
            this.textBox_course_info.ReadOnly = true;
            this.textBox_course_info.Size = new System.Drawing.Size(167, 322);
            this.textBox_course_info.TabIndex = 7;
            this.textBox_course_info.Text = "Please select a lesson from the tree on the left now.";
            // 
            // label_course_info
            // 
            this.label_course_info.AutoSize = true;
            this.label_course_info.Location = new System.Drawing.Point(576, 44);
            this.label_course_info.Name = "label_course_info";
            this.label_course_info.Size = new System.Drawing.Size(41, 12);
            this.label_course_info.TabIndex = 6;
            this.label_course_info.Text = "Info :";
            // 
            // button_course_complete
            // 
            this.button_course_complete.Location = new System.Drawing.Point(546, 11);
            this.button_course_complete.Name = "button_course_complete";
            this.button_course_complete.Size = new System.Drawing.Size(144, 23);
            this.button_course_complete.TabIndex = 4;
            this.button_course_complete.Text = "Complete all courses";
            this.button_course_complete.UseVisualStyleBackColor = true;
            this.button_course_complete.Click += new System.EventHandler(this.button_course_complete_Click);
            // 
            // treeView_course
            // 
            this.treeView_course.ContextMenuStrip = this.contextMenuStrip;
            this.treeView_course.Location = new System.Drawing.Point(17, 44);
            this.treeView_course.Name = "treeView_course";
            this.treeView_course.Size = new System.Drawing.Size(552, 338);
            this.treeView_course.TabIndex = 3;
            this.treeView_course.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_course_NodeMouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forwardToExamToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(176, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // forwardToExamToolStripMenuItem
            // 
            this.forwardToExamToolStripMenuItem.Name = "forwardToExamToolStripMenuItem";
            this.forwardToExamToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.forwardToExamToolStripMenuItem.Text = "Forward to Exam";
            this.forwardToExamToolStripMenuItem.Click += new System.EventHandler(this.forwardToExamToolStripMenuItem_Click);
            // 
            // button_courses_refresh
            // 
            this.button_courses_refresh.Location = new System.Drawing.Point(461, 11);
            this.button_courses_refresh.Name = "button_courses_refresh";
            this.button_courses_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_courses_refresh.TabIndex = 2;
            this.button_courses_refresh.Text = "Refresh";
            this.button_courses_refresh.UseVisualStyleBackColor = true;
            this.button_courses_refresh.Click += new System.EventHandler(this.button_courses_refresh_Click);
            // 
            // comboBox_main_courses
            // 
            this.comboBox_main_courses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_main_courses.FormattingEnabled = true;
            this.comboBox_main_courses.Location = new System.Drawing.Point(144, 12);
            this.comboBox_main_courses.Name = "comboBox_main_courses";
            this.comboBox_main_courses.Size = new System.Drawing.Size(310, 20);
            this.comboBox_main_courses.TabIndex = 1;
            this.comboBox_main_courses.SelectedIndexChanged += new System.EventHandler(this.comboBox_main_courses_SelectedIndexChanged);
            // 
            // label_main_courses
            // 
            this.label_main_courses.AutoSize = true;
            this.label_main_courses.Location = new System.Drawing.Point(83, 15);
            this.label_main_courses.Name = "label_main_courses";
            this.label_main_courses.Size = new System.Drawing.Size(65, 12);
            this.label_main_courses.TabIndex = 0;
            this.label_main_courses.Text = "Courses : ";
            // 
            // tabPage_exam
            // 
            this.tabPage_exam.Controls.Add(this.button_submit_question);
            this.tabPage_exam.Controls.Add(this.listView_exam_list);
            this.tabPage_exam.Controls.Add(this.label1);
            this.tabPage_exam.Controls.Add(this.button_exam_get);
            this.tabPage_exam.Controls.Add(this.textBox_exam_itemid);
            this.tabPage_exam.Controls.Add(this.label_exam_tips);
            this.tabPage_exam.Controls.Add(this.label_exam_itemid);
            this.tabPage_exam.Location = new System.Drawing.Point(4, 22);
            this.tabPage_exam.Name = "tabPage_exam";
            this.tabPage_exam.Size = new System.Drawing.Size(751, 388);
            this.tabPage_exam.TabIndex = 2;
            this.tabPage_exam.Text = "Exam Answer";
            this.tabPage_exam.UseVisualStyleBackColor = true;
            // 
            // button_submit_question
            // 
            this.button_submit_question.Enabled = false;
            this.button_submit_question.Location = new System.Drawing.Point(236, 360);
            this.button_submit_question.Name = "button_submit_question";
            this.button_submit_question.Size = new System.Drawing.Size(278, 23);
            this.button_submit_question.TabIndex = 6;
            this.button_submit_question.Text = "Submit the correct answer to this question";
            this.button_submit_question.UseVisualStyleBackColor = true;
            this.button_submit_question.Click += new System.EventHandler(this.button_submit_question_Click);
            // 
            // listView_exam_list
            // 
            this.listView_exam_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_content,
            this.columnHeader_answer});
            this.listView_exam_list.FullRowSelect = true;
            this.listView_exam_list.Location = new System.Drawing.Point(15, 145);
            this.listView_exam_list.Name = "listView_exam_list";
            this.listView_exam_list.Size = new System.Drawing.Size(723, 211);
            this.listView_exam_list.TabIndex = 5;
            this.listView_exam_list.UseCompatibleStateImageBehavior = false;
            this.listView_exam_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "ID";
            // 
            // columnHeader_content
            // 
            this.columnHeader_content.Text = "Question";
            this.columnHeader_content.Width = 400;
            // 
            // columnHeader_answer
            // 
            this.columnHeader_answer.Text = "Answer";
            this.columnHeader_answer.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "You need to submit it it manually at least once to get the answer !!!";
            // 
            // button_exam_get
            // 
            this.button_exam_get.Location = new System.Drawing.Point(419, 115);
            this.button_exam_get.Name = "button_exam_get";
            this.button_exam_get.Size = new System.Drawing.Size(75, 23);
            this.button_exam_get.TabIndex = 3;
            this.button_exam_get.Text = "Get Answer";
            this.button_exam_get.UseVisualStyleBackColor = true;
            this.button_exam_get.Click += new System.EventHandler(this.button_exam_get_Click);
            // 
            // textBox_exam_itemid
            // 
            this.textBox_exam_itemid.Location = new System.Drawing.Point(313, 116);
            this.textBox_exam_itemid.Name = "textBox_exam_itemid";
            this.textBox_exam_itemid.Size = new System.Drawing.Size(100, 21);
            this.textBox_exam_itemid.TabIndex = 2;
            this.textBox_exam_itemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_exam_tips
            // 
            this.label_exam_tips.ForeColor = System.Drawing.Color.Red;
            this.label_exam_tips.Location = new System.Drawing.Point(13, 10);
            this.label_exam_tips.Name = "label_exam_tips";
            this.label_exam_tips.Size = new System.Drawing.Size(735, 60);
            this.label_exam_tips.TabIndex = 1;
            this.label_exam_tips.Text = resources.GetString("label_exam_tips.Text");
            this.label_exam_tips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_exam_itemid
            // 
            this.label_exam_itemid.AutoSize = true;
            this.label_exam_itemid.Location = new System.Drawing.Point(260, 120);
            this.label_exam_itemid.Name = "label_exam_itemid";
            this.label_exam_itemid.Size = new System.Drawing.Size(47, 12);
            this.label_exam_itemid.TabIndex = 0;
            this.label_exam_itemid.Text = "ItemID:";
            // 
            // backgroundWorker_main
            // 
            this.backgroundWorker_main.WorkerReportsProgress = true;
            this.backgroundWorker_main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_main_DoWork);
            // 
            // menuStrip_app
            // 
            this.menuStrip_app.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip_app.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_app.Name = "menuStrip_app";
            this.menuStrip_app.Size = new System.Drawing.Size(781, 25);
            this.menuStrip_app.TabIndex = 9;
            this.menuStrip_app.Text = "menuStrip_app";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "User";
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.changeUserToolStripMenuItem.Text = "Change user";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gitHubToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 462);
            this.Controls.Add(this.menuStrip_app);
            this.Controls.Add(this.tabControl_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minghuaetc Mooc Cheat Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl_log.ResumeLayout(false);
            this.tabPage_courses.ResumeLayout(false);
            this.tabPage_courses.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabPage_exam.ResumeLayout(false);
            this.tabPage_exam.PerformLayout();
            this.menuStrip_app.ResumeLayout(false);
            this.menuStrip_app.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_log;
        private System.Windows.Forms.TabPage tabPage_courses;
        private System.Windows.Forms.TabPage tabPage_exam;
        private System.Windows.Forms.ComboBox comboBox_main_courses;
        private System.Windows.Forms.Label label_main_courses;
        private System.Windows.Forms.Button button_courses_refresh;
        private System.Windows.Forms.TreeView treeView_course;
        private System.Windows.Forms.Button button_course_complete;
        private System.Windows.Forms.TextBox textBox_course_info;
        private System.Windows.Forms.Label label_course_info;
        private System.Windows.Forms.Button button_exam_get;
        private System.Windows.Forms.TextBox textBox_exam_itemid;
        private System.Windows.Forms.Label label_exam_tips;
        private System.Windows.Forms.Label label_exam_itemid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_exam_list;
        private System.Windows.Forms.ColumnHeader columnHeader_content;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ColumnHeader columnHeader_answer;
        private System.Windows.Forms.Button button_submit_question;
        private System.ComponentModel.BackgroundWorker backgroundWorker_main;
        private System.Windows.Forms.MenuStrip menuStrip_app;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem forwardToExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}