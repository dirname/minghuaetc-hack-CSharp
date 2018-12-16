using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mhaetc
{
    public partial class Main : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        bool isReady = false;
        string duration = null;
        string itemid = null;
        string jsonString = null;
        string meta_Label = null;
        int lastUnitsindex = 0;
        int lastLessonIndex = 0;

        public Main()
        {
            InitializeComponent();
        }

        private async void Main_ShownAsync(object sender, EventArgs e)
        {
            RestClient restClient;
            RestRequest restRequest;
            IRestResponse restResponse = null;
            restClient = new RestClient(ToolClass.avatarUrl);
            
            restRequest = new RestRequest(Method.GET);
            restClient.Encoding = Encoding.UTF8;
            restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);
            MemoryStream ms = new MemoryStream(restResponse.RawBytes);
            pictureBox_avatar.Image = Image.FromStream(ms);
            label_user_name.Text = "姓名:" + ToolClass.username;

            getLessonAsync();
        }

        private async void getLessonAsync()
        {
            RestClient restClient;
            RestRequest restRequest;
            IRestResponse restResponse = null;
            string cmd = "course.learn";
            string client = "chinamoocs";
            string course = "course ID"; //修改为课程id，可在网页源代码里查看，或者抓包获取
            string session = "session ID"; //修改为课程id，可在网页源代码里查看，或者抓包获取
            string all = "1";
            string sign = ToolClass.getSign(cmd + client + course + session + all);
            restClient = new RestClient("http://api.mooc.minghuaetc.com/v1");
            restRequest = new RestRequest(Method.POST);
            restRequest.AddCookie("moocvk", ToolClass.moocvk);
            restRequest.AddCookie("moocsk", ToolClass.moocsk);
            restRequest.AddParameter("cmd", cmd);
            restRequest.AddParameter("client", client);
            restRequest.AddParameter("course", course);
            restRequest.AddParameter("session", session);
            restRequest.AddParameter("all", "1");
            restRequest.AddParameter("sign", sign);

            restClient.Encoding = Encoding.UTF8;
            restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);
            jsonString = restResponse.Content;
            JObject jObject = JObject.Parse(restResponse.Content);
            JArray jArray = (JArray)jObject["result"]["units"];
            for (int i = 0; i < jArray.Count; i++)
            {
                SetUnitsItems((string)jObject["result"]["units"][i]["unitName"]);
            }
            comboBox_units.SelectedIndex = lastUnitsindex;
            comboBox_lesson.SelectedIndex = lastLessonIndex;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (!@isReady)
            {
                MessageBoxEx.Show(this, "课程信息读取错误 !", "Crack Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RestClient restClient;
            RestRequest restRequest;
            IRestResponse restResponse = null;

            //cmd = learn.pos & client = chinamoocs & item = 173230 & last = 1372790 & max = 1372790 & sign = 59e45f6bf032f2d364d43096d9c8fdb3
            string cmd = "learn.pos";
            string client = "chinamoocs";
            string item = itemid;
            string last = duration;
            string max = duration;
            string sign = ToolClass.getSign(cmd + client + item + last + max + meta_Label);
            restClient = new RestClient("http://api.mooc.minghuaetc.com/v1");
            restRequest = new RestRequest(Method.POST);
            restRequest.AddCookie("moocvk", ToolClass.moocvk);
            restRequest.AddCookie("moocsk", ToolClass.moocsk);
            restRequest.AddParameter("cmd", cmd);
            restRequest.AddParameter("client", client);
            restRequest.AddParameter("item", itemid);
            restRequest.AddParameter("last", duration);
            restRequest.AddParameter("max", duration);
            restRequest.AddParameter("meta", meta_Label);
            restRequest.AddParameter("sign", sign);

            restClient.Encoding = Encoding.UTF8;
            restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);

            JObject jObject = JObject.Parse(restResponse.Content);
            if ((int)jObject["code"] > 0)
            {
                MessageBoxEx.Show(this, (string)jObject["message"], "Crack Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lastUnitsindex = comboBox_units.SelectedIndex;
                lastLessonIndex = comboBox_lesson.SelectedIndex;
                comboBox_units.Items.Clear();
                getLessonAsync(); //刷新课程状态
                MessageBoxEx.Show(this, "课程:" + itemid + " - " + (string)jObject["message"], "Crack Succeed !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        delegate void SetUnitsItemsCallback(string item);

        private void SetUnitsItems(string item)
        {
            if (this.comboBox_units.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.comboBox_units.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.comboBox_units.Disposing || this.comboBox_units.IsDisposed)
                        return;
                }
                SetUnitsItemsCallback d = new SetUnitsItemsCallback(SetUnitsItems);
                this.comboBox_units.Invoke(d, new object[] { item });
            }
            else
            {
                this.comboBox_units.Items.Add(item);
                this.comboBox_units.SelectedIndex = 0;
            }
        }

        delegate void SetLessonItemsCallback(string item);

        private void SetLessonItems(string item)
        {
            if (this.comboBox_lesson.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.comboBox_lesson.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.comboBox_lesson.Disposing || this.comboBox_lesson.IsDisposed)
                        return;
                }
                SetLessonItemsCallback d = new SetLessonItemsCallback(SetLessonItems);
                this.comboBox_lesson.Invoke(d, new object[] { item });
            }
            else
            {
                this.comboBox_lesson.Items.Add(item);
                this.comboBox_lesson.SelectedIndex = 0;
            }
        }

        private void comboBox_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_lesson.Items.Clear();
            if (jsonString != null)
            {
                JObject jObject = JObject.Parse(jsonString);
                JArray jArray = (JArray)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"];
                foreach (var obj in jArray)
                {
                    JObject @object = JObject.Parse(obj.ToString());
                    string name = (string)@object["lessonName"] + " - " + (string)@object["lessonNo"];
                    SetLessonItems(name);
                }
            }
        }

        private async void comboBox_lesson_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            if (jsonString != null)
            {
                JObject jObject = JObject.Parse(jsonString);
                string name = (string)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"][comboBox_lesson.SelectedIndex]["items"][0]["itemName"];
                label_lesson_name.Text = "课程名称:" + name;
                itemid = (string)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"][comboBox_lesson.SelectedIndex]["items"][0]["itemId"];
                meta_Label = (string)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"][comboBox_lesson.SelectedIndex]["items"][0]["meta"];
                string itemtype = (string)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"][comboBox_lesson.SelectedIndex]["items"][0]["itemType"];
                string status = "未知";
                switch ((int)jObject["result"]["units"][comboBox_units.SelectedIndex]["lessons"][comboBox_lesson.SelectedIndex]["items"][0]["status"])
                {
                    case 1:
                        status = "正在观看";
                        break;
                    case 2:
                        status = "已完成观看";
                        break;
                    case 0:
                        status = "未观看";
                        break;
                }
                label_lesson_size.Text = itemid;
                label_lesson_status.Text = "课程状态:" + status;

                RestClient restClient;
                RestRequest restRequest;
                IRestResponse restResponse = null;
                restClient = new RestClient("http://ynnubs.minghuaetc.com/study/play.mooc");
                restRequest = new RestRequest(Method.POST);
                restRequest.AddCookie("moocvk", ToolClass.moocvk);
                restRequest.AddCookie("moocsk", ToolClass.moocsk);
                restRequest.AddHeader("Referer", "http://ynnubs.minghuaetc.com/study/unit/" + itemid + ".mooc");
                restRequest.AddParameter("itemId", itemid);
                restRequest.AddParameter("itemType", itemtype);
                restRequest.AddParameter("testPaperId", "");
                restClient.Encoding = Encoding.UTF8;
                restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);
                Regex regex = new Regex("<input type=\"hidden\" id=\"nodeId\" value=\".*[0 - 9]");
                MatchCollection result = regex.Matches(restResponse.Content);
                try
                {
                    string nodeid = result[0].ToString().Replace("<input type=\"hidden\" id=\"nodeId\" value=\"", "");
                    regex = new Regex("meta = {\"duration.*");
                    result = regex.Matches(restResponse.Content);
                    string meta = result[0].ToString().Replace("meta = ", "").Replace("};", "}");
                    JObject @object = JObject.Parse(meta);
                    duration = (string)@object["duration"];
                    string size = (string)@object["width"] + " * " + (string)@object["height"];
                    label_lesson_size.Text = "课程视频分辨率:" + size;
                    isReady = true;
                }
                catch (Exception)
                {
                    isReady = false;
                    label_lesson_status.Text = "课程状态:请先完成之前的学习";
                }        
            }
        }
    }
}
