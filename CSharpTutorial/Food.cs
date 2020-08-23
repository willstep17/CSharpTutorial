using System;
namespace CSharpTutorial
{
    public class Food
    {
        public Food()
        {
        }

        public void CookYourself()
        {
            Console.WriteLine("Sizzle");
        }
        public virtual void PreserveYourself()
        {
            Console.WriteLine("Generically store yourself");
        }
    }
}
