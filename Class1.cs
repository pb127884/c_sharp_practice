using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    public class shipdata
    {
        public int employeeNo { get; set; }
        public string employeename { get; set; }
        public string employeeaddress { get; set; }
        public string employeeCity { get; set; }
        public string employeeState { get; set; }
        public string employeeCountry { get; set; }
        public int employeePostalCode { get; set; }


    }

    public class customer
    {

        public int CustomerNo { get; set; }
        public string customerName { get; set; }
        public string customeraddress { get; set; }
        public string customerCity { get; set; }
        public string customerState { get; set; }
        public string customerCountry { get; set; }
        public int customercontactNo { get; set; }

    }


    public class product
    {
        internal object amount;
        internal int pu;

        public int productNo { get; set; }
        public string productName { get; set; }
        public int unitprice { get; set; }

        public int productquantity { get; set; }

        public int Amount { get; set; }

        public int discount { get; set; }
        public int grandtotal { get; set; }
        public int Pd { get; internal set; }
        public string DateTime { get; set; }


       // DateTime dt = DateTime.Now;
      //  DateTime mod = DateTime.Now;
    }

    public class order1
    {
        internal DateTime dateTime;

        //public int OrderNo { get; set; }

        public int OrderNo { get; set; }

        public int date { get; set; }

        public int modifydate { get; set; }

        public int Pname { get; set; }
    }

    public class order2
    {
        public int OrderNo { get; set; }

        public int ONo { get; set; }

        public int PNO { get; set; }
        
            public int Cno { get; set; }
        public int Eno { get; set; }
        
        public int productquantity1 { get; set; }

        public string Pname { get; set; }
        public string cname { get; set; }
       
        public string cName { get; set; }
        public string caddress { get; set; }
        public string cCity { get; set; }
        public string cState { get; set; }
        public string cCountry { get; set; }
        public int ccontactNo { get; set; }
        public int productunit { get; set; }
        public int finalamount { get; set; }
        public int discount { get; set; }
        public int grandamount { get; set; }
       
             internal DateTime aDate;
        internal DateTime bDate;
       


        
    }


    public class order3
    {
        
        public int ONo { get; set; }

        public int PNO{ get; set; }

        public int Cno { get; set; }
        public int Eno { get; set; }

        public int productquantity1 { get; set; }

        public string Pname { get; set; }
        public string cname { get; set; }

       
        
        public int productunit { get; set; }
        public int finalamount { get; set; }
        public int discount { get; set; }
        public int grandamount { get; set; }

        internal DateTime aDate;
        internal DateTime bDate;




    }

}


