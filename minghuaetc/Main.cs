using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minghuaetc
{
    public partial class Main : Form
    {

        List<string> coureseIds = new List<string>();
        List<string> sessionIds = new List<string>();
        List<string> lessons = new List<string>();
        JObject coureseObject = new JObject();
        string submit_anwser = String.Empty;
        string exam_itemId = String.Empty;
        WaitForm progress_form;
        private int lesson_count;

        public Main()
        {
            InitializeComponent();
        }

        private void getCourses()
        {
            this.comboBox_main_courses.Items.Clear();
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "course.my");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("index", "1");
            request.AddParameter("size", "5");
            request.AddParameter("status", "10");
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            client.ExecuteAsync(request, response =>
            {
                string result = response.Content;
                try
                {
                    JObject jObject = JObject.Parse(result);
                    int code = (int)jObject["code"];
                    if (code > 0)
                    {
                        MessageBox.Show((string)jObject["message"], "运行出错", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    else
                    {
                        JArray jArray = (JArray)jObject["result"]["courses"];
                        new Thread(() =>
                        {
                            foreach (var i in jArray)
                            {
                                coureseIds.Add((string)i["courseId"]);
                                sessionIds.Add((string)i["sessionId"]);
                                Action<string> action = (data) =>
                                {
                                    this.comboBox_main_courses.Items.Add(data);
                                    this.comboBox_main_courses.SelectedIndex = 0;
                                };

                                Invoke(action, (string)i["courseName"] + " - " + (string)i["endDate"]);
                            }
                        }).Start();
                    }
                }
                catch
                {

                }
            });
        }

        private void addCourseToTree()
        {
            this.treeView_course.Nodes.Clear();
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "course.learn");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("course", coureseIds[comboBox_main_courses.SelectedIndex]);
            request.AddParameter("session", sessionIds[comboBox_main_courses.SelectedIndex]);
            request.AddParameter("all", "1");
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            lesson_count = 0;
            client.ExecuteAsync(request, response =>
            {
                string result = response.Content;
                try
                {
                    coureseObject = JObject.Parse(result);
                    int code = (int)coureseObject["code"];
                    if (code > 0)
                    {
                        MessageBox.Show((string)coureseObject["message"], "运行出错", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    else
                    {
                        JArray jArray = (JArray)coureseObject["result"]["units"];
                        new Thread(() =>
                        {
                            foreach (var i in jArray)
                            {
                                Action<JObject> action = (data) =>
                                {
                                    TreeNode node = this.treeView_course.Nodes.Add((string)data["unitNo"] + " " + (string)data["unitName"]);
                                    JArray lessons = (JArray)data["lessons"];
                                    foreach(var item in lessons)
                                    {
                                        TreeNode item_node = node.Nodes.Add((string)item["lessonNo"] + " " + (string)item["lessonName"]);
                                        JArray items = (JArray)item["items"];
                                        foreach(var item_class in items)
                                        {
                                            if ((string)item_class["itemType"] == "50")
                                            {
                                                node.Text += "[Exam.]";
                                            }
                                            item_node.Nodes.Add((string)item_class["itemName"]);
                                            lesson_count++;
                                        }
                                    }
                                    this.textBox_course_info.Text = "Please select a lesson from the tree on the left now.";
                                };

                                Invoke(action, (JObject)i);
                            }
                        }).Start();
                    }
                }
                catch
                {

                }
            });
        }

        private string getDuration(string itemId, string itemType)
        {
            var client = new RestClient("http://www.minghuaetc.com/study/play.mooc");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "http://www.minghuaetc.com/study/unit/" + itemId + ".mooc");
            request.AddParameter("itemId", itemId);
            request.AddParameter("itemType", itemType);
            request.AddParameter("testPaperId", "");
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            IRestResponse response = client.Execute(request);
            Regex reg = new Regex("meta = {\"duration.*");
            //例如我想提取记录中的NAME值
            MatchCollection match = reg.Matches(response.Content);
            string value = match[0].ToString().Replace("meta = ", "").Replace("};", "}");
            return value;
        }

        private string getAnswer(string itemId)
        {
            //cmd=exam.get.test&client=chinamoocs&itemid=193605&withkey=0&sign=0df75b39eedd25e24e7cc2f9842d76ae
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "exam.get.test");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("itemid", itemId);
            request.AddParameter("withkey", "1");
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Minghuaetc Mooc Cheat Tool - Current user name is " + Client.stuName + " - Powered by Ah !";
            getCourses();
        }

        private void LoginForm()
        {
            Application.Run(new Form_Login());
        }

        private void button_courses_refresh_Click(object sender, EventArgs e)
        {
            getCourses();
        }

        private void comboBox_main_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            addCourseToTree();
        }

        private void treeView_course_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Level == 2)
                {
                    string info = String.Empty;
                    string itemId = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["itemId"];
                    string itemName = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["itemName"];
                    string itemType = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["itemType"];
                    string status = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["status"];
                    string url = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["url"];
                    if (itemType == "10")
                    {
                        switch (status)
                        {
                            case "1":
                                status = "Watching";
                                break;
                            case "0":
                                status = "Not watched yet";
                                break;
                            case "2":
                                status = "Watched";
                                break;
                        }
                        info = "Type:Mooc" + Environment.NewLine + Environment.NewLine + "ItemID:" + itemId + System.Environment.NewLine + Environment.NewLine + "ItemName:" + itemName + System.Environment.NewLine + Environment.NewLine + "Status:" + status + Environment.NewLine + Environment.NewLine + "Viedo:" + url;
                    }
                    else if (itemType == "50")
                    {
                        string examFinalGrade = (string)coureseObject["result"]["units"][e.Node.Parent.Parent.Index]["lessons"][e.Node.Parent.Index]["items"][e.Node.Index]["examFinalGrade"];
                        if (examFinalGrade == String.Empty)
                        {
                            examFinalGrade = "Not yet submitted.";
                        }
                        info = "Type:Exam" + System.Environment.NewLine + Environment.NewLine + "ItemID:" + itemId + System.Environment.NewLine + Environment.NewLine + "Grade:" + examFinalGrade;
                    }
                    textBox_course_info.Text = info;
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void button_exam_get_Click(object sender, EventArgs e)
        {
            getExam();
            
        }

        private void getExam()
        {
            button_submit_question.Enabled = false;
            exam_itemId = String.Empty;
            string res = getAnswer(textBox_exam_itemid.Text);
            submit_anwser = String.Empty;
            this.listView_exam_list.Items.Clear();
            try
            {
                JObject jObject = JObject.Parse(res);
                int code = (int)jObject["code"];
                if (code > 0)
                {
                    MessageBox.Show((string)jObject["message"], "Get Exam Answer Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    JArray questions = (JArray)jObject["result"]["paper"];
                    JArray userAnswers = new JArray();
                    foreach (var question in questions)
                    {
                        ListViewItem listViewItem = new ListViewItem((string)question["quizId"]);
                        listViewItem.SubItems.Add((string)question["quizContent"]);
                        JArray answers = (JArray)question["quizOptionses"];
                        JObject @object = new JObject();
                        JArray jArray = new JArray();
                        @object["quizId"] = (string)question["quizId"];
                        string content = "";
                        foreach (var answer in answers)
                        {
                            if ((bool)answer["isAnswer"])
                            {
                                jArray.Add((string)answer["optionId"]);
                                content += (string)answer["optionContent"] + ",";
                            }
                        }
                        listViewItem.SubItems.Add(content.Substring(0, content.Length - 1));
                        if (jArray.Count == 1)
                        {
                            @object["userAnswer"] = jArray[0].ToString();
                        }
                        else
                        {
                            string user_anw = String.Empty;
                            foreach(var anw in jArray)
                            {
                                user_anw += (string)anw + ",";
                            }
                            @object["userAnswer"] = user_anw.Substring(0, user_anw.Length - 1);
                        }
                        
                        @object["useTime"] = "10";
                        userAnswers.Add(@object);
                        this.listView_exam_list.Items.Add(listViewItem);
                    }
                    exam_itemId = textBox_exam_itemid.Text;
                    submit_anwser = userAnswers.ToString();
                    button_submit_question.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button_submit_question_Click(object sender, EventArgs e)
        {
            button_submit_question.Enabled = false;
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "exam.get.test");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("itemid", exam_itemId);
            request.AddParameter("withkey", "0");
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            IRestResponse response = client.Execute(request);
            JObject jObject = JObject.Parse(response.Content);
            int code = (int)jObject["code"];
            if (code > 0)
            {
                MessageBox.Show((string)jObject["message"], "Submit Exam Answer Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button_submit_question.Enabled = true;
            }
            else
            {
                string testPaperId = (string)jObject["result"]["testPaperId"];
                string submitId = (string)jObject["result"]["submitId"];
                string paperId = (string)jObject["result"]["paperId"];
                submit_anwser_test(testPaperId, submitId, paperId);
            }
        }

        private void submit_anwser_test(string testPaperId, string submitId, string paperId)
        {
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "exam.submit.test");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("paperid", paperId);
            request.AddParameter("testpaperid", testPaperId);
            request.AddParameter("submitid", submitId);
            request.AddParameter("usetime", "300");
            request.AddParameter("answers", submit_anwser);
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            IRestResponse response = client.Execute(request);
            try
            {
                JObject jObject = JObject.Parse(response.Content);
                MessageBoxEx.Show(this, (string) jObject["message"], "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

            }
           
            button_submit_question.Enabled = true;
        }

        private void button_course_complete_Click(object sender, EventArgs e)
        {
            this.backgroundWorker_main.RunWorkerAsync(); // 运行 backgroundWorker 组件
            progress_form = new WaitForm(this.backgroundWorker_main); // 显示进度条窗体
            progress_form.ShowDialog(this);
            progress_form.Close();
            MessageBoxEx.Show(this, "It's done.", "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private string submit_lessons(string itemId, string duration, string meta, string name)
        {
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "learn.pos");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("item", itemId);
            request.AddParameter("last", duration);
            request.AddParameter("max", duration);
            request.AddParameter("meta", meta);
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            request.AddCookie("moocsk", Client.moocsk);
            request.AddCookie("moocvk", Client.moocvk);
            IRestResponse response = client.Execute(request);
            JObject jObject = JObject.Parse(response.Content);
            return name + " - " + (string)jObject["message"];
        }

        private void backgroundWorker_main_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            JArray units = (JArray)coureseObject["result"]["units"];
            progress_form.progressBar_wait.Maximum = lesson_count;
            int i = 0;
            foreach(var unit in units)
            {
                JArray lessons = (JArray)unit["lessons"];
                foreach(var lesson in lessons)
                {
                    JArray array = (JArray)lesson["items"];
                    foreach(var item in array)
                    {
                        string itemId = (string)item["itemId"];
                        string itemType = (string)item["itemType"];
                        string itemName = (string)item["itemName"];
                        string meta = (string)item["meta"];
                        if (itemType == "10")
                        {
                            i++;
                            string res = getDuration(itemId, itemType);
                            JObject jObject = JObject.Parse(res);
                            string duration = (string)jObject["duration"];
                            string result = submit_lessons(itemId, duration, meta, itemName);
                            worker.ReportProgress(i);
                            Action<string> action = (data) =>
                            {
                                progress_form.label_wait.Text = data.ToString();
                            };

                            Invoke(action, (string)result.ToString());

                            if (worker.CancellationPending)  // 如果用户取消则跳出处理数据代码 
                            {
                                e.Cancel = true;
                                break;
                            }
                        }
                    }
                }
            }
            
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thrT = new System.Threading.Thread(new System.Threading.ThreadStart(LoginForm));
            thrT.Start();
            while (thrT.ThreadState != System.Threading.ThreadState.Running) ;
            this.Close();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeView_course.SelectedNode.Level == 2 && (string)coureseObject["result"]["units"][this.treeView_course.SelectedNode.Parent.Parent.Index]["lessons"][this.treeView_course.SelectedNode.Parent.Index]["items"][this.treeView_course.SelectedNode.Index]["itemType"] == "50")
            {
                contextMenuStrip.Items[0].Enabled = true;
            }
            else
            {
                contextMenuStrip.Items[0].Enabled = false;
            }
        }

        private void copyItemIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forwardToExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string itemId = (string)coureseObject["result"]["units"][this.treeView_course.SelectedNode.Parent.Parent.Index]["lessons"][this.treeView_course.SelectedNode.Parent.Index]["items"][this.treeView_course.SelectedNode.Index]["itemId"];
            textBox_exam_itemid.Text = itemId;
            tabControl_log.SelectedIndex = 1;
            getExam();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dirname/minghuaetc-hack-CSharp");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
