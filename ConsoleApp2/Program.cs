using System;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            {
                int i, fact = 1, n;
                Console.Write("Enter any Number: ");
                n = int.Parse(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("Factorial of " + n + " is: " + fact);

                function(fact);


            }
            static void function(int fact)
            {

                if (fact % 2 == 0)
                {
                    Console.WriteLine("it is a even");
                }
                else
                {
                    Console.WriteLine("it i not even");
                }
            }
            

        }
    }
}
