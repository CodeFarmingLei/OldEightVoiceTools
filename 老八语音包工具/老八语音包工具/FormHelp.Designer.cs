namespace 老八语音包工具
{
    partial class FormHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Controls.Add(this.label1);
            this.groupBoxHelp.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(450, 200);
            this.groupBoxHelp.TabIndex = 7;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "使用说明";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 174);
            this.label1.TabIndex = 4;
            this.label1.Text = "* 点击相关按钮播放音频 (连续点击会有不一样的感觉！)\r\n* 点击停止播放可以... (这个就不用介绍了，你懂的。)\r\n\r\n键盘按键说明：\r\n空格键播放焦点与按" +
    "钮选中的音频。上下左右键切换音频。Tab键切换分类区域。\r\n\r\n更多有趣的功能敬请期待后续的版本更新。。。";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(476, 223);
            this.Controls.Add(this.groupBoxHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 262);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用说明";
            this.groupBoxHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.Label label1;
    }
}