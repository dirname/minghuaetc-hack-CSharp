using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minghuaetc
{
    public partial class WaitForm : Form
    {

        private BackgroundWorker backgroundWorker_wait; //ProcessForm 窗体事件(进度条窗体) 
        public WaitForm(BackgroundWorker backgroundWorker_main)
        {
            InitializeComponent();
            this.backgroundWorker_wait = backgroundWorker_main;
            this.backgroundWorker_wait.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_wait_ProgressChanged);
            this.backgroundWorker_wait.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_wait_RunWorkerCompleted);
        }

        void backgroundWorker_wait_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar_wait.Value = this.progressBar_wait.Maximum;
            this.Close();//执行完之后，直接关闭页面
        }

        void backgroundWorker_wait_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar_wait.Value = e.ProgressPercentage;
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
