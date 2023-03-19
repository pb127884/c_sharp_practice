using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
    class program
    {
        //DateTime.Now
        public static int productquantity;
        public static int grandtotal;
        public static int discount;

        public static int Amount { get; set; }
        public static string DateTime1 { get; set; }

        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;
            DateTime bDate = DateTime.Now;
            DateTime cDate = DateTime.Now;

            Int32 intTime = 3000000;

            List<shipdata> objEmployee = new List<shipdata>();


            shipdata empdata = new shipdata();
            shipdata empdata2 = new shipdata();

            empdata.employeeNo = 1;
            empdata.employeename = "Parth ";
            empdata.employeeaddress = "84,ishwar nagar society";
            empdata.employeeCity = "surat";
            empdata.employeeState = "gujarat";
            empdata.employeeCountry = "india";
            empdata.employeePostalCode = 395010;

            empdata.employeeNo = 2;
            empdata.employeename = "Parth ";
            empdata.employeeaddress = "84,ishwar nagar society";
            empdata.employeeCity = "surat";
            empdata.employeeState = "gujarat";
            empdata.employeeCountry = "india";
            empdata.employeePostalCode = 395010;

            objEmployee.Add(empdata);
            objEmployee.Add(empdata2);


            List<customer> objcustomer = new List<customer>();
            customer customerdata = new customer();
            customer customerdata2 = new customer();

            customerdata.CustomerNo = 1;
            customerdata.customerName = "sahil ";
            customerdata.customeraddress = "84,ishwar nagar society";
            customerdata.customerCity = "surat";
            customerdata.customerState = "gujarat";
            customerdata.customerCountry = "india";

            customerdata2.CustomerNo = 2;
            customerdata2.customerName = "rohan";
            customerdata2.customeraddress = "ahmedabadi colony";
            customerdata2.customerCity = "ahmedabadi";
            customerdata2.customerState = "gujarat";
            customerdata2.customerCountry = "india";

            objcustomer.Add(customerdata);
            objcustomer.Add(customerdata2);



            List<product> objproduct = new List<product>();
            product productdata = new product();
            product productdata2 = new product();


            productdata.productNo = 1;
            productdata.productName = "wafer";
            productdata.unitprice = 20;
            productdata.productquantity = productquantity;
            productdata.Amount = Amount;
            productdata.grandtotal = grandtotal;
            productdata.discount = discount;
            productdata.DateTime = DateTime1;

            productdata2.productNo = 2;
            productdata2.productName = "bag";
            productdata2.unitprice = 2220;
            productdata2.productquantity = productquantity;
            productdata2.Amount = Amount;
            productdata2.grandtotal = grandtotal;
            productdata2.discount = discount;




            objproduct.Add(productdata);
            objproduct.Add(productdata2);



            List<order2> objorder1 = new List<order2>();
            order2 orderdata1 = new order2();
            order2 orderdat2 = new order2();


            objorder1.Add(orderdata1);
            objorder1.Add(orderdat2);


            List<order3> objorder = new List<order3>();
            order3 orderdata = new order3();



            objorder1.Add(orderdata1);
            objorder1.Add(orderdat2);

             

        Nextthings:
            try
            {


                Console.WriteLine("welcome to order system");
                Console.WriteLine("press1 for start the system");

                int select = Convert.ToInt32(Console.ReadLine());

            Nextthing6:
                switch (select)
                {
                    

                    case 1:
                    nextthing2:
                    nextthing4:
                        Console.WriteLine("option 1. Order Entry");
                        Console.WriteLine("option 2. Last Order Detail");
                        Console.WriteLine("option 3. Last Order's UnitPrice");

                        Console.WriteLine("please select one option's");

                    
                        try
                        {
                        nextthing3:

                            int myoptions = Convert.ToInt32(Console.ReadLine());


                            switch (myoptions)
                                 

                            {

                                case 1:
                                Nextthing4:
                                    //Console.WriteLine("1. add order");
                                    //Console.WriteLine("2. Update order");
                                    //Console.WriteLine("3. Delete order");
                                    //Console.WriteLine("4. main menu");
                                    try
                                    {
                                        orderd();

                                    }
                                    catch
                                    {

                                    }

                                    orderd();

                                    void orderd()
                                    {
                                    Nextthing1:
                                       
                                        try
                                        {
                                            Console.WriteLine("1. add order");
                                            Console.WriteLine("2. Update order");
                                            Console.WriteLine("3. Delete order");
                                           Console.WriteLine("4. main menu");
                                            int myoptions2 = Convert.ToInt32(Console.ReadLine());

                                            switch (myoptions2)
                                            {
                                                case 1:
                                                    Console.WriteLine("add order no");

                                                    int orderno = Convert.ToInt32(Console.ReadLine());
                                                    order2 od = objorder1.Find(e => e.OrderNo == orderno);

                                                    Console.WriteLine("add employeeNo ");

                                                    int employeeNo = Convert.ToInt32(Console.ReadLine());

                                                next:

                                                    Console.WriteLine("add CustomerNo ");
                                                    int CustomerNo = Convert.ToInt32(Console.ReadLine());
                                                    customer cd = objcustomer.Find(e => e.CustomerNo == CustomerNo);

                                                    if (cd != null)
                                                    {
                                                        Console.WriteLine("customer no - " + cd.CustomerNo);
                                                        Console.WriteLine("customer Name - " + cd.customerName);
                                                        Console.WriteLine("customer address - " + cd.customeraddress);
                                                        Console.WriteLine("customer City - " + cd.customerCity);
                                                        Console.WriteLine("customer State - " + cd.customerState);
                                                        Console.WriteLine("customer Country - " + cd.customerCountry);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("customer not found");
                                                        goto next;
                                                    }
                                                next1:
                                                    Console.WriteLine("add productno  ");
                                                    int productno = Convert.ToInt32(Console.ReadLine());
                                                    product pd = objproduct.Find(e => e.productNo == productno);

                                                    if (pd != null)
                                                    {
                                                        Console.WriteLine("product no - " + pd.productNo);
                                                        Console.WriteLine("productName - " + pd.productName);
                                                        Console.WriteLine("product unitprice  = " + pd.unitprice);

                                                        Console.WriteLine("add product quantity  ");

                                                        int productquantity = Convert.ToInt32(Console.ReadLine());

                                                        int a = pd.unitprice;
                                                        int b = productquantity;
                                                        int Amount = (a * b);
                                                        pd.Amount = Amount;
                                                        Console.WriteLine("product Amount is " + pd.Amount);

                                                        Console.WriteLine("enter discount");
                                                        int discount = int.Parse(Console.ReadLine());
                                                        pd.discount = discount;

                                                        int c = pd.Amount;
                                                        int d = discount;
                                                        int grandtotal = (c - d);
                                                        pd.grandtotal = grandtotal;

                                                        Console.WriteLine("grandtotal Amount is " + pd.grandtotal);
                                                        Console.WriteLine("order date is " + aDate.ToString("MM/dd/yyyy"));
                                                        Console.WriteLine("modify date is " + bDate.ToString("MM/dd/yyyy"));

                                                        objorder1.Add(new order2 { ONo = orderno, Cno = CustomerNo, PNO = productno, productunit = pd.unitprice, productquantity1 = productquantity, finalamount = pd.Amount, discount = pd.discount, grandamount = pd.grandtotal, aDate = aDate, bDate = bDate });
                                                        // objorder1.Add(new order2 { ONo = orderno, Cno = CustomerNo, PNO = productno, productunit = pd.unitprice, productquantity1 = productquantity, finalamount = pd.Amount, discount = pd.discount, grandamount = pd.grandtotal, aDate = aDate, bDate = bDate });
                                                        order2 orderdata1 = new order2();
                                                        orderdata1.ONo = orderno;
                                                        orderdata1.Cno = CustomerNo;
                                                        orderdata1.PNO = productno;
                                                        orderdata1.Cno = CustomerNo;
                                                        orderdata1.cname = cd.customerName;
                                                        orderdata1.caddress = cd.customeraddress;

                                                        orderdata1.cCity = cd.customerCity;
                                                        orderdata1.cState = cd.customerState;
                                                        orderdata1.productunit = pd.unitprice;
                                                        orderdata1.productquantity1 = productquantity;
                                                        orderdata1.finalamount = pd.Amount;
                                                        orderdata1.discount = pd.discount;
                                                        orderdata1.grandamount = pd.grandtotal;
                                                        orderdata1.aDate = aDate;
                                                        orderdata1.bDate = bDate;


                                                        objorder1.Add(orderdata1);




                                                        void order()
                                                        {
                                                            Console.WriteLine("enter product no");
                                                            int productno1 = Convert.ToInt32(Console.ReadLine());

                                                           

                                                            product pd = objproduct.Find(e => e.productNo == productno1);
                                                            Console.WriteLine("product no - " + productno1);
                                                            Console.WriteLine("productName - " + pd.productName);
                                                            Console.WriteLine("product unitprice  = " + pd.unitprice);
                                                            // int productquantity = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("add product quantity  ");
                                                            int productquantity2 = Convert.ToInt32(Console.ReadLine());
                                                            int a = pd.unitprice;
                                                            int b = productquantity2;
                                                            int Amount = (a * b);
                                                           
                                                            Console.WriteLine("product Amount is " + Amount);

                                                            Console.WriteLine("enter discount");
                                                            int discount1 = int.Parse(Console.ReadLine());
                                                           

                                                            int c = Amount;
                                                            int d = discount1;
                                                            int grandtotal1 = (c - d);
                                                           

                                                            Console.WriteLine("grandtotal Amount is " + grandtotal1);
                                                            Console.WriteLine("order date is " + aDate.ToString("MM/dd/yyyy"));


                                                            order3 orderdata = new order3();
                                                            orderdata.ONo = orderno;
                                                            orderdata.Cno = CustomerNo;
                                                            orderdata.PNO = productno1;
                                                            orderdata.productunit = pd.unitprice;
                                                            orderdata.productquantity1 = productquantity2;
                                                            orderdata.finalamount = Amount;
                                                            orderdata.discount = discount1;
                                                            orderdata.grandamount = grandtotal1;
                                                            orderdata.aDate = aDate;
                                                            orderdata.bDate = bDate;


                                                            objorder.Add(orderdata);

                                                            Console.WriteLine("press 1 for add one more order");

                                                            Console.WriteLine("press 2 for show order details or continue ");
                                                            int num = int.Parse(Console.ReadLine());
                                                            if (num == 1)
                                                            {
                                                                order();

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("order details is ");

                                                                Console.WriteLine("employeeNo is - " + orderdata1.Eno);
                                                                Console.WriteLine("orderno is " + orderdata1.ONo);
                                                                Console.WriteLine("CustomerNo is " + orderdata1.Cno);
                                                                // Console.WriteLine("productno is " + productno);
                                                                Console.WriteLine("customer no - " + orderdata1.Cno);
                                                                Console.WriteLine("customer name - " + orderdata1.cname);
                                                                Console.WriteLine("customer address - " + orderdata1.caddress);
                                                                Console.WriteLine("customer city - " + orderdata1.cCity);
                                                                Console.WriteLine("customer state - " + orderdata1.cState);
                                                                Console.WriteLine("customer country - " + orderdata1.cCountry);
                                                                Console.WriteLine("product no - " + orderdata1.PNO);
                                                                //  Console.WriteLine("productName - " + orderdata1.Pname);
                                                                Console.WriteLine("product price = " + orderdata1.productunit);
                                                                Console.WriteLine("product quantity is " + orderdata1.productquantity1);
                                                                Console.WriteLine("product Amount is " + orderdata1.grandamount);
                                                                Console.WriteLine("product discount is " + orderdata1.discount);
                                                                Console.WriteLine("product grantotal   is " + orderdata1.grandamount);
                                                                Console.WriteLine("order date is " + orderdata1.aDate);
                                                                Console.WriteLine("modify date is " + orderdata1.bDate);


                                                                Console.WriteLine("order 2 details is ");

                                                                Console.WriteLine("employeeNo is - " + employeeNo);
                                                                Console.WriteLine("orderno is " + orderdata.ONo);
                                                                Console.WriteLine("CustomerNo is " + orderdata.Cno);
                                                                Console.WriteLine("productno is " + orderdata.PNO);
                                                                // Console.WriteLine("customer no - " + cd.CustomerNo);
                                                                // Console.WriteLine("customer name - " + cd.customerName);
                                                                //Console.WriteLine("customer address - " + cd.customeraddress);
                                                                //Console.WriteLine("customer city - " + cd.customerCity);
                                                                // Console.WriteLine("customer state - " + cd.customerState);
                                                                // Console.WriteLine("customer country - " + cd.customerCountry);
                                                                //Console.WriteLine("product no - " + pd.productNo);
                                                                // Console.WriteLine("productName - " + pd.productName);
                                                                Console.WriteLine("product price = " + orderdata.productunit);
                                                                Console.WriteLine("product quantity is " + orderdata.productquantity1);
                                                                Console.WriteLine("product Amount is " + orderdata.finalamount);
                                                                Console.WriteLine("product discount is " + discount1);
                                                                Console.WriteLine("product grantotal   is " + orderdata.grandamount);
                                                                Console.WriteLine("order date is " + orderdata.aDate);
                                                                //   Console.WriteLine("modify date is " + orderdata.bDate);
                                                              //  goto nextthing6;





                                                              
                                                            }






                                                        }


                                                        Console.WriteLine("press 1 for add one more order");

                                                        Console.WriteLine("press 2 for show order details or continue ");
                                                        int num = int.Parse(Console.ReadLine());
                                                        if (num == 1)
                                                        {
                                                            order();
                                                            break;
                                                        }
                                                        else
                                                        {




                                                            Console.WriteLine("order details is ");

                                                            Console.WriteLine("employeeNo is - " + employeeNo);
                                                            Console.WriteLine("orderno is " + orderno);
                                                            Console.WriteLine("CustomerNo is " + CustomerNo);
                                                            Console.WriteLine("productno is " + productno);
                                                            Console.WriteLine("customer no - " + cd.CustomerNo);
                                                            Console.WriteLine("customer name - " + cd.customerName);
                                                            Console.WriteLine("customer address - " + cd.customeraddress);
                                                            Console.WriteLine("customer city - " + cd.customerCity);
                                                            Console.WriteLine("customer state - " + cd.customerState);
                                                            Console.WriteLine("customer country - " + cd.customerCountry);
                                                            Console.WriteLine("product no - " + pd.productNo);
                                                            Console.WriteLine("productName - " + pd.productName);
                                                            Console.WriteLine("product price = " + pd.unitprice);
                                                            Console.WriteLine("product quantity is " + productquantity);
                                                            Console.WriteLine("product Amount is " + pd.Amount);
                                                            Console.WriteLine("product discount is " + pd.discount);
                                                            Console.WriteLine("product grantotal   is " + pd.grandtotal);
                                                            Console.WriteLine("order date is " + aDate);
                                                            Console.WriteLine("modify date is " + bDate);










                                                        }



                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("product not found");
                                                        goto next1;
                                                    }









                                                    Console.WriteLine("press 1 for continue");

                                                    Console.WriteLine("press 2 for exit");

                                                    int num1 = int.Parse(Console.ReadLine());
                                                    if (num1 == 1)
                                                    {
                                                        // Console.Clear();
                                                         goto case 1;
                                                       
                                                    }
                                                    else
                                                    {
                                                        goto Nextthing1;

                                                        break;
                                                    }


                                                    break;

                                                case 2:

                                                next3:
                                                    Console.WriteLine("update order");
                                                    Console.WriteLine("Enter  order no");

                                                    // int up = Convert.ToInt32(Console.ReadLine());
                                                    //  product pd1 = objproduct.Find(e => e.productNo == up);

                                                    int Up = Convert.ToInt32(Console.ReadLine());
                                                    order2 od1 = objorder1.Find(e => e.ONo == Up);
                                                    order3 od2 = objorder.Find(e => e.ONo == Up);
                                                    order3 od3 = objorder.Find(e => e.ONo == Up);

                                                    if (od1 != null || od2 != null )
                                                    {
                                                        Console.WriteLine("order no - " + od1.ONo);
                                                        Console.WriteLine("product no - " + od1.PNO);

                                                        Console.WriteLine("product unit price   " + od1.productunit);
                                                        Console.WriteLine("product quantity " + od1.productquantity1);

                                                        Console.WriteLine("product amount " + od1.finalamount);
                                                        Console.WriteLine("product discount " + od1.discount);
                                                        Console.WriteLine("product quantity " + od1.grandamount);
                                                        Console.WriteLine("order date is " + aDate);




                                                        Console.WriteLine("order no - " + od2.ONo);
                                                        Console.WriteLine("product no - " + od2.PNO);

                                                        Console.WriteLine("product unit price   " + od2.productunit);
                                                        Console.WriteLine("product quantity " + od2.productquantity1);

                                                        Console.WriteLine("product amount " + od2.finalamount);
                                                        Console.WriteLine("product discount " + od2.discount);
                                                        Console.WriteLine("product quantity " + od2.grandamount);
                                                        Console.WriteLine("order date is " + aDate);


                                                        Console.WriteLine("you want to update which product ");
                                                        //   Console.WriteLine("1. Yes ");
                                                        // Console.WriteLine("2. No ");

                                                        int up1 = Convert.ToInt32(Console.ReadLine());


                                                        if (up1 != null)
                                                        {

                                                            order2 up2 = objorder1.Find(e => e.PNO == up1);
                                                            order3 up3 = objorder.Find(e => e.PNO == up1);

                                                            // Console.WriteLine("which product you want to update please  type a number  ");

                                                            //  int up2 = Convert.ToInt32(Console.ReadLine());

                                                            if (up2 != null)
                                                            {
                                                                Console.WriteLine(" product 1  ");
                                                                Console.WriteLine("Enter quantity");
                                                                int quan = Convert.ToInt32(Console.ReadLine());

                                                                od1.finalamount = quan * od1.productunit;
                                                                Console.WriteLine("your new amount is " + od1.finalamount);

                                                                Console.WriteLine("Enter discount");
                                                                int dis = Convert.ToInt32(Console.ReadLine());
                                                                Console.WriteLine("your new discount is " + dis);

                                                                od1.grandamount = od1.finalamount - dis;
                                                                Console.WriteLine("your new final amount is " + od1.grandamount);

                                                                goto case 4;

                                                            }
                                                            else if (up3 != null)
                                                            {
                                                                Console.WriteLine(" product 2  ");
                                                                Console.WriteLine("Enter quantity");
                                                                int quan1 = Convert.ToInt32(Console.ReadLine());

                                                                od2.finalamount = quan1 * od2.productunit;
                                                                Console.WriteLine("your new amount is " + od2.finalamount);

                                                                Console.WriteLine("Enter discount");
                                                                int dis1 = Convert.ToInt32(Console.ReadLine());
                                                                Console.WriteLine("your new discount is " + dis1);

                                                                od2.grandamount = od2.finalamount - dis1;
                                                                Console.WriteLine("your new final amount is " + od2.grandamount);




                                                                Console.WriteLine("press 1 for continue");

                                                                Console.WriteLine("press 2 for exit");

                                                                int num4 = int.Parse(Console.ReadLine());
                                                                if (num4 == 1)
                                                                {
                                                                   
                                                                    goto case 1;

                                                                }
                                                                else
                                                                {
                                                                    goto Nextthing1;

                                                                    break;
                                                                }





                                                            }



                                                            else 
                                                            {
                                                                Console.WriteLine("order is not found");
                                                                Console.WriteLine("please enter valid order");
                                                                goto next3;
                                                                break;
                                                            }


                                                        }
                                                   

                                                  
                                                        else
                                                        {
                                                            Console.WriteLine("order is not found");
                                                            Console.WriteLine("please enter valid order");
                                                            goto next3;
                                                            break;
                                                        }




                                                        /*
                                                        Console.WriteLine("press 1 for show order details ");

                                                        Console.WriteLine("press 2 for exit ");
                                                        int num2 = int.Parse(Console.ReadLine());


                                                        if (num2 == 1)
                                                        {

                                                            Console.WriteLine("order no - " + od1.ONo);
                                                            Console.WriteLine("product no - " + od1.PNO);

                                                            Console.WriteLine("product unit price   " + od1.productunit);
                                                            Console.WriteLine("product quantity " + quan);

                                                            Console.WriteLine("product amount " + od1.finalamount);
                                                            Console.WriteLine("product discount " + dis);
                                                            Console.WriteLine("product grandamount " + od1.grandamount);

                                                            Console.WriteLine("order date is " + aDate);
                                                            //Console.WriteLine("modify date is " + bDate);
                                                            Console.WriteLine("modify date is " + cDate.ToString("dd/MM/yyyy"));


                                                            Console.WriteLine("press 1 for continue add new order ");

                                                            Console.WriteLine("press 2 for exit");

                                                            int num3 = int.Parse(Console.ReadLine());
                                                            if (num3 == 1)
                                                            {
                                                                //  Console.Clear();
                                                                goto case 1;

                                                            }
                                                            else
                                                            {

                                                            }

                                                        }*/
                                                      /*  else
                                                        {

                                                            //Console.Clear();
                                                            Console.WriteLine("your order is updated");
                                                            break;
                                                        }*/
                                                    }

                                                    break;

                                                case 3:
                                                    Console.WriteLine("Delete your order");

                                                    Console.WriteLine("enter order No you want to delete");
                                                    int deleteorder = Convert.ToInt32(Console.ReadLine());

                                                    //order2 delete1 = orderdata.
                                                    order2 delete1 = objorder1.Find(e => e.ONo == deleteorder);
                                                    order3 delete2 = objorder.Find(e => e.ONo == deleteorder);
                                                    //Console.WriteLine("order no " + od1.ONo );
                                                    if (delete1 != null || delete2 != null)
                                                    {
                                                        Console.WriteLine("you want to delete order");
                                                        Console.WriteLine("1.Yes");
                                                        Console.WriteLine("2.No");
                                                        int Do = Convert.ToInt32(Console.ReadLine());

                                                        if (Do != null  )
                                                        {
                                                            if (deleteorder != null)
                                                            {
                                                                objorder1.Remove(delete1);
                                                              //  Console.WriteLine("Order is  delete");
                                                              //  Console.WriteLine("1. add order");
                                                              //  Console.WriteLine("2. Update order");
                                                                //Console.WriteLine("3. Delete order");
                                                               // Console.WriteLine("option 4. main menu");
                                                                goto case 4;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            objorder.Remove(delete2);
                                                        }

                                                    }


                                                    else
                                                    {
                                                        Console.WriteLine("Order Not Found ");

                                                        Console.WriteLine("1. add order");
                                                        Console.WriteLine("2. Update order");
                                                        Console.WriteLine("3. Delete order");
                                                        //Console.WriteLine("option 4. main menu");
                                                        break;
                                                    }

                                                    break;


                                                  case 4:
                                                    //Console.WriteLine("option 1. Order Entry");
                                                    //Console.WriteLine("option 2. Last Order Detail");
                                                    //Console.WriteLine("option 3. Last Order's UnitPrice");

                                                    //Console.WriteLine("please select one option's");
                                                   // goto nextthing3;


                                                    return;

                                                    

                                                    break;




                                                default:
                                                    throw new Exception("invalid number");
                                                    Console.WriteLine("choose correct");
                                                    goto Nextthing1;
                                                    Console.WriteLine("1. add order");
                                                    Console.WriteLine("2. Update order");
                                                    Console.WriteLine("3. Delete order");

                                                    System.Threading.Thread.Sleep(myoptions);







                                            }



                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("The Program Has an Error: " + e.Message);

                                            //Console.WriteLine("choose correct option");
                                            //Console.WriteLine("1. add order");
                                            //Console.WriteLine("2. Update order");
                                            //Console.WriteLine("3. Delete order");
                                            goto Nextthing1;




                                        }





                                    }
                                    /* Console.WriteLine("1.continue");
                                     Console.WriteLine("2.main menu");
                                     int con1 = Convert.ToInt32(Console.ReadLine());
                                     if (con1 == 1)
                                     {
                                         goto case (1);
                                     }
                                     // break;

                                     else
                                     {
                                         goto Nextthing6;
                                     }*/

                                    goto nextthing4;
                                    

                                case 2:
                                    Console.WriteLine("Last Order Detail");

                                    Console.WriteLine("add customer no");

                                    try
                                    {



                                        int Up2 = Convert.ToInt32(Console.ReadLine());
                                        order2 od3 = objorder1.Last(e => e.Cno == Up2);
                                        order3 od4 = objorder.Last(e => e.Cno == Up2);
                                        // if (od != null)
                                        // {
                                        Console.WriteLine("order no - " + od3.ONo);
                                        Console.WriteLine("product no - " + od3.PNO);

                                        Console.WriteLine("product unit price   " + od3.productunit);
                                        Console.WriteLine("product quantity " + od3.productquantity1);

                                        Console.WriteLine("product amount " + od3.finalamount);
                                        Console.WriteLine("product discount " + od3.discount);
                                        Console.WriteLine("product quantity " + od3.grandamount);
                                        Console.WriteLine("order date is " + od3.aDate);

                                        Console.WriteLine("order no - " + od4.ONo);
                                        Console.WriteLine("product no - " + od4.PNO);

                                        Console.WriteLine("product unit price   " + od4.productunit);
                                        Console.WriteLine("product quantity " + od4.productquantity1);

                                        Console.WriteLine("product amount " + od4.finalamount);
                                        Console.WriteLine("product discount " + od4.discount);
                                        Console.WriteLine("product quantity " + od4.grandamount);
                                        Console.WriteLine("order date is " + od4.aDate);



                                        //  
                                        Console.WriteLine("press 1 for continue");

                                        Console.WriteLine("press 2 for exit");

                                        int num3 = int.Parse(Console.ReadLine());
                                        if (num3 == 1)
                                        {
                                            // Console.Clear();
                                            goto nextthing2;


                                        }
                                        else
                                        {
                                            Console.Clear();
                                            goto nextthing2;
                                            break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("order is not found");
                                        Console.WriteLine("please first add the order details");
                                        goto case 1;
                                        break;
                                    }


                                    break;
                                case 3:

                                    Console.WriteLine("Last unit price Detail");
                                    Console.WriteLine("add productno  ");



                                    try
                                    {
                                        int Up1 = Convert.ToInt32(Console.ReadLine());
                                       // order2 od1 = objorder1.Find(e => e.PNO == Up1);

                                       // order3 od2 = objorder.Find(e => e.PNO == Up1);

                                        if (Up1 != null)
                                        {
                                            order2 od1 = objorder1.Find(e => e.PNO == Up1);

                                            order3 od2 = objorder.Find(e => e.PNO == Up1);
                                            int up2 = Convert.ToInt32(Console.ReadLine());

                                            if (od1 != null)
                                            {


                                                Console.WriteLine("order number is  = " + od1.ONo);

                                                Console.WriteLine("product price = " + od1.productunit);

                                            }
                                            else if (od2 != null)
                                            {
                                                Console.WriteLine("order number is  = " + od2.ONo);

                                                Console.WriteLine("product price = " + od2.productunit);
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("product not found ");
                                            goto case 1;

                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("lastproduct not found ");
                                        Console.WriteLine("please first add the order details ");
                                        goto case 1;
                                    }




                                    Console.WriteLine("press 1 for continue");

                                    Console.WriteLine("press 2 for exit");

                                    int num2 = int.Parse(Console.ReadLine());
                                    if (num2 == 1)
                                    {
                                        Console.Clear();
                                        goto case 1;


                                    }
                                    else
                                    {
                                        goto nextthing3;
                                        break;
                                    }



                                    break;

                                case 4:

                                    goto nextthing2;
                                    break;


                                default:

                                    Console.WriteLine("choose correct options");



                                    goto nextthing2;



                                    System.Threading.Thread.Sleep(select);





                            }

                            break;




                        }


                        catch (Exception e)
                        {
                            Console.WriteLine("The Program Has an Error: " + e.Message);
                            // System.Threading.Thread.Sleep(intTime);
                            Console.WriteLine("choose correct");
                            goto Nextthings;


                        }
                    default:

                        Console.WriteLine("choose correct option ");




                        goto Nextthings;



                        System.Threading.Thread.Sleep(select);





                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The Program Has an Error: " + e.Message);
                // System.Threading.Thread.Sleep(intTime);
                Console.WriteLine("choose correct");

                goto Nextthings;

            }

        }
    }

}
