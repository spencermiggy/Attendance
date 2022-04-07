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
    public partial class AddStud : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        SqlCommand sqlcommand = new SqlCommand();
        public AddStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                SqlCommand sqlcommand = new SqlCommand("INSERT INTO Students(Firstname,Middlename,Lastname,Course,Years,Birthdate,Addr,SchoolID,Pics,PicPath,ParentNum) VALUES (@FN,@MN,@LN,@CO,@YR,@BD,@AD,@SID,@PICS,@PICPATH,@PARENTNUM)", sqlconn);
                sqlcommand.Parameters.AddWithValue("@FN", textBox1.Text);
                sqlcommand.Parameters.AddWithValue("@MN", textBox2.Text);
                sqlcommand.Parameters.AddWithValue("@LN", textBox3.Text);
                sqlcommand.Parameters.AddWithValue("@CO", textBox4.Text);
                sqlcommand.Parameters.AddWithValue("@YR", textBox5.Text);
                sqlcommand.Parameters.AddWithValue("@BD", textBox6.Text);
                sqlcommand.Parameters.AddWithValue("@AD", textBox7.Text);
                sqlcommand.Parameters.AddWithValue("@SID", textBox8.Text);
                sqlcommand.Parameters.AddWithValue("@PICPATH", textBox9.Text);
                sqlcommand.Parameters.AddWithValue("@PICS", picdata.Value);
                sqlcommand.Parameters.AddWithValue("@PARENTNUM", textBox10.Text);


                int x = sqlcommand.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Successfully Saved!");
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
                    sqlconn.Close();
                }
                else
                {
                    MessageBox.Show("Please Ayaw na ibalik.x ug type");
                    sqlconn.Close();
                }
                sqlconn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Fill All Information");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
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
