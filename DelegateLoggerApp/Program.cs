using System;
using DelegateLoggerApp.Model;

namespace DelegateLoggerApp
{
    


    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator(10000, 2,TaxCalculator.DBLogger);
            Console.WriteLine(taxCalculator.CalculateTax());
        }
    }
}
