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
            
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid username please!", "ERROR");
                return false;
            }
            else if (textBox2.Text.TrimStart() == string.Empty)
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
                string query = "SELECT * FROM AdminLog where Username ='" + textBox1.Text.Trim() + "' and Passwords ='" + textBox2.Text.Trim() + "'";

                sqlconn.Open();
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
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
    }
}
