using FanFormulaFramework.DBUtile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void tV_Table_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lb_TableName.Text = tV_Table.SelectedNode.Text;
        }
    }
}
