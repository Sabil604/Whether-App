using System;
namespace my_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter the City:");
            string city = Console.ReadLine();

            Console.WriteLine($"Fetching data of the {city}...");

            Console.WriteLine("Current temprature: 25° C");
        }
       
    }
}
