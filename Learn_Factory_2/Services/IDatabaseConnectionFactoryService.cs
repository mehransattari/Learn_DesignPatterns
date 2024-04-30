using Learn_Factory_Method.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Factory_Method.DTO;

namespace Learn_Factory_Method.Services
{
    public interface IDatabaseConnectionFactoryService
    {
        IDatabaseConnection CreateConnection(string connectionString, DataBaseEnum dbType);
    }
}
