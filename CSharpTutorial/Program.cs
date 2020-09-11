using System;
using CSharpTutorial.NamespaceExperiement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTutorial
{
    class Program
    {
        public static void Main(string[] args)
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

            InsideNamespace.SayHiFromInsideNamespace();

            string[] strings = { "boat", "basketball", "tennis", "racecar" };
            foreach(string str in strings)
            {
                Console.WriteLine(str);
            }
            Array.Sort(strings);
            foreach(string str in strings) {
                Console.WriteLine(str);
            }

            ArrayList testArrayList = new ArrayList();
            testArrayList.Add(3);
            testArrayList.Add("Summer");
            testArrayList.Add(false);
            PrintValues(testArrayList);
        }

        static void sayHi()
        {
            Console.WriteLine("Hello from sayHi");
        }

        private static void PrintValues(IEnumerable input)
        {
            foreach(Object obj in input)
            {
                Console.WriteLine(obj);
            }
        }

        SortedDictionary<int, bool> sort = new SortedDictionary<int, bool>();
        sort[3] = false;
        

    }


}
