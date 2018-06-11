using System;

namespace FuzzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FuzzBuzzClass fzclass = new FuzzBuzzClass();
            fzclass.PrintOut(100);
            Console.ReadLine();
        }
    }

    class FuzzBuzzClass
    {
       public void PrintOut(int N)
        {
            for(int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
