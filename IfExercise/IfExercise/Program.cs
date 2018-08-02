using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            //Four();
            //Five();
            Six();
        }

        public static void One()
        {
            Console.WriteLine("give me two numbers.");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 < number2)
            {
                Console.WriteLine("{0} is larger.", number2);
            }
            else if (number1 > number2)
            {
                Console.WriteLine("{0} is larger.", number1);
            }
            else
            {
                Console.WriteLine("these numbers are equal.");
            }
            Console.WriteLine("your welcome.");
            Console.ReadKey();
        }

        public static void Two()
        {
            int myNum = 4;
            Console.WriteLine("guess the number between 1 and 10");
            int userNum = int.Parse(Console.ReadLine());
            if (myNum < userNum)
            {
                Console.WriteLine("your guess is too high.");
                Console.WriteLine("too bad. no prize for you.");
            }
            else if (myNum > userNum)
            {
                Console.WriteLine("your guess is too low.");
                Console.WriteLine("too bad. no prize for you.");
            }
            else
            {
                Console.WriteLine("that's correct.");
                Console.WriteLine("...prize? there's no prize. hahahaha.");
            }
            Console.ReadKey();
        }

        public static void Three()
        {
            Console.WriteLine("enter your final mark");
            int mark = int.Parse(Console.ReadLine());
            if (mark > 100)
            {
                Console.WriteLine("CRAZY!!");
                Console.WriteLine("...that's all I got to say. crazy.");
            }
            else if (mark <= 100 && mark >= 90)
            {
                Console.WriteLine("your Grade is A+.");
                Console.WriteLine("keep up the good work.");
            }
            else if (mark <= 89 && mark >= 80)
            {
                Console.WriteLine("your Grade is A.");
                Console.WriteLine("good job.");
            }
            else if (mark <= 79 && mark >= 70)
            {
                Console.WriteLine("your Grade is B+.");
                Console.WriteLine("nice.");
            }
            else if (mark <= 69 && mark >= 60)
            {
                Console.WriteLine("your Grade is B.");
                Console.WriteLine("not bad. not bad at all.");
            }
            else if (mark <= 59 && mark >= 50)
            {
                Console.WriteLine("your Grade is C.");
                Console.WriteLine("more than half at least.");
            }
            else if (mark <= 100 && mark >= 90)
            {
                Console.WriteLine("your Grade is D.");
                Console.WriteLine("you need to work harder than that.");
            }
            else if (mark <= 100 && mark >= 90)
            {
                Console.WriteLine("your Grade is F.");
                Console.WriteLine("is that the bast you can do? I don't think so.");
            }
            else
            {
                Console.WriteLine("...what have you done?");
            }
            Console.ReadKey();
        }

        public static void Four()
        {
            Console.WriteLine("give me a number");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("your number is even.");
            }
            else {
                Console.WriteLine("your number is odd.");
            }
            Console.WriteLine("...am i right?");
            Console.ReadKey();
        }

        public static void Five()
        {
            Console.WriteLine("enter your new pin number (from 1000 to 9999).");
            int pin = int.Parse(Console.ReadLine());
            if(pin >= 1000 && pin <= 9999)
            {
                Console.WriteLine("enter the pin again.");
                int pinCheck = int.Parse(Console.ReadLine());
                if(pinCheck == pin)
                {
                    Console.WriteLine("yur pin has been set.");
                    Console.WriteLine("congratulations.");
                }
                else
                {
                    Console.WriteLine("your pin numbers did not match. your pin was not set.");
                    Console.WriteLine("it's just four numbers. how did you mess it up?");
                }
            }
            else
            {
                Console.WriteLine("this pin number is not within the right parameters");
                Console.WriteLine("i said from 1000 to 9999. which part of that did you not understand?");
            }

            Console.ReadKey();
        }

        public static void Six()
        {
            Console.WriteLine("think of a 3 letter palindrome");
            Console.WriteLine("enter the first letter in lower case");
            string first = Console.ReadLine();
            Console.WriteLine("enter the second letter in lower case");
            string second = Console.ReadLine();
            Console.WriteLine("enter the third letter in lower case");
            string third = Console.ReadLine();

            if(second != "a" && second != "e" && second != "i" && second != "o" && second != "u")
            {
                Console.WriteLine("it's not an acutual word");
            }
            else
            {
                if(first == third)
                {
                    Console.WriteLine("it's a palindrome.");
                    Console.WriteLine("well done.");
                    Console.WriteLine("good job.");
                    Console.WriteLine("*clapping hands");
                    Console.WriteLine("it is indeed a palindrome.");
                    Console.WriteLine("that's good.");
                }
                else
                {
                    Console.WriteLine("hey Siri, what does palindrome mean?");
                }
            }

            Console.ReadKey();
        }
    }
}
