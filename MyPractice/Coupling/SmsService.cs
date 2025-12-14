using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Coupling
{
    internal class SmsService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
