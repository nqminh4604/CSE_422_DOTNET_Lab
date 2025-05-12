using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCSE422.Assignment2
{
    class NotificationSender
    {
        private readonly INotification _notification;

        public NotificationSender(INotification notification)
        {
            _notification = notification;
        }

        public void sendMessage(string message)
        {
            _notification.SendNotification(message);
        }
    }
}
