using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minghuaetc
{
    public partial class Form_Login : Form
    {
        List<string> orgIds = new List<string>();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            getSchool();
        }

        private void getSchool()
        {
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "sys.org");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("index", 1);
            request.AddParameter("authuser", "");
            request.AddParameter("size", 200);
            request.AddParameter("type", 10);
            request.AddParameter("sign", "9081119e45061013400710d32e87a49a");
            client.ExecuteAsync(request, response => {
                string result = response.Content;
                try
                {
                    JObject jObject = JObject.Parse(result);
                    if ((string)jObject["message"] != "命令执行成功")
                    {
                        MessageBox.Show("获取学校平台失败", "运行出错", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    else
                    {
                        JArray jArray = (JArray)jObject["result"]["orgs"];
                        new Thread(() =>
                        {
                            foreach (var i in jArray)
                            {
                                orgIds.Add((string)i["orgId"]);
                                Action<string> action = (data) =>
                                {
                                    this.comboBox_school.Items.Add(data);
                                    this.comboBox_school.SelectedIndex = 0;
                                };

                                Invoke(action, (string)i["orgName"]);
                            }
                        }).Start();
                    }
                }catch (Exception)
                {
                    MessageBoxEx.Show("获取学校平台失败, 请检查您的网络", "运行出错", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Exit();
                }
            });
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var client = new RestClient(Client.url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("cmd", "sys.login.no");
            request.AddParameter("client", "chinamoocs");
            request.AddParameter("orgid", orgIds[comboBox_school.SelectedIndex]);
            request.AddParameter("user", textBox_login_stuID.Text);
            request.AddParameter("password", Client.getPwdEncrypt(textBox_login_password.Text));
            string param_value = "";
            foreach (var param in request.Parameters)
            {
                param_value += param.Value.ToString();
            }
            request.AddParameter("sign", Client.getSign(param_value));
            client.ExecuteAsync(request, response =>
            {
                string result = response.Content;
                try
                {
                    JObject jObject = JObject.Parse(result);
                    int code = (int)jObject["code"];
                    new Thread(() =>
                    {
                        string message = "";
                        bool success = false;
                        if (code > 0)
                        {
                            message = (string)jObject["message"];
                        }
                        else if (code == 0)
                        {
                            Client.stuName = (string)jObject["result"]["user"]["aliasName"];
                            message = "Welcome - " + Client.stuName;
                            success = true;
                            foreach(var cookies in response.Cookies)
                            {
                                if (cookies.Name == "moocsk")
                                {
                                    Client.moocsk = cookies.Value;
                                }else if (cookies.Name == "moocvk"){
                                    Client.moocvk = cookies.Value;
                                }
                            }
                        }
                        Action<string> action = (message_show) =>
                        {
                            MessageBoxEx.Show(this, message_show, "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if (success)
                            {
                                System.Threading.Thread thrT = new System.Threading.Thread(new System.Threading.ThreadStart(MainForm));
                                thrT.Start();
                                while (thrT.ThreadState != System.Threading.ThreadState.Running) ;
                                this.Close();
                            }
                        };
                        Invoke(action, message);
                    }).Start();
                    
                }
                catch (Exception)
                {
                    MessageBoxEx.Show(this, "Logon failure ensures that you are connected to the Internet" , "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            });
        }

        private void MainForm()
        {
            Application.Run(new Main());
        }
    }
}
