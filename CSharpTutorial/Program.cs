using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Book seveneves = new Book("Seveneves", "Neil Stephenson", 893);
            Console.WriteLine(seveneves.GetTitle()); 
        }

    static void sayHi()
    {
        Console.WriteLine("Hello from sayHi");
    }

    }


}
