
namespace YFMakeModels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tB_sqlnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cob_SqlType = new System.Windows.Forms.ComboBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_sqlnet
            // 
            this.tB_sqlnet.Location = new System.Drawing.Point(298, 56);
            this.tB_sqlnet.Name = "tB_sqlnet";
            this.tB_sqlnet.Size = new System.Drawing.Size(315, 23);
            this.tB_sqlnet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器连接字符串：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库类型：";
            // 
            // cob_SqlType
            // 
            this.cob_SqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_SqlType.FormattingEnabled = true;
            this.cob_SqlType.Location = new System.Drawing.Point(298, 90);
            this.cob_SqlType.Name = "cob_SqlType";
            this.cob_SqlType.Size = new System.Drawing.Size(153, 25);
            this.cob_SqlType.TabIndex = 3;
            this.cob_SqlType.TextChanged += new System.EventHandler(this.cob_SqlType_TextChanged);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.ForeColor = System.Drawing.Color.Red;
            this.lb_message.Location = new System.Drawing.Point(233, 211);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(0, 17);
            this.lb_message.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 255);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.cob_SqlType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_sqlnet);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "自动化实体创建-连接数据库";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_sqlnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob_SqlType;
        private System.Windows.Forms.Label lb_message;
    }
}

