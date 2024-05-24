using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Observe
{
    public class WelcomeEmailObserver : IObserver
    {
        public void Update(User user)
        {
            // کد ارسال ایمیل خوشامدگویی
            Console.WriteLine($"Sending welcome email to {user.Email}");
        }
    }


}
