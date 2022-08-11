using System;

namespace MethodExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"hi {name}, tell me a couple of things about yourself...");
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite TV show?");
            string favShow = Console.ReadLine();
            Console.WriteLine($"Well {name} I must say that {favColor} is not a bad color at all and I think I will have to give {favShow} a watch sometime.");

            Console.WriteLine("Type a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            Console.WriteLine("Type a number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a number to multiply by:");
            int y = int.Parse(Console.ReadLine());
            int product = Product(x, y);
            Console.WriteLine($"The product of {x} and {y} is {product}");

        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Product(int x, int y)
        {
            return x * y;
        }
    }
}
