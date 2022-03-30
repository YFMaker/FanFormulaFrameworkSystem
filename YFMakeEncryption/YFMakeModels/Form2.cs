using FanFormulaFramework.DBUtile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YFMakeModels
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DataBaseService date;
        public Form2(DataBaseService _date)
        {
            date = _date;
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "实体创建";
            tB_Directory.Text = AppDomain.CurrentDomain.BaseDirectory.ToString();
            Loader();
        }

        private void Loader()
        {
            string sql = "show databases;";
            DataTable dataTable = date.SelectSQL(sql);
           
            foreach (DataRow item in dataTable.Rows)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item["Database"].ToString();
                tn.Tag = item["Database"].ToString();
                Loading(tn, item["Database"].ToString());
                tV_Table.Nodes.Add(tn);
            }
        }

        private void Loading(TreeNode tn,string name)
        {
            string sql = "SELECT TABLE_NAME FROM information_schema.`TABLES` WHERE TABLE_SCHEMA = '"+ name + "';";
            DataTable dataTable=date.SelectSQL(sql);
            foreach (DataRow item in dataTable.Rows)
            {
                TreeNode tnn = new TreeNode();
                tnn.Text = item["TABLE_NAME"].ToString();
                tnn.Tag = item["TABLE_NAME"].ToString();
                tn.Nodes.Add(tnn);
            }
        }

        private string LibraryName = string.Empty;

        private void tV_Table_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lb_TableName.Text = tV_Table.SelectedNode.Text;
            if (tV_Table.SelectedNode.Parent != null)
            {
                LibraryName = tV_Table.SelectedNode.Parent.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
               string savePath = dialog.SelectedPath;
                tB_Directory.Text = savePath;
            }
        }

        private void bt_Make_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            tV_Table.Enabled = false;
            ///判断是否存在选中目录
            if (Directory.Exists(tB_Directory.Text))
            {
                ///确认选中非一级节点（即选中为库非表）
                if (tV_Table.SelectedNode.Parent != null)
                {
                    SpannedFile();

                }
                else
                {
                    lb_Message.Text = "选中的不是表。";
                    button1.Enabled = true;
                    tV_Table.Enabled = true;
                }
            }
            else
            {
                lb_Message.Text = "生成目录不存在。";
                button1.Enabled = true;
                tV_Table.Enabled = true;
            }
        }

        /// <summary>
        /// 生成文件
        /// </summary>
        private void SpannedFile()
        {
            string selectTableSql = string.Format("select COLUMN_NAME,COLUMN_TYPE,column_comment from INFORMATION_SCHEMA.Columns where table_name='{0}' and table_schema='{1}'", lb_TableName.Text, LibraryName);
            DataTable selectdataTable=date.SelectSQL(selectTableSql);
            if (selectdataTable != null)
            {
                if (cBModel.Checked)
                {
                    SpannedModel(selectdataTable);
                }
                if (cBTable.Checked)
                {
                    SpannedTable(selectdataTable);
                }
                if (cBApi.Checked)
                {
                    SpannedApi(selectdataTable);
                }

                //TODO 未完待续
                StartTime.Enabled = false;
                button1.Enabled = true;
                tV_Table.Enabled = true;
            }
            else
            {
                lb_Message.Text = "该表无字段";
                button1.Enabled = true;
                tV_Table.Enabled = true;
            }
        }


        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="dataTable"></param>
        private void SpannedModel(DataTable dataTable)
        {
            Starting("生成实体类中... ...", dataTable.Rows.Count);

            StringBuilder TemplateString = new StringBuilder();
            if (!Directory.Exists(tB_Directory.Text + @"\\Model\\"))
            {
                Directory.CreateDirectory(tB_Directory.Text + @"\\Model\\");
            }
            StreamWriter SpannedFile = new StreamWriter(tB_Directory.Text+@"\\Model\\" + lb_TableName.Text + ".cs", true);
            StreamReader TemplateFile = new StreamReader(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Model.txt", System.Text.Encoding.GetEncoding("GB2312"));
            string templatestring = TemplateFile.ReadToEnd();
            //templatestring=templatestring.Replace("{0}", lb_TableName.Text + "Entity");
            TemplateString.Append(templatestring);
            TemplateString.Replace("createuser", "YF");
            TemplateString.Replace("datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            TemplateString.Replace("{0}", lb_TableName.Text + "Entity");
            StringBuilder valuestring = new StringBuilder();
            StringBuilder bindingstring = new StringBuilder();
            foreach (DataRow item in dataTable.Rows)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat(@"        private {0} {1};" + Environment.NewLine,
                    Util.Typename(item["COLUMN_TYPE"].ToString()), "_" + item["COLUMN_NAME"].ToString());
                stringBuilder.Append(@"        /// <summary>" + Environment.NewLine);
                stringBuilder.AppendFormat(@"        /// {0}" + Environment.NewLine,
                    string.IsNullOrEmpty(item["column_comment"].ToString())==false? 
                    item["column_comment"].ToString(): item["COLUMN_NAME"].ToString());
                stringBuilder.Append(@"        /// </summary>" + Environment.NewLine);
                stringBuilder.AppendFormat(@"        public {0} {1}" + Environment.NewLine,
                    Util.Typename(item["COLUMN_TYPE"].ToString()), "_" + item["COLUMN_NAME"].ToString());
                stringBuilder.Append(@"        {" + Environment.NewLine);
                stringBuilder.Append(@"            get" + Environment.NewLine);
                stringBuilder.Append(@"            {" + Environment.NewLine);
                stringBuilder.AppendFormat(@"                return {0};" + Environment.NewLine , "_" + item["COLUMN_NAME"].ToString());
                stringBuilder.Append(@"            }" + Environment.NewLine);
                stringBuilder.Append(@"            set" + Environment.NewLine);
                stringBuilder.Append(@"            {" + Environment.NewLine);
                stringBuilder.AppendFormat(@"                {0} = value;"+ Environment.NewLine , "_" + item["COLUMN_NAME"].ToString());
                stringBuilder.Append(@"            }" + Environment.NewLine);
                stringBuilder.Append(@"        }" + Environment.NewLine);
                stringBuilder.Append(Environment.NewLine );
                valuestring.Append(stringBuilder);
                LoadNum++;
            }
            TemplateString.Replace("{1}", valuestring.ToString());







            SpannedFile.WriteLine(TemplateString.ToString());
            SpannedFile.Close();
            TemplateFile.Close();
        }

        /// <summary>
        /// 生成表结构
        /// </summary>
        /// <param name="dataTable"></param>
        private void SpannedTable(DataTable dataTable)
        {
            Starting("生成表结构中... ...", dataTable.Rows.Count);
        }

        /// <summary>
        /// 生成API
        /// </summary>
        /// <param name="dataTable"></param>
        private void SpannedApi(DataTable dataTable)
        {
            Starting("生成API中... ...", dataTable.Rows.Count);
        }



        /// <summary>
        /// 开始事件（每个文件生成时触发）
        /// </summary>
        /// <param name="startname"></param>
        /// <param name="MaxValue"></param>
        private void Starting(string startname,int MaxValue)
        {
            LoadNum = 0;
            lb_StartName.Text = startname;
            proBar_Spanned.Maximum = MaxValue;
            if (!StartTime.Enabled)//首次启动，启动 计时器（刷新 进度条）
            {
                StartTime.Enabled = true;
            }
        }

        private int LoadNum = 0;

        private void StartTime_Tick(object sender, EventArgs e)
        {
            proBar_Spanned.Value = LoadNum;
        }
    }
}
