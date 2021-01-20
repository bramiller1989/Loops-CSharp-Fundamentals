using System;

namespace Loops
{
    class Program
    {
        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
