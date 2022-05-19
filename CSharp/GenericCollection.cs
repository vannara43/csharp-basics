using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class GenericCollection
    {
        public static void start()
        {
            //Types of generic collection:
            //- List<>
            //- Dictionary<Tkey,TValue>
            //- Stack<T> etc...

            string[] user1 = new string[] { "Jackie", "20", "jackieemail@email", "21324", };
            string[] user2 = new string[] { "Kim", "20", "kimloop@email", "64343", };
            string[] user3 = new string[] { "Megan", "20", "megsack@email", "34222", };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                Console.WriteLine(value.Key);

                string[] usersInfo = value.Value;

                foreach (var user in usersInfo)
                {
                    Console.WriteLine(user);
                }

            }
        }
    }
}
