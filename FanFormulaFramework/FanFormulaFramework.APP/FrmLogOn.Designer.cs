
namespace FanFormulaFramework.APP
{
    partial class FrmLogOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogOn));
            this.logonUserName1 = new FanFormulaFramework.APP.ControlLibaray.LogonUserName();
            this.logonPassWord1 = new FanFormulaFramework.APP.ControlLibaray.LogonPassWord();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_logon = new FanFormulaFramework.APP.ControlLibaray.LogonButton();
            this.btn_close = new FanFormulaFramework.APP.ControlLibaray.LogonButtonNoClick();
            this.SuspendLayout();
            // 
            // logonUserName1
            // 
            this.logonUserName1.BackColor = System.Drawing.Color.Transparent;
            this.logonUserName1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logonUserName1.BackgroundImage")));
            this.logonUserName1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logonUserName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logonUserName1.Location = new System.Drawing.Point(664, 203);
            this.logonUserName1.Name = "logonUserName1";
            this.logonUserName1.Size = new System.Drawing.Size(270, 50);
            this.logonUserName1.TabIndex = 0;
            this.logonUserName1.TextValue = "请输入账户";
            // 
            // logonPassWord1
            // 
            this.logonPassWord1.BackColor = System.Drawing.Color.Transparent;
            this.logonPassWord1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logonPassWord1.BackgroundImage")));
            this.logonPassWord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logonPassWord1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logonPassWord1.Location = new System.Drawing.Point(664, 280);
            this.logonPassWord1.Name = "logonPassWord1";
            this.logonPassWord1.PasswordValue = "";
            this.logonPassWord1.Size = new System.Drawing.Size(270, 50);
            this.logonPassWord1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(686, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "记住账户";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(835, 341);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "记住密码";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // btn_logon
            // 
            this.btn_logon.BackColor = System.Drawing.Color.Transparent;
            this.btn_logon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logon.BackgroundImage")));
            this.btn_logon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logon.Location = new System.Drawing.Point(664, 377);
            this.btn_logon.Name = "btn_logon";
            this.btn_logon.Size = new System.Drawing.Size(270, 50);
            this.btn_logon.TabIndex = 5;
            this.btn_logon.TextValue = "登 录";
            this.btn_logon.ButtonClick += new System.EventHandler(this.btn_logon_ButtonClick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Location = new System.Drawing.Point(664, 434);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(270, 50);
            this.btn_close.TabIndex = 6;
            this.btn_close.TextValue = "取 消";
            this.btn_close.ButtonClick += new System.EventHandler(this.btn_close_ButtonClick);
            // 
            // FrmLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FanFormulaFramework.APP.Properties.Resources.LOGON;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_logon);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.logonPassWord1);
            this.Controls.Add(this.logonUserName1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogOn";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibaray.LogonUserName logonUserName1;
        private ControlLibaray.LogonPassWord logonPassWord1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private ControlLibaray.LogonButton btn_logon;
        private ControlLibaray.LogonButtonNoClick btn_close;
    }
}