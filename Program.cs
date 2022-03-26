using System;

namespace LearUdemy04
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 0;
            int age = 30; //чтобы проверить doWhile

            while (age < 18)
            {
                Console.WriteLine("While!!!");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("doWhile!!!");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            Console.WriteLine("Good!");

           /* int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
            Console.ReadLine();
*/
        }
    }
}
