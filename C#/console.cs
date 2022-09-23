using System;
class Program
{
    static void Main()
    {
       // Prompting the user
            Console.WriteLine("What is your firstName?");
            // Read the name from console
            string firstName = Console.ReadLine();

            Console.WriteLine("What is yoour secondName?");
            string secondName = Console.ReadLine();

            // concatenate name and greeting
            Console.WriteLine("Hello " + firstName + " " + secondName);
            Console.ReadLine();
    }
}

/*Output 
What is your firstName?
Florence
What is your secondName?
Nyokabi
Hello Florence Nyokabi */
