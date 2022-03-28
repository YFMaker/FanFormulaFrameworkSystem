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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void Loading()
        {
            List<TypeSql> typeSqls = new List<TypeSql>()
            {
                new TypeSql(){SQLName="MicrosoftSQLServer",SQLNum=(int)CurrentDbType.MicrosoftSQLServer,SQLAddress="Data Source={0};Initial Catalog={1};User Id={2};Password={3}"},
                new TypeSql(){SQLName="MySql",SQLNum=(int)CurrentDbType.MySql,SQLAddress="Database='{0}';Data Source='{1}';User Id='{2}';Password='{3}';charset='utf8';pooling=true"},
                new TypeSql(){SQLName="Oracle",SQLNum=(int)CurrentDbType.Oracle,SQLAddress="Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={1})));Persist Security Info=True;User ID={2};Password={3}"},
                new TypeSql(){SQLName="Sqlite",SQLNum=(int)CurrentDbType.Sqlite,SQLAddress="Data Source={0};Version=3"}
            };

            cob_SqlType.TextChanged -= new System.EventHandler(cob_SqlType_TextChanged);
            cob_SqlType.DataSource = typeSqls;
            cob_SqlType.DisplayMember = "SQLName";
            cob_SqlType.ValueMember = "SQLAddress";
            cob_SqlType.TextChanged += new System.EventHandler(cob_SqlType_TextChanged);

        }

        private void cob_SqlType_TextChanged(object sender, EventArgs e)
        {
            tB_sqlnet.Text = cob_SqlType.SelectedValue.ToString();
            //lb_message.Text = ((TypeSql)cob_SqlType.SelectedItem).SQLNum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseService dataBaseService = new DataBaseService((CurrentDbType)((TypeSql)cob_SqlType.SelectedItem).SQLNum, tB_sqlnet.Text);
                string messageText = "";
                bool isEnable = dataBaseService.IsEnable(out messageText);
                if (isEnable)
                {
                    this.Hide();
                    Form2 form2 = new Form2(dataBaseService);
                    form2.ShowDialog();
                }
                else
                {
                    lb_message.Text = messageText;
                }
            }
            catch (Exception ex)
            {
                lb_message.Text = ex.Message;
            }
        }
    }

    class TypeSql
    {
        public string SQLName { get; set; }

        public int SQLNum { get; set; }

        public string SQLAddress { get; set; }
    }
}
