using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //One();
            //Two();
            Three();
        }

        public static void One()
        {
            Console.WriteLine("what's my favourite type of pet?");
            string fav = Console.ReadLine();
            switch (fav)
            {
                case "cats":
                    Console.WriteLine("correct");
                    break;

                case "dogs":
                case "birds":
                case "fish":
                case "hamsters":
                    Console.WriteLine("incorrect");
                    break;

                default:
                    Console.WriteLine("NO");
                    break;
            }
            Console.ReadKey();
        }

        public static void Two()
        {
            Console.WriteLine("what do you want?");
            string fruit = Console.ReadLine().ToLower();
            switch (fruit)
            {
                case "apples":
                    Console.WriteLine($"{fruit} is $1.25/kg");
                    break;

                case "bananas":
                    Console.WriteLine($"{fruit} is $3.15/kg");
                    break;

                case "kiwifruit":
                    Console.WriteLine($"{fruit} is $4.65/kg");
                    break;

                case "oranges":
                    Console.WriteLine($"{fruit} is $2.75/kg");
                    break;

                default:
                    Console.WriteLine("NO");
                    break;
            }
            Console.ReadKey();
        }

        public static void Three()
        {
            Console.WriteLine("give me two numbers.");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("what do you want me to do with these? (+ - * /)");
            string operation = Console.ReadLine();
            int answer = 0;
            bool answered = true;
            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    break;

                case "-":
                    answer = number1 - number2;
                    break;

                case "*":
                    answer = number1 * number2;
                    break;

                case "/":
                    answer = number1 / number2;
                    break;

                default:
                    Console.WriteLine("type +, -, * or /.");
                    answered = false;
                    break;
            }

            if (answered == true)
            {
                Console.WriteLine($"{number1} {operation} {number2} is {answer}");
                Console.WriteLine("your welcome.");
            }
            Console.ReadKey();
        }
    }
}
