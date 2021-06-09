using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite yellow-colored, boomerang-shaped fruit with a peel?!");
            var fruit = Console.ReadLine();
            Console.WriteLine($"Nana, nana, bo-bana, banana-fana fo-fana, fee-fi-mo-mana, {fruit}!");
        }
    }
}
