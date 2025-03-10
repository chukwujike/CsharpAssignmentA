using DBConnectionObject;
using System;

class Program
{
    static void Main()
    {
        var sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
        var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute();

        Console.WriteLine();

        var oracleConnection = new OracleConnection("Server=myOracleServer;Database=myOracleDB;");
        var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
        oracleCommand.Execute();
    }
}
