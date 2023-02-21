using System;

namespace Vyrobnycha_21._02._2023_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Task1();
            //Task2();
            Task3();
        }
        static void Task1()
        {
            Console.WriteLine("Enter your number: ");
            string number = Console.ReadLine();
            Console.WriteLine(number);
            if (number==null)
            {
                Console.WriteLine("You haven`t written a number!");
            }
            switch(number.Length)
            {
                case 1:
                    Console.WriteLine("Number from 1 sumbol");
                    break;
                case 2:
                    if (number[0]==number[1])
                    {
                        Console.WriteLine("Yes, this number is a palindrome.");
                    }       
                    else
                    {
                        Console.WriteLine("No, this number is not a palindrome.");
                    }
                    break;
                default:
                    bool a = true;
                    for (int i = 0; i < number.Length/2; i++)
                    {
                        if (number[i]!=number[number.Length-i-1])
                        {
                            Console.WriteLine("No, this number is not a palindrome.");
                            a = false;
                            break;
                        }
                        
                    }
                    if (a==true)
                        {
                            Console.WriteLine("Yes, this number is a palindrome.");
                        }
                    break;
            }
        }
        static void Task2()
        {
            Console.WriteLine("Enter your numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            double a = (Math.Pow(x * z, 2) / 1) + (Math.Pow(x * z, 4) / 6) + (Math.Pow(x * z, 6) / 125);
            double b = Math.Pow(Math.Cos(Math.PI / 5 + Math.Pow(y, 3)), 2) - 2 * Math.Sin(Math.PI / 5 + Math.Pow(y, 3));
            double c = Math.Sqrt(x * x + y * y + z * z);
            double min_a2_b = Math.Min(a * a, b);
            double answer = Math.Pow(Math.Min(min_a2_b, c * c * c), 3);
            double rounded_answer = Math.Round(answer);
            Console.WriteLine($"Your answer: {answer}; Rounded answer: {rounded_answer}");
        }
        static void Task3()
        {

        }
    }
}
