﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionObject
{
    // Derived class for Oracle connection
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle database connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle database connection...");
        }
    }
}
