using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateLoggerApp.Model
{
    class XMLLogger
    {
        public  void XMLLog(string err)
        {
            Console.WriteLine("Logged to  XML Database : " + err);
        }
    }
}
