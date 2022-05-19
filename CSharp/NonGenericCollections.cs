using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class NonGenericCollections
    {
        public static void start()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName","user");
            table.Add("Password", "passcode123");
            table.Add("Button", "Submit");

            foreach (var key in table.Keys)
            {
                Console.WriteLine("The Value for " + key + "is : " + table[key]);
            }
        }
    }
}
