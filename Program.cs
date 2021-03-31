using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            var age = int.Parse(Console.ReadLine());
            if (age > 20){
                Console.WriteLine("You can drink!");
            }
            else{
                Console.WriteLine("Sorry, no drinks for you!");
            }

        }
    }
}
