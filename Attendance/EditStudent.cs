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
    public partial class EditStudent : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        public EditStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Firstname,Middlename,Lastname,Course,Years,Birthdate,Addr,SchoolID,Pics,ParentNum FROM Students WHERE SchoolID=@SID", sqlconn);
            cmd.Parameters.AddWithValue("@SID", (textBox8.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["Firstname"].ToString();
                textBox2.Text = reader["Middlename"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["Course"].ToString();
                textBox5.Text = reader["Years"].ToString();
                textBox6.Text = reader["Birthdate"].ToString();
                textBox7.Text = reader["Addr"].ToString();
                textBox8.Text = reader["SchoolID"].ToString();
                textBox10.Text = reader["ParentNum"].ToString();
                MemoryStream ms = new MemoryStream((byte[])reader["Pics"]);
                pictureBox1.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Student Not Found");
            }
            sqlconn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                string imgpath = textBox9.Text;
                FileStream fs;
                fs = new FileStream(@imgpath, FileMode.Open, FileAccess.Read);
                byte[] picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                SqlParameter picdata = new SqlParameter();
                picdata.SqlDbType = SqlDbType.Image;
                picdata.ParameterName = "PICS";
                picdata.Value = picbyte;
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Firstname=@FIRSTNAME,Middlename=@MIDDLENAME,Lastname=@LASTNAME,Course=@COURSE,Years=@YEARS,Birthdate=@BIRTHDATE,Addr=@ADDR,SchoolID=@SCHOOLID,Pics=@PICS,ParentNum=@PARENTNUM WHERE SchoolID=@SCHOOLID", sqlconn);
                cmd.Parameters.AddWithValue("@FIRSTNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@MIDDLENAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@LASTNAME", textBox3.Text);
                cmd.Parameters.AddWithValue("@COURSE", textBox4.Text);
                cmd.Parameters.AddWithValue("@YEARS", textBox5.Text);
                cmd.Parameters.AddWithValue("@BIRTHDATE", textBox6.Text);
                cmd.Parameters.AddWithValue("@ADDR", textBox7.Text);
                cmd.Parameters.AddWithValue("@SCHOOLID", textBox8.Text);
                cmd.Parameters.AddWithValue("@PICS", picdata.Value);
                cmd.Parameters.AddWithValue("@PARENTNUM", textBox10.Text);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                pictureBox1.Image = null;

                MessageBox.Show("Successfully Updated!");
                sqlconn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Search School ID!");
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "JPG|*.jpg|PNG|*.png";
            if (o.ShowDialog() == DialogResult.OK)
            {
                textBox9.Text = o.FileName;
                pictureBox1.Image = new Bitmap(o.FileName);
            }
        }
    }
}
