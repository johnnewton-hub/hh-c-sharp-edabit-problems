using System;

namespace CSharpEdabits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Should be true");
            Console.WriteLine(IsLessThan100(12,20));
            Console.WriteLine("Should be false");
            Console.WriteLine(IsLessThan100(12, 200));

            /*
             PROBLEM SOLVING STEPS
            
            1.Understand the problem
                Break down the problem into smaller problem(s) (ATOMIC problems)
                Prioritize your smaller problems
                Confirm understanding with client if possible
                UNDERSTAND EXAMPLE
                //Given two numbers, 
                //return true 
                //if the sum of both numbers is 
                //less than 100.
                //Otherwise return false.
            
            2.Plan a solution
                Prioritize your problems
                Psuedo code should explain clearly how to write the program
                Psuedo code is testable.
                PSUEDO CODE EXAMPLE:
 
                isLessThan100(param1, param2){
                    result = param1 + param2
                    if result < 100
                    return true
                    else
                    return false
                }

            3.Execute the solution
                But what if I don't know how?
                First, you should be able to solve your problem in terms of variables, loops, arrays, and conditions
                Google each little part, one at time.
                https://www.w3schools.com/cs/cs_conditions.asp
                https://csharp.net-tutorials.com/basics/functions/
                https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods

                EXECUTION EXAMPLE: See the IsLessThan100() method
            
            4.Review the solution
                Test solution
                Refactor solution
                Test solution

                REFACTOR EXAMPLE:
                We changed our function from an if(){}else{} syntax to a ternary operator
            */
        }
        private static bool IsLessThan100(int param1, int param2)
        {
            return ((param1 + param2) < 100) ? true : false;           
        }

    }
}
