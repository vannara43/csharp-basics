using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Arrays
    {
        //Arrays can hold any number of data in it
        //ForEach is handy when working with collections

        public static void start() { 

            int[] testcaseid = new int[] {101,102,103,104};

            for (int i = 0; i < testcaseid.Length; i++)
			{
                Console.WriteLine(testcaseid[i]);
			}

            string[] testcaseName = new string[] { "James", "Daniel", "Oscar" };
            foreach (var testcase in testcaseName)
            {
                Console.WriteLine(testcase);
            }

        }


    }
}
