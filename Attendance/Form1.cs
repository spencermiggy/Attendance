using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Attendance
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        SqlCommand sqlcommand = new SqlCommand();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            this.AcceptButton = this.button1;
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
        }
        private bool isValid()
        {
            if (textBox1.Texts.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid username please!", "ERROR");
                return false;
            }
            else if (textBox2.Texts.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid password please!", "ERROR");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string query = "SELECT * FROM AdminLog where Username ='" + textBox1.Texts.Trim() + "' and Passwords ='" + textBox2.Texts.Trim() + "'";

                sqlconn.Open();
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        pictureBox3.Show();
                        button1.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
                sqlconn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconns = new SqlConnection(DBclass.conns);
            sqlconns.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username,Passwords FROM AdminLog WHERE LastNameT=@SID", sqlconns);
            cmd.Parameters.AddWithValue("@SID", (label4.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Texts = reader["Username"].ToString();
                textBox2.Texts = reader["Passwords"].ToString();
                button1_Click(sender, e);
            }
            else
            {

            }
            sqlconns.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
