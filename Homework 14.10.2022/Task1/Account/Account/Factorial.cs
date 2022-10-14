using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Factorial
    {
       



        public static void FactorialNumber(int number)
        {
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {

                fact *= i;

            }

            Console.WriteLine(fact);


        }


    }
}
