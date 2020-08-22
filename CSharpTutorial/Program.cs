using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "this is a phrase";
            char a = 'a';
            int firstInt = 5342;
            int[] luckyNumbers = { 17, 55, 33, 1111 };
            foreach (int i in luckyNumbers)
            {
                Console.WriteLine(i);
            }
            firstInt = 3;
            Console.WriteLine("ReBuildAllCommand: Ctrl-Command-B");
            Console.WriteLine(firstInt);
            Console.WriteLine("Hello World?");
            Console.WriteLine("  /");
            Console.WriteLine(" /");
            Console.WriteLine("/");
            Console.WriteLine("Hello World!");
        }
    }
}
