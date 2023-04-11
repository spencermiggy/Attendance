using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            home2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listStud2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addStud2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editAdminAcc2.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editStudent2.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timeIns2.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timeOuts1.BringToFront();
        }
    }
}
