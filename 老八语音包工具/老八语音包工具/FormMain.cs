using System;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace 老八语音包工具
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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

        SoundPlayer play = new SoundPlayer();

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            play.Stop();    //初始化加载默认停止播放
        }

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
            if (toolStripButtonTop.Text == "窗口置顶")
            {
                this.TopMost = true;
                toolStripButtonTop.Image = ResourceApp.取消置顶;
                toolStripButtonTop.Text = "取消窗口置顶";
            }
            else if (toolStripButtonTop.Text == "取消窗口置顶")
            {
                this.TopMost = false;
                toolStripButtonTop.Image = ResourceApp.置顶;
                toolStripButtonTop.Text = "窗口置顶";
            }
        }

        
    }
}
