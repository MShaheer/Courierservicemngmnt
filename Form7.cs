using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5new
{
    public partial class Form7 : Form
    {
        dbConnection dbcon = new dbConnection();
        
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbcon.getdata("Select * from Table3 where id='" + textBox1.Text + "'");

            textBox2.Text = dt.Rows[0]["rname"].ToString();
            textBox3.Text = dt.Rows[0]["rcity"].ToString();
            textBox4.Text = "Shipped";
        }

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {

            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }


        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMouseDown)
            {

                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }

        }

        private void Form7_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
