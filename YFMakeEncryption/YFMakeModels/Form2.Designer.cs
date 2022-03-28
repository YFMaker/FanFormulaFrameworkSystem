
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tV_Table = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_TableName = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(615, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_TableName
            // 
            this.lb_TableName.AutoSize = true;
            this.lb_TableName.Location = new System.Drawing.Point(234, 12);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(43, 17);
            this.lb_TableName.TabIndex = 2;
            this.lb_TableName.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tV_Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tV_Table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_TableName;
    }
}