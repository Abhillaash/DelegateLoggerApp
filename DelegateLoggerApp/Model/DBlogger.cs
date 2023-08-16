using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateLoggerApp.Model
{
    class DBlogger
    {
        public  void DBLog(string err)
        {
            Console.WriteLine("Logged to  Database : " + err);
        }
    }
}
