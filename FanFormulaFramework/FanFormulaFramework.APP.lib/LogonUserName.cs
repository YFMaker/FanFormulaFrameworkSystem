﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanFormulaFramework.APP.ControlLibaray
{
    public partial class LogonUserName : UserControl
    {
        public LogonUserName()
        {
            InitializeComponent();
            this.transTextbox1.GotFocus += TransTextbox1_GotFocus;
        }

        private void TransTextbox1_GotFocus(object sender, EventArgs e)
        {
            if (transTextbox1.Text == "请输入账户")
            {
                transTextbox1.SelectAll();
            }
        }

        private void LogonUserName_Click(object sender, EventArgs e)
        {
            this.transTextbox1.Focus();
        }

        [Description("编辑内容"), Category("自定义属性")]
        public string TextValue
        {
            get
            {
                return transTextbox1.Text;
            }
            set
            {
                transTextbox1.Text = value;
            }
        }
    }
}
