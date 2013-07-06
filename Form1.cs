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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
           
            //MessageBox.Show("THIS APPLICATION IS DEVELOPED BY M.SHAHEER & OMER TARIQ\n\nStudents of KARACHI UNIVERISTY\nDEPARTMENT OF COMPUTER SCIENCE (UBIT)\nBSCS 2nd Year (3rd Semester)\nOmer's EP# : 114968\nM.Shaheer's EP# : 114953","Developers Of This Application");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            //MessageBox.Show("    Coming Soon","Under Construction");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 ob9 = new Form8();
            ob9.Show();
            //MessageBox.Show("    Coming Soon","Under Construction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    Coming Soon", "Under Construction");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 ob9 = new Form11();
            ob9.Show();
            //MessageBox.Show("    Coming Soon", "Under Construction");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 placeorder = new Form3();
            placeorder.Show();
            //MessageBox.Show("Coming Soon\nThis will open a new form which will book orders.", "Under Construction");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Coming Soon\nThis will open a new form which will track existing orders.", "Under Construction");
            Form7 ob = new Form7();
            ob.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Coming Soon\nThis will be for the Employee attending the customer+For modifying price list of packages.", "Under Construction");
            Form6 ob = new Form6();
            ob.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Form4 auth=new Form4();
            //auth.Close();
            //this.Close();
            Application.Exit();
        }
       
        private Point mouseOffset;
        private bool isMouseDown = false;
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
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
             
              
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (isMouseDown)
            {
                
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
       


    }
}
