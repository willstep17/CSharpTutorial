using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Book seveneves = new Book("Seveneves", "Neil Stephenson", 893);
            Console.WriteLine(seveneves.GetTitle());
            Console.WriteLine(seveneves.IsLong());
            Console.WriteLine(Book.GetNumberOfBooks());

            Food food = new Food();
            Apple apple = new Apple();
            food.CookYourself();
            apple.CookYourself();
            apple.ShineYourself();
            food.PreserveYourself();
            apple.PreserveYourself();
        }

    static void sayHi()
    {
        Console.WriteLine("Hello from sayHi");
    }

    }


}
