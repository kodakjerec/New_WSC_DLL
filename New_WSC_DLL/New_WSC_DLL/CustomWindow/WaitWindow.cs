using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace New_WSC_DLL
{
    public partial class WaitWindow : Form
    {
        public WaitWindow()
        {
            InitializeComponent();
        }

        public void SetMessage(string TitleText)
        {
            label1.Text = TitleText;
        }
    }
}
