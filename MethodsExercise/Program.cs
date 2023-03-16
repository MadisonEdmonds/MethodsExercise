using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello- What is your first name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine($"Hi, {userName}. How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine($"How many dogs do you have?");
            //string userDogNumber = Console.ReadLine();

            //Console.WriteLine($"Cool! What kind of dog do you have?");
            //string userDogBreed = Console.ReadLine();


            //Console.WriteLine($"There was a lady named {userName}, and she was {age} years old.");
            //Console.WriteLine($"She had {userDogNumber} dog and it was a {userDogBreed}.");
            //Console.WriteLine($"{userName} only wants {userDogNumber} dog but wishes she would have bought another breed besides a {userDogBreed}.");

            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one.");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is {product}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
        

}
