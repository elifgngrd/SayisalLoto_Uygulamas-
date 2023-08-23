using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sayi=new Random();
            int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
            sayi1=sayi.Next(1, 50);
            sayi2=sayi.Next(1, 50);
            sayi3=sayi.Next(1, 50);
            sayi4=sayi.Next(1, 50);
            sayi5=sayi.Next(1, 50);
            sayi6=sayi.Next(1, 50);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();
            label5.Text = sayi5.ToString();
            label6.Text = sayi6.ToString();

            if (textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (textBox5.Text == label5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (textBox6.Text == label6.Text)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
        }
    }
}
