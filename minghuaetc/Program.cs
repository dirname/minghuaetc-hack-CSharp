using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minghuaetc
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
        private const string BouncyCastleCryptoName = "RestSharp";
        private const string NewtonsoftJsonName = "Newtonsoft.Json";
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith(BouncyCastleCryptoName, StringComparison.InvariantCultureIgnoreCase))
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("minghuaetc.RestSharp.dll"))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }
            else
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("minghuaetc.Newtonsoft.Json.dll"))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }
        }
    }
}
