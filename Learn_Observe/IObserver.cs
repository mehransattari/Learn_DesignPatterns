using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Observe
{
    public interface IObserver
    {
        void Update(User user);
    }


}
