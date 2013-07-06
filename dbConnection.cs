using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication5new
{
    class dbConnection
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        //(@"..\..\AddStudentCrystalReport.rpt");

        public static string s2;

        // label1.Text = s;

        public string goodcon()
        {
            string s = Application.StartupPath.ToString();
            s = s.Replace(@"\bin\Debug", "");
            s += @"\Database1.mdf";
            s2 = s;
            return s;
        }

        DataTable dt;
        public dbConnection()
        {
            string s = goodcon();
            string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + s + ";Integrated Security=True;User Instance=True";
            conn = new SqlConnection(connString);

        }

        public void putdata(string qury)
        {
            conn.Open();
            cmd = new SqlCommand(qury, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getdata(string query)
        {

            conn.Open();

            cmd = new SqlCommand(query, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            return dt;


        }

       


       

        public DataSet getdatafromdatatset(string query)
        {

            conn.Open();

            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds.Tables["Table3"]);
            conn.Close();
            return ds;
        }

    }
}
