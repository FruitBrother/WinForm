using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static void Mysql()
        {
            string connStr = "server=localhost;user=root;database=grade;port=3306;password=1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations

                string sql = "SELECT * FROM student WHERE sdept=03 ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }
        public Form1()
        {
            InitializeComponent();
        }

        MySqlDataAdapter daStudent;
        DataSet dsStudent;
        private static string connStr = "server=localhost;user=root;database=grade;port=3306;password=1234;";
        MySqlConnection conn = new MySqlConnection(connStr);
        private void Mysqlquery(string sql)
        {
            try
            {
                // Perform database operations
                /*string sql = "select * from student where sdept = 03";*/
                daStudent = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daStudent);

                dsStudent = new DataSet();
                daStudent.Fill(dsStudent, "student");
                dataGridView1.DataSource = dsStudent;
                dataGridView1.DataMember = "student";
            }
            catch (Exception ex)
            {
                labelinfo.Text = ex.ToString();
            }
            labelinfo.Text = "Done.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                labelinfo.Text = "Connecting to MySQL...";
                // Perform database operations
                string sql = "select * from student";
                daStudent = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daStudent);

                dsStudent = new DataSet();
                daStudent.Fill(dsStudent, "student");
                dataGridView1.DataSource = dsStudent;
                dataGridView1.DataMember = "student";
            }
            catch (Exception ex)
            {
                labelinfo.Text = ex.ToString();
            }
            labelinfo.Text = "Done.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from student where ";
                bool flag = false;
                if (snamecheck.Checked)
                {
                    flag = true;
                    sql += "sname like '";
                    sql += snametext.Text;
                    sql += "' ";
                }
                if (sidcheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "sid like '";
                    sql += sidtext.Text;
                    sql += "' ";
                    flag = true;
                }
                if (sagecheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "sage >= ";
                    sql += sagetext1.Text;
                    sql += " and sage <= ";
                    sql += sagetext2.Text;
                    sql += " ";
                    flag = true;
                }
                if (ssexcheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "ssex like '";
                    sql += sidtext.Text;
                    sql += "' ";
                    flag = true;
                }
                if (sclasscheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "sclass like '";
                    sql += sclasstext.Text;
                    sql += "' ";
                    flag = true;
                }
                if (sdeptcheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "sdept like '";
                    sql += sdepttext.Text;
                    sql += "' ";
                    flag = true;
                }
                if (saddrcheck.Checked)
                {
                    if (flag) sql += "and ";
                    sql += "saddr like '";
                    sql += saddrtext.Text;
                    sql += "' ";
                    flag = true;
                }
                //Console.WriteLine(sql);
                sqloutput.Text = sql;
                Mysqlquery(sql);
                labelinfo.Text = "MySQL Database Updated!";
            }
            catch (Exception ex)
            {
                labelinfo.Text = ex.ToString();
            }
        }

    }
}
