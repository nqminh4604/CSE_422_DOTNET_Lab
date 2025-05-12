using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection _instance;

        private static readonly object _lock = new object();
        private DatabaseConnection() { }

        public static DatabaseConnection GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }
    }
}
