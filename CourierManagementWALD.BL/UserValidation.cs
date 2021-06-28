using CourierManagementWALD.DL;
using System;
using System.Collections.Generic;

namespace CourierManagementWALD.BL
{
    public class UserValidation
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("Wald","09012000")
        };

        public void LogIn()
        {
            UserCatalouge catalouge = new UserCatalouge();
            bool successful = false;
            Console.WriteLine("\nEnter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("\nEnter Password:");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("\n\tYou've Login Successfully!\n\n");
                    successful = true;
                    catalouge.Catalouge();
                    
                }
            }
            if (!successful)
            {
                Console.WriteLine("\nApp will exit....");
                Console.ReadKey();
            }
        }
        public void Register()
        {
            Console.WriteLine("\nEnter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nEnter password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("\nRegistered Successfully!");

            foreach (User user in UserCredentials)
            {
                Console.WriteLine("\nUsername:{0}, \tPassword:{1}\n", user.UserName, user.PassWord);
            }

        }

    }
}
