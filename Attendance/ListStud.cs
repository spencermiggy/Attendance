using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ListStud : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        SqlCommand sqlcommand = new SqlCommand();
        public ListStud()
        {
            InitializeComponent();
        }

        private void ListStud_Load(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Students",sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Students", sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Search Student ID!");
            }
            else
            {
                
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE SchoolID=@SCHOOLID", sqlconn);
                cmd.Parameters.AddWithValue("@SCHOOLID", (textBox1.Text));
                cmd.ExecuteNonQuery();
                sqlconn.Close();
                textBox1.Text = "";

                MessageBox.Show("Successfully Deleted!");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Students", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
                else
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Students WHERE SchoolID= '" + textBox2.Text + "' or Firstname= '"
                        + textBox2.Text + "' or Middlename= '"
                        + textBox2.Text + "' or Lastname= '"
                        + textBox2.Text + "' or Course= '"
                        + textBox2.Text + "' or Years= '"
                        + textBox2.Text + "' or Addr= '"
                        + textBox2.Text + "' or ParentNum= '"
                        + textBox2.Text + "'", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
            }
            catch (Exception)
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Students", sqlconn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlconn.Close();
            }
        }
    }
 }

