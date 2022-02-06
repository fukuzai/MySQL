using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using HalconDotNet;

namespace MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MakeDB_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブルを作成
            using(var con = new SQLiteConnection("Data Source =test.db"))
            {
                con.Open();
                using(SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "create table t_product(CD INTEGER  PRIMARY KEY AUTOINCREMENT, productname TEXT, price INTEGER)";
                    command.ExecuteNonQuery();

                }
                con.Close();
            }
        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            using(SQLiteConnection con = new SQLiteConnection("Data source = test.db"))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("接続に成功しました");
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート
                    cmd.CommandText = "INSERT INTO t_product (productname, price) VALUES (@Product, @Price)";

                    // パラメータセット
                    cmd.Parameters.Add("Product", System.Data.DbType.String);
                    cmd.Parameters.Add("Price", System.Data.DbType.Int64);

                    // データ追加
                    cmd.Parameters["Product"].Value = t_Product.Text;
                    cmd.Parameters["Price"].Value = int.Parse(t_Price.Text);
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
            }
        }

        private void btn_halcon_Click(object sender, EventArgs e)
        {
            HTuple hv_Input = new HTuple();
            HTuple hv_double = new HTuple();
            HTuple hv_integer = new HTuple();
            HTuple hv_string = new HTuple();
            
            //double a  = Convert.ToDouble(textBox1.Text);
            
            hv_Input = 1;

            hv_double = hv_Input.D; //実数型
            label4.Text = hv_double.ToString();
            
            //hv_integer = hv_double.TupleInt();

            //HOperatorSet.TupleInt(hv_Input[0], out hv_integer);
            hv_integer = hv_Input.I; //整数型
            label5.Text = hv_integer.ToString();

            //HOperatorSet.TupleIsString(hv_Input, out hv_string);
            hv_string = hv_Input.S; //文字列
            label6.Text = hv_string.ToString();
            
        }
    }
}
