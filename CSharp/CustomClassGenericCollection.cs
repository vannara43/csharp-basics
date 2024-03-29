﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class CustomClassGenericCollection
    {
        public static void start()
        {
            List<User> users = new List<User>();
            users.Add(new User {UserID = 1, Name = "Alex", Age = 10, Email = "hisemail@email.com", Phone = 213214122 });
            users.Add(new User { UserID = 2, Name = "Becca", Age = 20, Email = "hisemail@email.com", Phone = 213214122 });
            users.Add(new User { UserID = 3, Name = "Charlie", Age = 30, Email = "hisemail@email.com", Phone = 213214122 });

            foreach (var user in users)
            {
                Console.WriteLine(String.Format("The User {0} with age {1} has email {2} and phone {3}", user.Name, user.Age, user.Email, user.Phone));
            }


        }
    }
}
