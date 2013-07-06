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
    public partial class Form10 : Form
    {
        dbConnection dbconnn = new dbConnection();

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbconnn.getdata("select * from Table3");
        }
    }
}
