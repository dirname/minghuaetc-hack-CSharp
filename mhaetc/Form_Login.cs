using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mhaetc
{
    public partial class Form_Login : Form
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        /*
         * orgid
         * {"code":"000000","message":"命令执行成功","result":{"count":19,"orgs":[{"apiUrl":"/api","englishName":"The Northern Investment Group Co,Ltd","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/1/l/740bf948b6c940ecb96d0923dd041256.jpg","orgId":1,"orgName":"北方阳光（集团总部）","pinyin":"BEIFANGYANGGUANG（JITUANZONGBU）","shortName":"nig","spocLogo":"http://static.mooc.minghuaetc.com"},{"apiUrl":"/api","englishName":"Canvard Institute,beijing technology and business university","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/4/l/bd287e3cb9ec4ec1974d4d1fd8ec5f41.jpg","orgId":4,"orgName":"北京工商大学嘉华学院","pinyin":"BEIJINGGONGSHANGDAXUEJIAHUAXUEYUAN","shortName":"canvard","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/4/p/02b6444f8eec4cb9acd4b6216b8e8f17.png"},{"apiUrl":"/api","englishName":"Chengdu College of Arts and Sciences","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/24/l/dce2de282b26430cb6bf3d3b33f6e0a5.png","orgId":24,"orgName":"成都文理学院","pinyin":"CHENGDOUWENLIXUEYUAN","shortName":"cdcas","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/24/p/612fdc2eed934c5794d894247c47109d.png"},{"apiUrl":"/api","englishName":"Bo Wen College of Management GUT","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/7/l/a35b171f070245ff8002398c3066fc34.jpg","orgId":7,"orgName":"桂林理工大学博文管理学院","pinyin":"GUILINLIGONGDAXUEBOWENGUANLIXUEYUAN","shortName":"bwgl","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/7/p/bd211818b8fb437dba604b47943ef2f1.png"},{"apiUrl":"/api","englishName":"Harbin Guangsha College","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/14/l/164e08f7bb194e2b88e89c10cb57cd34.jpg","orgId":14,"orgName":"哈尔滨广厦学院","pinyin":"HAERBINGUANGSHAXUEYUAN","shortName":"gsxy","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/14/p/058a398048744f73a6f089134d1df158.png"},{"apiUrl":"/api","englishName":"South China Agricultural University","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/10/l/16414a14a976462eb5cc65dad57f6c95.jpg","orgId":10,"orgName":"华南农业大学珠江学院","pinyin":"HUANANNONGYEDAXUEZHUJIANGXUEYUAN","shortName":"scauzhujiang","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/10/p/2c5c99f9f27348d386c013c493850629.jpg"},{"apiUrl":"/api","englishName":"jiaotongxueyuan","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/21/l/b816a0a3a93248b5a463827193df9972.jpg","orgId":21,"orgName":"交通学院","pinyin":"JIAOTONGXUEYUAN","shortName":"jtxy","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/21/p/47a7d1b8751e4b4490f5fabdbc8a0977.png"},{"apiUrl":"/api","englishName":"Mingda Polytechnic Institue","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/20/l/6699d8f3d46f47c18917617a343da790.jpg","orgId":20,"orgName":"明达职业技术学院","pinyin":"MINGDAZHIYEJISHUXUEYUAN","shortName":"mdut","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/20/p/ec175e66dc3240c9adbfd1d84c522337.png"},{"apiUrl":"/api","englishName":"NANHANG JINCHENG COLLEGE","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/22/l/73c779bac25546e180a36dc4f7b5be4f.jpg","orgId":22,"orgName":"南京航空航天大学金城学院","pinyin":"NANJINGHANGKONGHANGTIANDAXUEJINCHENGXUEYUAN","shortName":"nanhang jincheng college","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/22/p/e9a8d499f1d84883891c9d8d1e871591.png"},{"apiUrl":"/api","englishName":"SHANGHAI LIDA UNIVERSITY","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/9/l/79e32e7b03d54488bf31e7da6795de8a.jpg","orgId":9,"orgName":"上海立达学院","pinyin":"SHANGHAILIDAXUEYUAN","shortName":"lidapoly","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/9/p/772893a28bd24ba39ee297a82d10e0ba.png"},{"apiUrl":"/api","englishName":"Kede College of Capital Normal University","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/3/l/dac7fcb8a4e6472db0f264a825bdcf15.jpg","orgId":3,"orgName":"首都师范大学科德学院","pinyin":"SHOUDOUSHIFANDAXUEKEDEXUEYUAN","shortName":"kdcnu","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/3/p/207fe0bc05084e25878034af1e3b2988.png"},{"apiUrl":"/api","englishName":"Wuhan University of Engineering Science","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/5/l/28004adedea94e6584abe5254db4e10c.jpg","orgId":5,"orgName":"武汉工程科技学院","pinyin":"WUHANGONGCHENGKEJIXUEYUAN","shortName":"jccug","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/5/p/a01a7b32cda5490abe9ffaa0100de0c7.png"},{"apiUrl":"/api","englishName":"XI'AN UNIVERSITY OF TECHNOLOGICAL INFORMATION","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/23/l/fd33db212565478994e26c57878178b2.png","orgId":23,"orgName":"西安工业大学北方信息学院","pinyin":"XIANGONGYEDAXUEBEIFANGXINXIXUEYUAN","shortName":"bxait","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/23/p/19cb8c4967dd496a93fb4efa24bf2aa9.png"},{"apiUrl":"/api","englishName":"Yanching Institute of Technology","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/2/l/b4bf5de92f3548afb637af0a68400ccd.jpg","orgId":2,"orgName":"燕京理工学院","pinyin":"YANJINGLIGONGXUEYUAN","shortName":"yit","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/2/p/2e9856c5f3204d398bac1cc9a651a9c7.png"},{"apiUrl":"/api","englishName":"Yunnan Urban Construction Vocational College","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/8/l/17e0424a50ca47a2aea98a606dfdc1d5.jpg","orgId":8,"orgName":"云南城市建设职业学院","pinyin":"YUNNANCHENGSHIJIANSHEZHIYEXUEYUAN","shortName":"yncjxy","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/8/p/5d21320c1e6649af85a14a840e8f5d85.png"},{"apiUrl":"/api","englishName":"Yunnan Normal University Business School","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/6/l/2307c35d6171412d876e504526b7d811.jpg","orgId":6,"orgName":"云南师范大学商学院","pinyin":"YUNNANSHIFANDAXUESHANGXUEYUAN","shortName":"ynnubs","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/6/p/0754395ffa714e398c2261842e5f6d42.png"},{"apiUrl":"/api","englishName":"China University Of Mining And Technology Yinchuan College","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/11/l/c3b22aa748b04bff97e2e7fecabf2f8d.jpg","orgId":11,"orgName":"中国矿业大学银川学院","pinyin":"ZHONGGUOKUANGYEDAXUEYINCHUANXUEYUAN","shortName":"cumtyc","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/11/p/006ceda307a9494c9687aefb9f4c57ec.png"},{"apiUrl":"/api","englishName":"Swan college,Central South University of Forestry and Technology","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/15/l/8210b6b9564d4788931f9b74353ab52d.png","orgId":15,"orgName":"中南林业科技大学涉外学院","pinyin":"ZHONGNANLINYEKEJIDAXUESHEWAIXUEYUAN","shortName":"zswxy","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/15/p/700418c53b1d40bda9fc5e90105c0dfd.png"},{"apiUrl":"/api","englishName":"City college of science and technology, Chongqing University","logoUrl":"http://static.mooc.minghuaetc.com/repositry/schimg/13/l/c51d73e12ca44137be151eb1c79757db.jpg","orgId":13,"orgName":"重庆大学城市科技学院","pinyin":"ZHONGQINGDAXUECHENGSHIKEJIXUEYUAN","shortName":"cqucc","spocLogo":"http://static.mooc.minghuaetc.com/repositry/schimg/13/p/54cd175c1f8f457da3eb07872ad8d1df.png"}]}
         */

        public Form_Login()
        {
            InitializeComponent();
        }

        private async void button_login_ClickAsync(object sender, EventArgs e)
        {
            string cmd = "sys.login.no";
            string client = "chinamoocs";
            string orgid = "orgid"; //修改为自己学校的代码,参考orgid，代码第23行
            string user = textBox_study_id.Text;
            string password = getPwdEncrypt(textBox_study_pwd.Text);
            string sign = ToolClass.getSign(cmd + client + orgid + user + password);
            RestClient restClient;
            RestRequest restRequest;
            IRestResponse restResponse = null;
            restClient = new RestClient("http://api.mooc.minghuaetc.com/v1");
            restRequest = new RestRequest(Method.POST);
            restRequest.AddCookie("moocvk", ToolClass.moocvk);
            restRequest.AddParameter("cmd", cmd);
            restRequest.AddParameter("client", client);
            restRequest.AddParameter("orgid", orgid);
            restRequest.AddParameter("user", user);
            restRequest.AddParameter("password", password);
            restRequest.AddParameter("sign", sign);
            //restRequest.AddParameter("param", CryptClass.AES.Encrypt(jObject.ToString(), CryptClass.AES.key, CryptClass.AES.iv, 1, 2));
            restClient.Encoding = Encoding.UTF8;
            restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);
            JObject jObject = JObject.Parse(restResponse.Content);
            if ((int)jObject["code"] > 0)
            {
                MessageBoxEx.Show(this, (string)jObject["message"],"登陆失败", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                ToolClass.username = (string)jObject["result"]["user"]["aliasName"];
                ToolClass.avatarUrl = (string)jObject["result"]["user"]["avatarUrl"];
                ToolClass.userid = (string)jObject["result"]["user"]["userId"];
                MessageBoxEx.Show(this, ToolClass.username + " - " + (string)jObject["message"],"登录成功",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                foreach(var cookies in restResponse.Cookies)
                {
                    if (cookies.Name == "moocsk")
                    {
                        ToolClass.moocsk = cookies.Value;
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private string getPwdEncrypt(string passwrod)
        {
            var des = new TripleDESCryptoServiceProvider();
            des.Mode = CipherMode.ECB;
            des.Key = Convert.FromBase64String("DrZPGgL9WHkZrVQ0DT2bASoZE0Z8oc4s");
            var desEncrypt = des.CreateEncryptor();
            byte[] buffer = Encoding.UTF8.GetBytes(passwrod);
            return Convert.ToBase64String(desEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        }

        private async void Form_Login_LoadAsync(object sender, EventArgs e)
        {
            RestClient restClient;
            RestRequest restRequest;
            IRestResponse restResponse = null;
            restClient = new RestClient("http://api.mooc.minghuaetc.com/v1");
            restRequest = new RestRequest(Method.POST);
            restClient.Encoding = Encoding.UTF8;
            restResponse = await restClient.ExecuteTaskAsync(restRequest, cancellationTokenSource.Token);
            foreach(var cookie in restResponse.Cookies)
            {
                if (cookie.Name == "moocvk")
                {
                    ToolClass.moocvk = cookie.Value;
                }
            }
        }
    }
}
