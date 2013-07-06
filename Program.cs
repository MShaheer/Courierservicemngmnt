using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication5new
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
        }
    }

    public class staff
    {
        public long rate;

        public staff()
        {
            rate = 1000;
        }
        
        public void modify(long mdifiedrate)
        {

            rate = mdifiedrate;
        }

    }

    public abstract class customer : staff
    {
        public double fbill;
        //string r_name, r_country, r_c_name, r_add1, r_add2, r_p_code, r_state, r_city, r_phone;
        //string s_name, s_country, s_add1, s_city, s_telephone;
        //int wgh, rate;
        //string dlvrby, servctyp, privileges, carrier, pckging;
        //int nopckg, pckdim;

        public abstract double bill(double w);

        /*public virtual void bill()
        {
            fbill = wgh * rate;
        }*/
    }


    public class premium_customer : customer
    {
        public override double bill(double w)
        {

            
            fbill = (w * rate) * 0.85;
            MessageBox.Show("AMOUNT =" + fbill);
            return fbill;
        }
    }
    public class gold_customer : customer
    {
        public override double bill(double w)
        {
            fbill = (w * rate) * 0.9;
            MessageBox.Show("" + fbill);
            return fbill;
        }

    }
    
    public class silver_customer : customer
    {

        public override double bill(double w)
        {
            fbill = (w * rate);
            MessageBox.Show("AMOUNT =" + fbill);
            return fbill;
                        
        }

    }
           
    
}
