using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You did NOT enter your name!");
            } 
            else {
                Console.WriteLine("Hello, " + name + " to the program");
            }
        

        }
    }
}
