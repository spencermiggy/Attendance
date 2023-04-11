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
    public partial class TimeOuts : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        SqlCommand sqlcommand = new SqlCommand();
        public TimeOuts()
        {
            InitializeComponent();
        }

        private void TimeOuts_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button5.Hide();
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            textBox2.Text = null;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if(textBox1.Texts != string.Empty)
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AttendanceTBLL WHERE Id ='" + textBox1.Texts + "'", sqlconn);
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();

                    MessageBox.Show("Successfully Deleted!");
                    textBox1.Texts = string.Empty;
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
                else
                {
                    MessageBox.Show("Please Select LOGOUT ID!");
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
                else
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL WHERE sid= '" + textBox2.Text + "' or fn= '"
                        + textBox2.Text + "' or mn= '"
                        + textBox2.Text + "' or ln= '"
                        + textBox2.Text + "' or timin= '"
                        + textBox2.Text + "' or datin= '"
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlconn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text;
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Texts == string.Empty)
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
                else
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL WHERE Id= '" + textBox1.Texts + "'", sqlconn);
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBLL", sqlconn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlconn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Show();
            button5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete all data?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM AttendanceTBLL", sqlconn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Data deleted!");
                sqlconn.Close();
            }
            else
            {
                MessageBox.Show("Operation Aborted!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button5.Hide();
        }
    }
}
