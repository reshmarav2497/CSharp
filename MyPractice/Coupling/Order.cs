using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Coupling
{
    internal class Order
    {
        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Order has been placed.");
            _notificationService.SendNotification("Your order has been placed.");
        }
    }
}
