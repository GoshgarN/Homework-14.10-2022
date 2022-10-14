using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Account
    {
        public static void Login(string username, string password)
        {
            if (username==null || password==null)
            {
                Console.WriteLine("Please enter your username and password");
            }
            else if (username != "Cavid123" || password != "cavid1993")
            {
                Console.WriteLine("Incorrect username and password");
            }
            else
            {
                Console.WriteLine("You are logged in as" + username);
            }

            

        }

        
    }
}
