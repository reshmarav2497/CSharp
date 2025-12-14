using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Coupling
{
    internal class EmailService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
