using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ForLoop
    {
        public static void start()
        {
            Console.WriteLine("Initialize For Loop");

            int length = 10;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("The number of times loop has ran: " + i);
            }
        }
    }
}
