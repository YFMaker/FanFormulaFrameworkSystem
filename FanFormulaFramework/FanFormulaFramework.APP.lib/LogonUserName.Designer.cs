﻿
namespace FanFormulaFramework.APP.ControlLibaray
{
    partial class LogonUserName
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
            this.transTextbox1 = new FanFormulaFramework.APP.ControlLibaray.TransRichTextbox();
            this.SuspendLayout();
            // 
            // transTextbox1
            // 
            this.transTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transTextbox1.Font = new System.Drawing.Font("华文行楷", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transTextbox1.ForeColor = System.Drawing.Color.Teal;
            this.transTextbox1.Location = new System.Drawing.Point(49, 12);
            this.transTextbox1.Multiline = false;
            this.transTextbox1.Name = "transTextbox1";
            this.transTextbox1.Size = new System.Drawing.Size(195, 26);
            this.transTextbox1.TabIndex = 0;
            this.transTextbox1.Text = "请输入账户";
            // 
            // LogonUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FanFormulaFramework.APP.ControlLibaray.Properties.Resources.LOGON_UserName;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.transTextbox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Name = "LogonUserName";
            this.Size = new System.Drawing.Size(270, 50);
            this.Click += new System.EventHandler(this.LogonUserName_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private TransRichTextbox transTextbox1;
    }
}
