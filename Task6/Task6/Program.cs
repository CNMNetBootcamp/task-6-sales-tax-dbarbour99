using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            double ordertotal = 0;
            double statetax = 0.05;
            double localtax = 0.03;
            double statetaxamount = 0;
            double localtaxamount = 0;
            double grandtotal = 0;
            bool isNumeric = false;
            string tempnum = string.Empty;

            //input
            do
            {
                Console.WriteLine("What is the order total?");
                tempnum = Console.ReadLine();
                isNumeric = double.TryParse(tempnum, out double n);
                if (isNumeric == false || double.Parse(tempnum) <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }

            } while (isNumeric == false);
            ordertotal = double.Parse(tempnum);

            //processing
            statetaxamount = gettax(ordertotal, statetax);
            localtaxamount = gettax(ordertotal, localtax);
            grandtotal = ordertotal + statetaxamount + localtaxamount;

            //output
            Console.WriteLine("Order amount: " + ordertotal);
            Console.WriteLine("State tax:    " + statetaxamount);
            Console.WriteLine("Local tax:    " + localtaxamount);
            Console.WriteLine("--------------------");
            Console.WriteLine("Grand total:  " + grandtotal);
            Console.ReadLine();

        }
        // TODO: Make sure to use public 
        static double gettax(double ordertotal,double taxrate)
        {
            return ordertotal * taxrate;
        }
    }
}

