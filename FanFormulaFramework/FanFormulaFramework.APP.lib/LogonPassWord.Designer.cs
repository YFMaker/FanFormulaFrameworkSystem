
namespace FanFormulaFramework.APP.ControlLibaray
{
    partial class LogonPassWord
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.transTextbox1 = new FanFormulaFramework.APP.ControlLibaray.TransTextbox();
            this.SuspendLayout();
            // 
            // transTextbox1
            // 
            this.transTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transTextbox1.Font = new System.Drawing.Font("华文行楷", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transTextbox1.Location = new System.Drawing.Point(53, 13);
            this.transTextbox1.Name = "transTextbox1";
            this.transTextbox1.PasswordChar = '*';
            this.transTextbox1.Size = new System.Drawing.Size(182, 23);
            this.transTextbox1.TabIndex = 0;
            // 
            // LogonPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FanFormulaFramework.APP.ControlLibaray.Properties.Resources.LOGON_PassWord;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.transTextbox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Name = "LogonPassWord";
            this.Size = new System.Drawing.Size(270, 50);
            this.Click += new System.EventHandler(this.LogonPassWord_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransTextbox transTextbox1;
    }
}
