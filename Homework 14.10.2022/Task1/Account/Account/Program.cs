using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number = 5;

            //Factorial.FactorialNumber(number);




            //string username = "Cavid123";
            //string password = "cavid1993";


            //Account.Login(username, password);

            



            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            Calculator.OP(num1, num2, op);














        }
    }
}
