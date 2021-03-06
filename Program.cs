using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For additinon press '+'");
            Console.WriteLine("For Substraction press '-'");
            Console.WriteLine("For Division press '/'");
            Console.WriteLine("For Multiplication press '*'");

            Console.WriteLine("Enter a  first numb : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second numb : ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is your calculation press enter : ");
            char process = Convert.ToChar(Console.ReadLine());
            if (number1 > number2 && number1 % 5 == 0 && number2 > 0)
            {
                double? result = Calculate(number1, number2, process);
                if (result.HasValue)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("İşlem yok");
                }
            }
            else
            {
                if (number1 < number2)
                {
                    Console.WriteLine("A>b olmalı");
                }

                if (number1 % 5 != 0)
                {
                    Console.WriteLine("a 5 e bölünmeli");
                }

                if (number2 < 0)
                {
                    Console.WriteLine("b 0 dan büyük olmalı");
                }
            }

        }


        static double? Calculate(int num1, int num2, char process)
        {
            double? result = null;
            // Buraya girerse 3 koşulda doğru  
            if (process == '+')
            {
                result = AdditionCalculate(num1, num2);
            }
            else if (process == '-')
            {
                result = SubstractionCalculate(num1, num2);
            }
            else if (process == '/')
            {
                result = DivisionCalculate(num1, num2);
            }
            else if (process == '*')
            {
                result = MultiplicationCalculator(num1,num2);
            }

            return result;
        }

        static double AdditionCalculate(int num1, int num2)
        {
            return num1 + num2;
        }
        static double SubstractionCalculate(int num1, int num2) => num1 - num2;


        static double DivisionCalculate(int num1, int num2)
        {
            return num1 / num2;
        }
        static double MultiplicationCalculator(int num1, int num2)
        {
            return num1 * num2;
        }

    }





}
