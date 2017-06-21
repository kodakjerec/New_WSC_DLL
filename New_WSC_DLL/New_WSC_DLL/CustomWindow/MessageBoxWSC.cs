using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace New_WSC_DLL
{
    public partial class MessageBoxWSC : Form
    {
        private int TimeDE = 5;
        public MessageBoxWSC()
        {
            InitializeComponent();
        }

        #region FormControl
        #region 基本功能
        private void MessageBoxWSC_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Escape)
                this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        void SetDefault()
        {
            TimeDE = 5;
            labelTime.Text = TimeDE.ToString();
            timer1.Start();
        }
        #endregion

        #region Show(內文)
        public void Show(string Context)
        {
            SetDefault();
            richTextBox1.Text = Context;
            Show();
        }
        #endregion
        #region Show(內文,標題)
        public void Show(string Context, string Title)
        {
            SetDefault();
            this.Text = Title;
            richTextBox1.Text = Context;
            Show();
        }
        #endregion
        #region Show(內文,標題,按鈕)
        public void Show(string Context, string Title,MessageBoxButtons MBB)
        {
            SetDefault();
            this.Text = Title;
            richTextBox1.Text = Context;
            switch (MBB)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                case MessageBoxButtons.OK:
                case MessageBoxButtons.OKCancel:
                case MessageBoxButtons.RetryCancel:
                case MessageBoxButtons.YesNo:
                case MessageBoxButtons.YesNoCancel: break;
            }

            ShowDialog();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            return;
            TimeDE -= 1;
            labelTime.Text = TimeDE.ToString();
            if (TimeDE <= 0)
            {
                buttonOK.PerformClick();
                timer1.Stop();
            }
        }

        #endregion
    }
}
