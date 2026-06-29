using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
            {
                Console.WriteLine("you can vote");
            } else
            {
                Console.WriteLine("you are still young to vote");
            }

        }
    }
}
