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
    public partial class TimeIns : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        SqlCommand sqlcommand = new SqlCommand();
        public TimeIns()
        {
            InitializeComponent();
        }

        private void TimeIns_Load(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBL", sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlconn.State == ConnectionState.Open)
            {
                sqlconn.Close();
            }
            sqlconn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBL", sqlconn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Please Select ID");
                }
                else
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AttendanceTBL WHERE Id=@ID", sqlconn);
                    cmd.Parameters.AddWithValue("@ID", (textBox1.Text));
                    cmd.ExecuteNonQuery();
                    sqlconn.Close();
                    textBox1.Text = "";

                    MessageBox.Show("Successfully Deleted!");
                }
                
            }
            catch (Exception)
            {
               
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text == string.Empty)
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBL", sqlconn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                    sqlconn.Close();
                }
                else
                {
                    sqlconn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBL WHERE sid= '" + textBox2.Text + "' or fn= '"
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AttendanceTBL", sqlconn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                sqlconn.Close();
            }
        }
    }
}
