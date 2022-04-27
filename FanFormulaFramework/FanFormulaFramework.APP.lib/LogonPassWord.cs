using System;
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
    public partial class LogonPassWord : UserControl
    {
        public LogonPassWord()
        {
            InitializeComponent();
        }


        [Description("编辑内容"), Category("自定义属性")]
        public string PasswordValue
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

        private void LogonPassWord_Click(object sender, EventArgs e)
        {
            this.transTextbox1.Focus();
        }
    }
}
