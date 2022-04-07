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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO.Ports;
using System.Threading;

namespace Attendance
{
    public partial class Home : UserControl
    {
        SqlConnection sqlconn = new SqlConnection(DBclass.conns);
        public Home()
        {
            InitializeComponent();
        }
        FilterInfoCollection infoCollection;
        VideoCaptureDevice videoCaptureDevice;


        private void Home_Load(object sender, EventArgs e)
        {
            infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in infoCollection)
                comboBox1.Items.Add(info.Name);
            comboBox1.SelectedIndex = 0;
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO AttendanceTBL(fn,mn,ln,timin,datin,cour,yr,sid) VALUES (@FN,@MN,@LN,@TIMIN,@DATIN,@COUR,@YR,@SIDS)", sqlconn);
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Wala kay na select na studyante!!!!");
            }
            else
            {
                cmd.Parameters.AddWithValue("@FN", textBox1.Text);
                cmd.Parameters.AddWithValue("@MN", textBox2.Text);
                cmd.Parameters.AddWithValue("@LN", textBox3.Text);
                cmd.Parameters.AddWithValue("@TIMIN", label7.Text);
                cmd.Parameters.AddWithValue("@DATIN", label8.Text);
                cmd.Parameters.AddWithValue("@COUR", textBox4.Text);
                cmd.Parameters.AddWithValue("@YR", textBox5.Text);
                cmd.Parameters.AddWithValue("@SIDS", textBox6.Text);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                pictureBox2.Image = null;

                MessageBox.Show("Successfully Saved!");
                sqlconn.Close();
                try
                {
                    SerialPort serialPort = new SerialPort();
                    serialPort.PortName = textBox8.Text;
                    serialPort.Open();
                    serialPort.WriteLine("AT" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CMGF=1" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CMGS=\"" + label11.Text + "\"" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("YOUR CHILD ENTER THE SCHOOL AT '" + label7.Text + "' DATE:'" + label8.Text + "'" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.Write(new byte[] { 26 }, 0, 1);
                    Thread.Sleep(100);
                    var response = serialPort.ReadExisting();
                    if (response.Contains("ERROR"))
                    {
                        MessageBox.Show("Sending Failed", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message Sent", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    serialPort.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("NO GSM DETECTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            sqlconn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlconn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Firstname,Middlename,Lastname,Course,Years,SchoolID,Pics FROM Students WHERE SchoolID=@SID", sqlconn);
            cmd.Parameters.AddWithValue("@SID", (textBox7.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["Firstname"].ToString();
                textBox2.Text = reader["Middlename"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["Course"].ToString();
                textBox5.Text = reader["Years"].ToString();
                textBox6.Text = reader["SchoolID"].ToString();
                MemoryStream ms = new MemoryStream((byte[])reader["Pics"]);
                pictureBox2.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Student Not Found");
            }
            sqlconn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(infoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox7.Text = result.ToString();
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconns = new SqlConnection(DBclass.conns);
            sqlconns.Open();
            SqlCommand cmd = new SqlCommand("SELECT Firstname,Middlename,Lastname,Course,Years,SchoolID,Pics FROM Students WHERE SchoolID=@SID", sqlconns);
            cmd.Parameters.AddWithValue("@SID", (textBox7.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["Firstname"].ToString();
                textBox2.Text = reader["Middlename"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["Course"].ToString();
                textBox5.Text = reader["Years"].ToString();
                textBox6.Text = reader["SchoolID"].ToString();
                MemoryStream ms = new MemoryStream((byte[])reader["Pics"]);
                pictureBox2.Image = new Bitmap(ms);
            }
            else
            {
                
            }
            sqlconns.Close();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO AttendanceTBLL(fn,mn,ln,timin,datin,cour,yr,sid) VALUES (@FN,@MN,@LN,@TIMIN,@DATIN,@COUR,@YR,@SIDS)", sqlconn);
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Wala kay na select na studyante!!!!");
            }
            else
            {
                cmd.Parameters.AddWithValue("@FN", textBox1.Text);
                cmd.Parameters.AddWithValue("@MN", textBox2.Text);
                cmd.Parameters.AddWithValue("@LN", textBox3.Text);
                cmd.Parameters.AddWithValue("@TIMIN", label7.Text);
                cmd.Parameters.AddWithValue("@DATIN", label8.Text);
                cmd.Parameters.AddWithValue("@COUR", textBox4.Text);
                cmd.Parameters.AddWithValue("@YR", textBox5.Text);
                cmd.Parameters.AddWithValue("@SIDS", textBox6.Text);
                cmd.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                pictureBox2.Image = null;

                MessageBox.Show("Successfully Saved!");
                sqlconn.Close();
                try
                {
                    SerialPort serialPort = new SerialPort();
                    serialPort.PortName = textBox8.Text;
                    serialPort.Open();
                    serialPort.WriteLine("AT" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CMGF=1" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("AT+CMGS=\"" + label11.Text + "\"" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.WriteLine("YOUR CHILD EXITS THE SCHOOL AT '" + label7.Text + "' DATE:'" + label8.Text + "'" + Environment.NewLine);
                    Thread.Sleep(100);
                    serialPort.Write(new byte[] { 26 }, 0, 1);
                    Thread.Sleep(100);
                    var response = serialPort.ReadExisting();
                    if (response.Contains("ERROR"))
                    {
                        MessageBox.Show("Sending Failed", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message Sent", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    serialPort.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("NO GSM DETECTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            sqlconn.Close();
        }
    }
}
