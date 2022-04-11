using System;

namespace Calculator
{
    public class CalculatorApp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(" Type [1] for Addition \n Type [2] for Addition of Arrays \n Type [3] for Subtraction \n Type [4] for Subtraction of Arrays \n Type [5] for Multiplication \n Type [6] for Division \n 0: [Exit] \n Please enter the option of your mathematical operator: ");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Add1();
                        break;
                    case "2":
                        AddArray();
                        break;
                    case "3":
                        Sub1();
                        break;
                    case "4":
                        SubArray();
                        break;
                    case "5":
                        Multip1();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "6":
                        Div1();
                        break;
                }
            }  
        }
        public static void Add1()
        {
            Console.Write(" Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write(" Pleas enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            var result = Calculator.Add(num1, num2);
            Console.WriteLine(result);

        }
        public static void AddArray()
        {
            Console.Write(" Please enter five numbers: ");
            double[] answer = new double[5];
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = double.Parse(Console.ReadLine());
                }
                double result = Calculator.Add(answer);
                Console.WriteLine(result);
                
        }
        public static void Sub1()
        {
            Console.Write(" Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write(" Pleas enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            var result = Calculator.Sub(num1, num2);
            Console.WriteLine(result);
        }
          public static void SubArray()
        {
            Console.Write(" Please enter five numbers: ");
            double[] answer = new double[5];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = double.Parse(Console.ReadLine());
            }
            double result = Calculator.Sub(answer);
            Console.WriteLine(result);
        }
        public static void Multip1()
        {
            Console.Write(" Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write(" Pleas enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            var result = Calculator.Multi(num1, num2);
            Console.WriteLine(result);
        }
        public static void Div1()
        {
            Console.Write(" Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write(" Pleas enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            var result = Calculator.Div(num1, num2);
            if ((num1 == 0) | (num2 == 0))
            {
                Console.WriteLine(" You cannot divide by Zero ");
                Div1();
            }
            else

                Console.WriteLine(result);

        }
    }
 }

