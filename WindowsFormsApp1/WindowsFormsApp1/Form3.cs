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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();


            form4.label3.Text = this.label3.Text;
            form4.label5.Text = this.label5.Text;
            form4.label7.Text = this.label7.Text;

            // Koltukları da taşı
            foreach (var item in listBox1.Items)
            {
                form4.listBox1.Items.Add(item);
            }

            form4.Show();
        }
    }
}
