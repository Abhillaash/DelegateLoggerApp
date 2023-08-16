using System;
using DelegateLoggerApp.Model;

namespace DelegateLoggerApp
{
    


    class Program
    {
        static void Main(string[] args)
        {
            DBlogger dBlogger = new DBlogger();
            TaxCalculator taxCalculator = new TaxCalculator(10000, 2,dBlogger.DBLog);
            Console.WriteLine(taxCalculator.CalculateTax());

            XMLLogger xMLLogger = new XMLLogger();
            TaxCalculator taxCalculator1 = new TaxCalculator(10000, 2, xMLLogger.XMLLog);
            Console.WriteLine(taxCalculator1.CalculateTax());


        }
    }
}
