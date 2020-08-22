using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(3, 5));
            Console.WriteLine("new");
        }

    static void sayHi()
    {
        Console.WriteLine("Hello from sayHi");
    }

    }


}
