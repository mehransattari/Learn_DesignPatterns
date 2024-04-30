using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Factory_Method.Repository
{
    public class SqlConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            // کد برای اتصال به دیتابیس SQL Server
            Console.WriteLine("Connected to SQL Server");
        }

        public void Disconnect()
        {
            // کد برای قطع اتصال از دیتابیس SQL Server
            Console.WriteLine("Disconnected from SQL Server");
        }
    }


}
