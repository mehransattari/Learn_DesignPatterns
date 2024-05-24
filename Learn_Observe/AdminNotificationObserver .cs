using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Observe
{
    public class AdminNotificationObserver : IObserver
    {
        public void Update(User user)
        {
            // کد ارسال ایمیل به ادمین
            Console.WriteLine($"Notifying admin of new user registration: {user.Email}");
        }
    }


}
