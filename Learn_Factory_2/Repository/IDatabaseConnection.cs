using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Factory_Method.Repository
{
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
    }
}
