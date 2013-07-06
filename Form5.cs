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
    public partial class Form5 : Form
    {
        public Form5(string strTextBox, string strTextBox1, string strTextBox2, string strTextBox3, string strTextBox4, string strTextBox5, string strTextBox6, string strTextBox7, string strTextBox8, string strTextBox9, string strTextBox10, string strTextBox11, string strlabel37, string strTextBox13, string strTextBox14, string strTextBox15, string strTextBox17, string strTextBox18, string strTextBox19,int in11)
        {
            InitializeComponent();
            label31.Text = strTextBox;
            label18.Text = strTextBox1;
            label5.Text = strTextBox2;
            label32.Text = strTextBox3;
            label33.Text = strTextBox4;
            label34.Text = strTextBox5;
            label35.Text = strTextBox6;
            label36.Text = strTextBox7;
            label37.Text = strTextBox8;
            label38.Text = strTextBox9;
            label39.Text = strTextBox10;
            label40.Text = strTextBox11;
            label41.Text = strlabel37;
            label42.Text = strTextBox13;
            label43.Text = strTextBox14;
            label44.Text = strTextBox15;
            label46.Text = strTextBox17;
            label47.Text = strTextBox18;
            label48.Text = strTextBox19;
            label53.Text = Convert.ToString(in11);
            label45.Text = Convert.ToString(DateTime.Now);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table3' table. You can move, or remove it, as needed.
            this.table3TableAdapter.Fill(this.database1DataSet.Table3);
           // dbConnection dbconnn = new dbConnection();
           // dataGridView1.DataSource = dbconnn.getdata("select id from Table3");
            
            if (label44.Text == "Premium Customer")
            {
                premium_customer obbill = new premium_customer();
                double finalbill = obbill.bill(Convert.ToDouble(label42.Text));
                label24.Text = Convert.ToString(finalbill);
            }
            else if (label44.Text == "Gold Customer")
            {
                gold_customer obbill = new gold_customer();
                double finalbill = obbill.bill(Convert.ToDouble(label42.Text));
                label24.Text = Convert.ToString(finalbill);
            }
            else if (label44.Text == "Silver Customer")
            {
                silver_customer obbill = new silver_customer();
                double finalbill = obbill.bill(Convert.ToDouble(label42.Text));
                label24.Text = Convert.ToString(finalbill);
            }
           //label24.Text= Convert.ToDouble(
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
