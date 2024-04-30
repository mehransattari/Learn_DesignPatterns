using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Factory_Method.Repository
{
    public class MySqlConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public MySqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            // کد برای اتصال به دیتابیس MySql
            Console.WriteLine("Connected to MySql");
        }

        public void Disconnect()
        {
            // کد برای قطع اتصال از دیتابیس MySql
            Console.WriteLine("Disconnected from MySql");
        }
    }




}
