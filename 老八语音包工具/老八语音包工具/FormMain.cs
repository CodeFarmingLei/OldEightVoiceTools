using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Reflection;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace 老八语音包工具
{
    public partial class FormMain : Form
    {
        SoundPlayer play = new SoundPlayer();   //引用播放功能

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.axWindowsMediaPlayerMain.URL = ;
            //this.axWindowsMediaPlayerMain.Ctlcontrols.play();
        }

        #region 播放音频方法

        /// <summary>
        /// 播放音频方法
        /// </summary>
        public void Speech()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech = new SpeechSynthesizer();
            speech.Rate = int.Parse("0");   //设置语速  介于-10于10之间
            speech.SpeakAsync("");
        }

        #endregion

        #region RadioButton按钮点击播放音频事件

        #region 老八厕所战争系列语音

        private void RadioButtonCheShuo_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.厕所);
            play.Play();
        }
        private void RadioButtonCough_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.连续咳嗽);
            play.Play();
        }

        private void RadioButtonTo_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.给);
            play.Play();
        }

        private void RadioButtonToiletOneVoice1_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.老八厕所大战语录);
            play.Play();
        }

        private void RadioButtonToiletOneVoice2_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给_干了1);
            play.Play();
        }

        private void RadioButtonToiletOneVoice3_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕原声1);
            play.Play();
        }

        private void RadioButtonToiletOneVoice4_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给1);
            play.Play();
        }

        private void RadioButtonToiletOneVoice5_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.干了1);
            play.Play();
        }

        private void RadioButtonToiletOneVoice6_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕1);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice1_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.老八厕所二战语录);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice2_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给_干了兄弟们2);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice3_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕原声2);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice4_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给2);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice5_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.干了兄弟们2);
            play.Play();
        }

        private void RadioButtonToiletTwoVoice6_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕2);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice1_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.老八厕所三战语录);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice2_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给_干了兄弟们3);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice3_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕原声3);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice4_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.奥力给3);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice5_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.干了兄弟们3);
            play.Play();
        }

        private void RadioButtonToiletThreeVoice6_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.呕3);
            play.Play();
        }

        #endregion

        #region 老八秘制小汉堡系列语音

        private void RadioButtonStinkyTofu_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.臭豆腐);
            play.Play();
        }

        private void RadioButtonPickledTofu_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.腐乳);
            play.Play();
        }

        private void RadioButtonCucumber_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.黄瓜丝儿);
            play.Play();
        }

        private void RadioButtonMeizhizhi_Click(object sender, EventArgs e)
        {
            play = new SoundPlayer(ResourceApp.美汁汁儿);
            play.Play();
        }


        #endregion

        #endregion

        #region 播放控制相关事件

        /// <summary>
        /// 停止播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            play.Stop();
        }


        #endregion

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 窗口置顶事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonTop_Click(object sender, EventArgs e)
        {
            if (toolStripButtonMainTop.Text == "窗口置顶")
            {
                this.TopMost = true;
                toolStripButtonMainTop.Image = ResourceApp.取消置顶;
                toolStripButtonMainTop.Text = "取消窗口置顶";
            }
            else if (toolStripButtonMainTop.Text == "取消窗口置顶")
            {
                this.TopMost = false;
                toolStripButtonMainTop.Image = ResourceApp.置顶;
                toolStripButtonMainTop.Text = "窗口置顶";
            }
        }

        private void ToolStripButtonHelp_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.Show();
        }

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.Show();
        }

        private void ToolStripButtonUpdateLog_Click(object sender, EventArgs e)
        {
            FormUpdateLog FormUpdateLog = new FormUpdateLog();
            FormUpdateLog.Show();
        }

        private void ToolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #region 复制文件方法

        /// <summary>
        /// 复制文件到指定路径
        /// </summary>
        /// <param name="srcPath">原目录</param>
        /// <param name="aimPath">目标目录</param>
        public void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                //如果不存在目标路径则创建
                if (!System.IO.Directory.Exists(aimPath))
                {
                    System.IO.Directory.CreateDirectory(aimPath);
                }
                //令目标路径为aimPath\srcPath
                string srcdir = System.IO.Path.Combine(aimPath, System.IO.Path.GetFileName(srcPath));
                //如果源路径是文件夹，则令目标目录为aimPath\srcPath\
                if (Directory.Exists(srcPath))
                    srcdir += Path.DirectorySeparatorChar;
                // 如果目标路径不存在,则创建目标路径
                if (!System.IO.Directory.Exists(srcdir))
                {
                    System.IO.Directory.CreateDirectory(srcdir);
                }
                //获取源文件下所有的文件
                String[] files = Directory.GetFileSystemEntries(srcPath);
                foreach (string element in files)
                {
                    //如果是文件夹，循环
                    if (Directory.Exists(element))
                        CopyDir(element, srcdir);
                    else
                        System.IO.File.Copy(element, srcdir + Path.GetFileName(element), true);
                }
            }
            catch
            {
                MessageBox.Show("复制文件失败，可能为以下原因：\n1.源目录及文件或目标目录及文件不存在。\n2.路径名错误\n\n请重试...", "复制失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 复制文件方法2
        /// </summary>
        /// <param name="i"></param>
        /// <param name="o"></param>
        public static void CopyStream(Stream i, Stream o)
        {
            byte[] b = new byte[32768];
            while (true)
            {
                int r = i.Read(b, 0, b.Length);
                if (r <= 0)
                    return;
                o.Write(b, 0, r);
            }
        }

        #endregion

        #region 播放视频相关方法

        private void ButtonVideo1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"OLGVideo\老八厕所一战原版视频.mp4"))
            {
                Process.Start(@"OLGVideo\老八厕所一战原版视频.mp4");
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n 请重新下载此程序的完整程序包", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonVideo2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"OLGVideo\老八厕所二战原版视频.mp4"))
            {
                Process.Start(@"OLGVideo\老八厕所二战原版视频.mp4");
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n 请重新下载此程序的完整程序包", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonVideo3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"OLGVideo\老八厕所三战原版视频.mp4"))
            {
                Process.Start(@"OLGVideo\老八厕所三战原版视频.mp4");
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n 请重新下载此程序的完整程序包", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonVideo4_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"OLGVideo\老八鞭炮崩睾丸原版视频.mp4"))
            {
                Process.Start(@"OLGVideo\老八鞭炮崩睾丸原版视频.mp4");
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n 请重新下载此程序的完整程序包", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 打开视频文件所在目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFilePathShow_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"OLGVideo\"))
            {
                Process.Start(@"OLGVideo\");
            }
            else
            {
                MessageBox.Show("本次打开异常，可能原因如下：\n1.要打开的路径或者文件不存在\n2.可能您修改了文件或文件夹的名称 \n\n 请重新下载此程序的完整程序包", "打开异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


    }
}
