using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTestCSE422.Assignment2
{
    class PushNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Push message: " + message);
        }
    }
}
