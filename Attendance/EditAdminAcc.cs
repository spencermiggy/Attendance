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
    public partial class EditAdminAcc : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        public EditAdminAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if(textBox3.Text == string.Empty)
            {
                MessageBox.Show("NOTHINGS CHANGE!");
            }
            else
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AdminLog SET Username=@USERNAME, Passwords=@PASSWORD WHERE LastNameT=@LAST", sqlconn);
                cmd.Parameters.AddWithValue("@USERNAME", (textBox1.Text));
                cmd.Parameters.AddWithValue("@PASSWORD", (textBox2.Text));
                cmd.Parameters.AddWithValue("@LAST", (textBox3.Text));
                cmd.ExecuteNonQuery();
                sqlconn.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Updated Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text == string.Empty)
            {

                MessageBox.Show("Please Insert a Info!");
            }
            else
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO AdminLog(Username,Passwords,LastNameT) VALUES (@USERNAME,@PASSWORD,@LAST)", sqlconn);
                cmd.Parameters.AddWithValue("@USERNAME", (textBox1.Text));
                cmd.Parameters.AddWithValue("@PASSWORD", (textBox2.Text));
                cmd.Parameters.AddWithValue("@LAST", (textBox3.Text));
                cmd.ExecuteNonQuery();
                sqlconn.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Account Added Successfully");
            }
        }
    }
}
