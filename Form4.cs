using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5new
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "shaheer" && textBox2.Text == "omer")
            {
                this.Hide();
                Form1 ob = new Form1();
                ob.Show();
                //Form4 ob2 = new Form4();
                //this.Hide();
                //this.Close();
            }
            else
            {
                    textBox1.Text = "";
                    textBox1.Text = "Invalid id or password";
                    textBox2.Text = "Invalid id or password";
                  
            }
            
        }
    }
}
