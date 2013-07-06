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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 mod = new Form9();
            mod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 view1 = new Form10();
            view1.Show();
        }
    }
}
