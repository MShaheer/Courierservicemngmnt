using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web;
using System.IO;

namespace WindowsFormsApplication5new
{
    public partial class Form3 : Form
    {
        dbConnection dbcon = new dbConnection();

        private string recipient_name;
        //string country;
        public Form3()
        {
            InitializeComponent();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            recipient_name=Console.ReadLine();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 2)
            {
                comboBox7.Visible = false;
                comboBox10.Visible = false;
                comboBox9.Visible = true;


            }
            if (comboBox4.SelectedIndex == 1)
            {
                comboBox7.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = true;
                

            }
        }*/

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // Form5 frm = new Form5(richTextBox1.Text, richTextBox2.Text, richTextBox4.Text, richTextBox6.Text, richTextBox8.Text, richTextBox7.Text, richTextBox9.Text, richTextBox10.Text, richTextBox14.Text, richTextBox13.Text, richTextBox12.Text, richTextBox11.Text, label23.Text, textBox15.Text, textBox13.Text);
            //Form5 ob = new Form5();
            //ob.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            dbcon.conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dbcon.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedure3";

            cmd.Parameters.Add("@rname", SqlDbType.NVarChar, 50);
            cmd.Parameters["@rname"].Value = richTextBox1.Text;

            cmd.Parameters.Add("@rcountry", SqlDbType.NVarChar, 50);
            cmd.Parameters["@rcountry"].Value = richTextBox2.Text;

              cmd.Parameters.Add("@radd1", SqlDbType.NVarChar, 50);
            cmd.Parameters["@radd1"].Value = richTextBox4.Text;

            if
            (String.IsNullOrEmpty(richTextBox6.Text))
            {
                cmd.Parameters.Add("@rpostal", SqlDbType.Int).Value = DBNull.Value;
            }
            else
                cmd.Parameters.Add("@rpostal", SqlDbType.Int).Value = Convert.ToInt32(richTextBox6.Text);
                       

            cmd.Parameters.Add("@rstate", SqlDbType.NVarChar, 50);
            cmd.Parameters["@rstate"].Value = richTextBox8.Text;

            cmd.Parameters.Add("@rcity", SqlDbType.NVarChar, 50);
            cmd.Parameters["@rcity"].Value = richTextBox7.Text;

            cmd.Parameters.Add("@rphne", SqlDbType.NVarChar, 50);
            cmd.Parameters["@rphne"].Value = richTextBox9.Text;

            cmd.Parameters.Add("@sname", SqlDbType.NVarChar, 50);
            cmd.Parameters["@sname"].Value = richTextBox10.Text;

             cmd.Parameters.Add("@scountry", SqlDbType.NVarChar, 50);
            cmd.Parameters["@scountry"].Value = richTextBox14.Text;

            cmd.Parameters.Add("@sadd1", SqlDbType.NVarChar, 50);
            cmd.Parameters["@sadd1"].Value = richTextBox13.Text;

              cmd.Parameters.Add("@scity", SqlDbType.NVarChar, 50);
              cmd.Parameters["@scity"].Value = richTextBox12.Text;

            cmd.Parameters.Add("@sphne", SqlDbType.NVarChar, 50);
            cmd.Parameters["@sphne"].Value = richTextBox11.Text;

            string s1;
            s1 = "";

            if (comboBox8.SelectedIndex == 0)
            {
                 s1 = "By Air";
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                 s1 = "By Sea";
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                 s1 = "By Road";
            }


            cmd.Parameters.Add("@deliverby", SqlDbType.NVarChar, 50);
            cmd.Parameters["@deliverby"].Value = s1;

            if
            (String.IsNullOrEmpty(richTextBox3.Text))
            {
                cmd.Parameters.Add("@wgh", SqlDbType.Int).Value = DBNull.Value;
            }
            else
                cmd.Parameters.Add("@wgh", SqlDbType.Int).Value = Convert.ToInt16(richTextBox3.Text);


            string s2;
            s2 = "";

            if (comboBox3.SelectedIndex == 0)
            {
                s2 = "Urgent";
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                s2 = "Normal";
            }
           
             cmd.Parameters.Add("@servicetype", SqlDbType.NVarChar, 50);
             cmd.Parameters["@servicetype"].Value = s2;

             string s3;
             s3 = "";

             if (comboBox4.SelectedIndex == 0)
             {
                 s3 = "Premium Customer";
             }
             else if (comboBox4.SelectedIndex == 1)
             {
                 s3 = "Gold Customer";
             }
             else if (comboBox4.SelectedIndex == 2)
             {
                 s3 = "Silver Customer";
             }

            cmd.Parameters.Add("@prvlgs", SqlDbType.NVarChar, 50);
            cmd.Parameters["@prvlgs"].Value = s3;

            int in1;
            in1 =0;

            if (comboBox2.SelectedIndex == 0)
            {
                in1 = 6;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                in1 = 12;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                in1 = 24;
            }

            cmd.Parameters.Add("@pkgdim", SqlDbType.NVarChar, 50);
            cmd.Parameters["@pkgdim"].Value = in1;  

                         
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters["@date"].Value = dateTimePicker1.Value;

            string s4;
            s4 = "";

            if (comboBox6.SelectedIndex == 0)
            {
                s4 = "SOCS";
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                s4 = "DHL";
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                s4 = "FedEx";
            }

            cmd.Parameters.Add("@carrier", SqlDbType.NVarChar, 50);
            cmd.Parameters["@carrier"].Value = s4;

            string s5;
            s5 = "";

            if (comboBox5.SelectedIndex == 0)
            {
                s5 = "Cash";
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                s5 = "Premium Bonus";
            }

            cmd.Parameters.Add("@mode", SqlDbType.NVarChar, 50);
            cmd.Parameters["@mode"].Value = s5;

            /* cmd.Parameters.Add("@status", SqlDbType.NVarChar, 50);
             cmd.Parameters["@status"].Value = richTextBox1.Text;*/


            int r;
            r = cmd.ExecuteNonQuery();
            //cmd.ExecuteReader();
            dbcon.conn.Close();
            if (r > 0)
            {
                MessageBox.Show("Record Entered Sucessfully");

            }
            DataTable dt = new DataTable();
            dt=dbcon.getdata("Select * from Table3 where rname='" + richTextBox1.Text +"'");
              
            label1.Text = dt.Rows[0]["id"].ToString();
            MessageBox.Show("Your id is'" + label1.Text + "'");
                  
                 
            Form5 frm = new Form5(richTextBox1.Text, richTextBox2.Text, richTextBox4.Text, richTextBox6.Text, richTextBox8.Text, richTextBox7.Text, richTextBox9.Text, richTextBox10.Text, richTextBox14.Text, richTextBox13.Text, richTextBox12.Text, richTextBox11.Text, s1, richTextBox3.Text, s2, s3, s4, s5, richTextBox15.Text ,in1);
            frm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
