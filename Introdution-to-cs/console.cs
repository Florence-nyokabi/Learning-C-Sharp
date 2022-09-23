using System;
class Program
{
    static void Main()
    {
       // Prompting the user
            Console.WriteLine("What is your name?");

            // Read the name from console
            string name = Console.ReadLine();

            // concatenate name and greeting
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
    }
}
