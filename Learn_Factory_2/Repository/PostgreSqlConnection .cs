using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Factory_Method.Repository
{
    public class PostgreSqlConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public PostgreSqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            // کد برای اتصال به دیتابیس PostgreSql
            Console.WriteLine("Connected to PostgreSql");
        }

        public void Disconnect()
        {
            // کد برای قطع اتصال از دیتابیس PostgreSql
            Console.WriteLine("Disconnected from PostgreSql");
        }
    }




}
