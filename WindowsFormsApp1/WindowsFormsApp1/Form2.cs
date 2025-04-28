using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2: Form
    {


        public Form2(string film, string salon, string seans)
        {
            InitializeComponent();
            label3.Text = film;  
            label5.Text = salon;  
            label7.Text = seans; 
        }



        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 14");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 15");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 16");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 17");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 18");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 19");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 20");
        }

        private void button21_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();

           
            form3.label3.Text = this.label3.Text;
            form3.label5.Text = this.label5.Text;
            form3.label7.Text = this.label7.Text;

            // Koltukları da taşı
            foreach (var item in listBox1.Items)
            {
                form3.listBox1.Items.Add(item);
            }

            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Koltuk : 4");
        }
    }
}
