using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateLoggerApp.Model
{
    delegate void DLoggerDelegate(string err);
    class TaxCalculator
    {
        
         
        public TaxCalculator(int amount, int rate,DLoggerDelegate ob)
        {
            Amount = amount;
            Rate = rate;
            dLoggerDelegate = ob;

            
        }

        public int Amount { get; set; }
        public int Rate { get; set; }

        DLoggerDelegate dLoggerDelegate;
        //DLoggerDelegate ob = DBLogger;
        //ob += XMLLogger;
        
        



        //public DBLogger DBLogger { get; set; }

        public int CalculateTax()
        {
            int tax = 0;
            try
            {

                tax = Amount * Rate / 0;
            }
            catch (Exception ex)
            {

                //DBLogger.Log("Divided by zero");
                dLoggerDelegate("Divided by zero");


            }
            return tax;
        }
        //public static void DBLogger(string err)
        //{
        //    Console.WriteLine("Logged to  Database : " + err);
        //}
        //public static void XMLLogger(string err)
        //{
        //    Console.WriteLine("Logged to  XML Database : " + err);
        //}
    }
}
