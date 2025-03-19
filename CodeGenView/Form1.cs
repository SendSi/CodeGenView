using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CodeGenView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetProgramDirectory()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directory = new DirectoryInfo(baseDirectory);
            while (directory.Name == "Debug" || directory.Name == "Release")
            {
                directory = directory.Parent;
            }
            while (directory.Name == "bin")
            {
                directory = directory.Parent;
            }
            string projectRootDirectory = directory.FullName;
            return projectRootDirectory;
        }

        private void btnGenView_Click(object sender, EventArgs e)
        {
            GenTxt(inputViewTxt.Text, "codeView.txt");
        }

        void GenTxt(string input, string tmpName)
        {
            var proPath = GetProgramDirectory();
            string filePath = Path.Combine(proPath, tmpName);
            if (File.Exists(filePath))
            {
                string uiViewStr = File.ReadAllText(filePath);
                var maxIndex = GetMaxNumParam(uiViewStr); //匹配 得到  含{0} {1} {2} ... 最大的数值 是多少
                var inputTxts = input.Split(';').ToList();

                while (inputTxts.Count <= maxIndex)
                {
                    inputTxts.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); // 使用空字符串补全
                }
                var str = string.Format(uiViewStr, inputTxts.ToArray());
                genTargetTxt.Text = str;
            }
        }


        int GetMaxNumParam(string strContent)
        {
            // 匹配形如 {x} 的占位符，x 是数字
            Regex placeholderRegex = new Regex(@"\{(\d+)\}");
            var matches = placeholderRegex.Matches(strContent);
            int maxPlaceholder = -1;
            foreach (Match match in matches)
            {
                if (int.TryParse(match.Groups[1].Value, out int value))
                {
                    if (value > maxPlaceholder)
                    {
                        maxPlaceholder = value;
                    }
                }
            }
            // 输出结果
            Console.WriteLine($"最大占位符中的数值是: {maxPlaceholder}");
            return maxPlaceholder;
        }

        private void btnGenViewDesktop_Click(object sender, EventArgs e)
        {  //把 字符串 生成在 桌面上  **.lua文件 
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var inputTxts = inputViewTxt.Text.Split(';');
            string fileName = inputTxts[inputTxts.Length - 1];
            string filePath = Path.Combine(desktopPath, $"{fileName}.lua");
            btnGenView_Click(null, null);
            File.WriteAllText(filePath, genTargetTxt.Text, Encoding.UTF8);//使用UTF-8编码保存文件
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globalTip.AutoPopDelay = 25000;
            globalTip.InitialDelay = 100;
            globalTip.ReshowDelay = 0;
            globalTip.ShowAlways = true;
            globalTip.SetToolTip(this.inputViewTxt, "匹配codeView.txt文件_查看占用的{0}{1}{2}...使用分号;隔开多个参数");
            globalTip.SetToolTip(this.inputMgrTxt, "匹配codeMgr.txt文件_查看占用的{0}{1}{2}...使用分号;隔开多个参数");
        }

        private void btnGenMgrDesktop_Click(object sender, EventArgs e)
        {
            //把 字符串 生成在 桌面上  **.lua文件 
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var inputTxts = inputMgrTxt.Text.Split(';');
            string fileName = inputTxts[0];
            string filePath = Path.Combine(desktopPath, $"{fileName}.lua");
            btnGenMgr_Click(null, null);
            File.WriteAllText(filePath, genTargetTxt.Text, Encoding.UTF8);//使用UTF-8编码保存文件
        }

        private void btnGenMgr_Click(object sender, EventArgs e)
        {
            GenTxt(inputMgrTxt.Text, "codeMgr.txt");
        }

        private void btnGenAllDesktop_Click(object sender, EventArgs e)
        {
            btnGenMgrDesktop_Click(null, null);
            btnGenViewDesktop_Click(null, null);
        }
    }
}