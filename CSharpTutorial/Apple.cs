using System;
namespace CSharpTutorial
{
    public class Apple : Food
    {
        public Apple()
        {
        }

        public void ShineYourself()
        {
            Console.WriteLine("Squeaky Clean");
        }

        public override void PreserveYourself()
        {
            Console.WriteLine("Be genetically engineered");
        }
    }
}
