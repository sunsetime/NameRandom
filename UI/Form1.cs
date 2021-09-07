using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace UI
{
    public partial class MainForm : Form
    {

        List<string> nameList = new List<string>();
        Thread rd = null;
        string type = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {

            BtnS.Text = "开始";
            progressBar1.Value = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filePath = ofd.FileName;
            tbFilePath.Text = filePath;
            nameList.Clear();
            if (filePath != "")
            {
                Thread.Sleep(1000);
                progressBar1.Value += 100;

                StreamReader sr = new StreamReader(filePath, UnicodeEncoding.GetEncoding("UTF-8"));

                string str = "";

                while ((str = sr.ReadLine()) != null)
                {
                    nameList.Add(str);
                }
            }
            else 
            {
                MessageBox.Show("未选择文件", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnS_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value==100)
            {
            rd = new Thread(new ThreadStart(Random));
            if (BtnS.Text == "开始")
            {
                type = "start";
                BtnS.Text = "停止";
                rd.Start();

            }
            else
            {
                BtnS.Text = "开始";
                type = "stop";
                rd.Abort();
            }
            }
        }

        public void Random()
        {
            while(BtnS.Text!="开始")
                {
                foreach (string name in nameList)
                {
                    if(type=="stop")
                        {
                            break;
                        }
                
                    if (Labe.InvokeRequired)
                    {
                        // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                        Action<string> actionDelegate = (x) => { this.Labe.Text = x.ToString(); };
                        
                        this.Labe.Invoke(actionDelegate, name);
                        Thread.Sleep(50);
                    }
                    
                }
          
            }

        }
    }
}
