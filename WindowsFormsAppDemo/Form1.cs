using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppDemo.ServiceReference1;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int ans = obj.sum(a, b);
            MessageBox.Show("Sum of Two Numbers is:" + ans);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int ans = obj.sub(a, b);
            MessageBox.Show("Substraction  of Two Numbers is:" + ans);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int ans = obj.mul(a, b);
            MessageBox.Show("Multiplication   of Two Numbers is:" + ans);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int ans = obj.div(a, b);
            MessageBox.Show("Division  of Two Numbers is:" + ans);
        }
    }
}
