using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class Calculator
    {
                   
            public static void OP( int num1, int num2, string op)
            { 
               int result = 0;


                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        result = num1 / num2;
                        break;
                }

                Console.WriteLine(result);
            }
          

           
            
         

        

        
     
        

        
        

    }
}
