using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Xml.Linq;


namespace ConectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            if (checkBox1.Checked)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = @"insert into tmp(id,tt) values(@id, @tt);";
                SQLiteParameter param1 = new SQLiteParameter();
                param1.ParameterName = "id";
                param1.Value = textBox_id.Text;
                cmd.Parameters.Add(param1);

                SQLiteParameter param2 = new SQLiteParameter();
                param2.ParameterName = "tt";
                param2.Value = textBox_tt.Text;
                cmd.Parameters.Add(param2);
            }
            else
            {
                cmd.CommandText = "create table tmp(id int PRIMARY KEY, tt varchar(20));" +
                "insert into tmp(id,tt) values(1, 'qq');" +
                "insert into tmp(id,tt) values(2, 'mm');";
            }            
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tmp;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = textBox2.Text + reader[0] + " " + reader[1] +"\r\n";
            }
            reader = null;
            conn.Close();
        }
        //Отсоединенный режим
        private DataSet ds;
        private SQLiteDataAdapter adapter;
       
        private void btn3_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            SQLiteCommand cmd = new SQLiteCommand();            
            //adapter = new SQLiteDataAdapter("select * from tmp;", conn);
            adapter = new SQLiteDataAdapter(textBox_SQL.Text, conn); // select name from sqlite_master where type='table' - просмотр таблиц БД
            //adapter.SelectCommand = cmd;
            SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(adapter); //  Builder - для одной таблицы базы данных, с джоинами работать не будет
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            adapter.Update(ds);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "create table tmp2(id int PRIMARY KEY, ff varchar(20), yy varchar(20));" +
                "insert into tmp2(id,ff, yy) values(1, 'qq', 'hh');" +
                "insert into tmp2(id,ff, yy) values(2, 'gg', 'ww');" +

                "create table tmp3(id int PRIMARY KEY, dd varchar(20), pp varchar(20));" +
                "insert into tmp3(id,dd, pp) values(1, 'fff', 'lll');" +
                "insert into tmp3(id,dd, pp) values(2, 'vvv', 'ppp');" +

                "create table tmp4(id int PRIMARY KEY, rr varchar(20), uu varchar(20));" +
                "insert into tmp4(id,rr, uu) values(1, 'aa', 'cc');" +
                "insert into tmp4(id,rr, uu) values(2, 'xx', 'zz');";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string sqltext = "select * from tmp;" +
                "select * from tmp2;" +
                "select * from tmp3;" +
                "select * from tmp4;";
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source = qqq.db3";
            adapter = new SQLiteDataAdapter(sqltext, conn);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "select name from sqlite_master where type='table';";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);                
            }
            reader = null;
            conn.Close();
            
            SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(adapter);
            adapter.TableMappings.Add("Table", "tmp");
            adapter.TableMappings.Add("Table2", "tmp2");
            adapter.TableMappings.Add("Table3", "tmp3");
            adapter.TableMappings.Add("Table4", "tmp4");
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables["tmp"];

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox1.Text];
        }
    }
}
