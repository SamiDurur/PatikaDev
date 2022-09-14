using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler
{
    public class DatabaseLoger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}
