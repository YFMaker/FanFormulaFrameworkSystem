
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
            this.logonPictureBox1 = new FanFormulaFramework.APP.ControlLibaray.LogonPictureBox();
            this.SuspendLayout();
            // 
            // logonPictureBox1
            // 
            this.logonPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logonPictureBox1.BackgroundImage")));
            this.logonPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logonPictureBox1.Location = new System.Drawing.Point(736, 100);
            this.logonPictureBox1.Name = "logonPictureBox1";
            this.logonPictureBox1.Size = new System.Drawing.Size(120, 125);
            this.logonPictureBox1.TabIndex = 0;
            this.logonPictureBox1.UserPhotoSet = ((System.Drawing.Image)(resources.GetObject("logonPictureBox1.UserPhotoSet")));
            // 
            // FrmLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FanFormulaFramework.APP.Properties.Resources.LOGON;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.Controls.Add(this.logonPictureBox1);
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

        }

        #endregion

        private ControlLibaray.LogonPictureBox logonPictureBox1;
    }
}