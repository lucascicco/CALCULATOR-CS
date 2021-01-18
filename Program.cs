using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool reStart = true;

            while (reStart)
            {

                PrintColorMessage(ConsoleColor.Yellow, "Bem-vindo(a) ao jogo da calculadora");

                double numberOne = AskForInput("primeiro");
                double numberTwo = AskForInput("segundo");

                double result = Calculation(numberOne, numberTwo);


                PrintColorMessage(ConsoleColor.Green, "Resultado da operação: " + result);

        
                Console.WriteLine("Caso queria jogar novamente digitar 'sim'.");

                string inputAskAgain = Console.ReadLine().Trim().ToLower();

                reStart = inputAskAgain == "sim";

            }

         
        }
        static double AskForInput(string type)
        {

            Console.Write("Digite o {0} número: ", type);

            string input1 = Console.ReadLine();

            double num1 = double.Parse(input1);


            while (!double.TryParse(input1, out num1))
            {
                PrintColorMessage(ConsoleColor.Red, "Por favor, digite um número válido");

                num1 = double.Parse(Console.ReadLine());

                continue;
            }

            return num1;

        }

        static double Calculation(double numberOne, double numberTwo)
        {
            string[] operators = { "+", "-", "*", "/" };

            Console.WriteLine("Digite o operador dessa operação: +, -, *, / ");

            string signalOperator = Console.ReadLine().Trim();

            while (Array.Find(operators, signalOperator.Contains) == null)
            {
                signalOperator = Console.ReadLine().Trim();

                continue;
            }


            string expression = numberOne + signalOperator + numberTwo;

            Console.WriteLine(expression);

            return Eval(expression);

        }

        static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

     
    }
}
