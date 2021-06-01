using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cornowf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Que bom que você está feliz como eu :)");
            Form3 j3 = new Form3();
            j3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("VOCÊ É CORNO :D");
            Form2 j2 = new Form2();
            j2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Você é um corno, tem que estar feliz comigo cara");
            Form4 j4 = new Form4();
            j4.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
