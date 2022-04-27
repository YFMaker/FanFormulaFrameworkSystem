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
    public partial class LogonButtonNoClick : UserControl
    {
        public LogonButtonNoClick()
        {
            InitializeComponent();
        }

        [Description("编辑内容"), Category("自定义属性")]
        public string TextValue
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.UserControl1_Click(sender, e);
        }

        public event EventHandler ButtonClick;
        private void UserControl1_Click(object sender, EventArgs e)  //该事件是寄托于控件本身的 点击事件 当控件被点击的时候发生这个事件
        {
            if (ButtonClick != null)                                      //当用户打开ButtonClick事件 的时候 ButtonClick 就不为空
            {
                ButtonClick(sender, e);                         //当用户点击该控件 时 执行 在ButtonClick 函数里面的代码
            }
        }
    }
}
