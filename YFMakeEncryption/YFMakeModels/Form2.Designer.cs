
namespace YFMakeModels
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tV_Table = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_TableName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Directory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Make = new System.Windows.Forms.Button();
            this.cBModel = new System.Windows.Forms.CheckBox();
            this.cBTable = new System.Windows.Forms.CheckBox();
            this.cBApi = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proBar_Spanned = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lb_StartName = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tB_CreateUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tV_Table
            // 
            this.tV_Table.Location = new System.Drawing.Point(12, 12);
            this.tV_Table.Name = "tV_Table";
            this.tV_Table.Size = new System.Drawing.Size(202, 426);
            this.tV_Table.TabIndex = 0;
            this.tV_Table.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_Table_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_TableName
            // 
            this.lb_TableName.AutoSize = true;
            this.lb_TableName.Location = new System.Drawing.Point(314, 12);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(0, 17);
            this.lb_TableName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "所选表为：";
            // 
            // tB_Directory
            // 
            this.tB_Directory.Location = new System.Drawing.Point(314, 50);
            this.tB_Directory.Name = "tB_Directory";
            this.tB_Directory.ReadOnly = true;
            this.tB_Directory.Size = new System.Drawing.Size(372, 23);
            this.tB_Directory.TabIndex = 4;
            this.tB_Directory.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "生成目录：";
            // 
            // bt_Make
            // 
            this.bt_Make.Location = new System.Drawing.Point(702, 142);
            this.bt_Make.Name = "bt_Make";
            this.bt_Make.Size = new System.Drawing.Size(75, 23);
            this.bt_Make.TabIndex = 5;
            this.bt_Make.Text = "生成文件";
            this.bt_Make.UseVisualStyleBackColor = true;
            this.bt_Make.Click += new System.EventHandler(this.bt_Make_Click);
            // 
            // cBModel
            // 
            this.cBModel.AutoSize = true;
            this.cBModel.Location = new System.Drawing.Point(32, 31);
            this.cBModel.Name = "cBModel";
            this.cBModel.Size = new System.Drawing.Size(63, 21);
            this.cBModel.TabIndex = 6;
            this.cBModel.Text = "实体类";
            this.cBModel.UseVisualStyleBackColor = true;
            // 
            // cBTable
            // 
            this.cBTable.AutoSize = true;
            this.cBTable.Location = new System.Drawing.Point(139, 31);
            this.cBTable.Name = "cBTable";
            this.cBTable.Size = new System.Drawing.Size(63, 21);
            this.cBTable.TabIndex = 6;
            this.cBTable.Text = "表结构";
            this.cBTable.UseVisualStyleBackColor = true;
            // 
            // cBApi
            // 
            this.cBApi.AutoSize = true;
            this.cBApi.Location = new System.Drawing.Point(248, 31);
            this.cBApi.Name = "cBApi";
            this.cBApi.Size = new System.Drawing.Size(63, 21);
            this.cBApi.TabIndex = 6;
            this.cBApi.Text = "接口类";
            this.cBApi.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(32, 115);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 21);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(139, 115);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 21);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "checkBox1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(248, 115);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 21);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "checkBox1";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.cBModel);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.cBTable);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.cBApi);
            this.groupBox1.Location = new System.Drawing.Point(231, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "未完待续：";
            // 
            // proBar_Spanned
            // 
            this.proBar_Spanned.Location = new System.Drawing.Point(220, 367);
            this.proBar_Spanned.Name = "proBar_Spanned";
            this.proBar_Spanned.Size = new System.Drawing.Size(568, 23);
            this.proBar_Spanned.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "生成进度：";
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.ForeColor = System.Drawing.Color.Red;
            this.lb_Message.Location = new System.Drawing.Point(220, 412);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 17);
            this.lb_Message.TabIndex = 10;
            // 
            // lb_StartName
            // 
            this.lb_StartName.AutoSize = true;
            this.lb_StartName.Location = new System.Drawing.Point(283, 337);
            this.lb_StartName.Name = "lb_StartName";
            this.lb_StartName.Size = new System.Drawing.Size(0, 17);
            this.lb_StartName.TabIndex = 11;
            // 
            // StartTime
            // 
            this.StartTime.Tick += new System.EventHandler(this.StartTime_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "生成人：";
            // 
            // tB_CreateUser
            // 
            this.tB_CreateUser.Location = new System.Drawing.Point(314, 94);
            this.tB_CreateUser.Name = "tB_CreateUser";
            this.tB_CreateUser.Size = new System.Drawing.Size(119, 23);
            this.tB_CreateUser.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tB_CreateUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_StartName);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proBar_Spanned);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Make);
            this.Controls.Add(this.tB_Directory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tV_Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tV_Table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_TableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Directory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Make;
        private System.Windows.Forms.CheckBox cBModel;
        private System.Windows.Forms.CheckBox cBTable;
        private System.Windows.Forms.CheckBox cBApi;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar proBar_Spanned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.Label lb_StartName;
        private System.Windows.Forms.Timer StartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_CreateUser;
    }
}