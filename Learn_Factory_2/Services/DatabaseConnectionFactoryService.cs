using Learn_Factory_Method.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Factory_Method.DTO;

namespace Learn_Factory_Method.Services
{
    public class DatabaseConnectionFactoryService : IDatabaseConnectionFactoryService
    {
        public IDatabaseConnection CreateConnection(string connectionString, DataBaseEnum dbType)
        {
            switch (dbType)
            {
                case DataBaseEnum.sqlserver:
                    return new SqlConnection(connectionString);

                case DataBaseEnum.mysql:
                    return new MySqlConnection(connectionString);

                case DataBaseEnum.postgresql:
                    return new PostgreSqlConnection(connectionString);

                default:
                    throw new ArgumentException("Invalid database type.");
            }
        }
    }

}
