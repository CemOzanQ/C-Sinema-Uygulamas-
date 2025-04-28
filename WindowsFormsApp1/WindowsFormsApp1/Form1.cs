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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Inception");
            comboBox1.Items.Add("The Batman");
            comboBox1.Items.Add("Avatar 2");
            comboBox2.Items.Add("Salon 1");
            comboBox2.Items.Add("Salon 2");
            comboBox2.Items.Add("Salon 3");
            comboBox3.Items.Add("13:30");
            comboBox3.Items.Add("17:30");
            comboBox3.Items.Add("21:00");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string film = comboBox1.SelectedItem.ToString();
            string salon = comboBox2.SelectedItem.ToString();
            string seans = comboBox3.SelectedItem.ToString();

            Form2 form2 = new Form2(film, salon, seans);
            form2.Show();
            this.Hide();
        }


        
    }
}
