using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
