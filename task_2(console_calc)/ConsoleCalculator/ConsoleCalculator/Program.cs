using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            string operand1String;
            string operand2String;

            int operand1 = 0;
            int operand2 = 0;
            int result = 0;

            Console.WriteLine("Введите операцию: ");
            operation = Console.ReadLine();

            Console.WriteLine("Введите первый операнд: ");
            operand1String = Console.ReadLine();
            Console.WriteLine("Введите второй операнд: ");
            operand2String = Console.ReadLine();

            try
            {
                operand1 = Convert.ToInt32(operand1String);
            } catch
            {
                Console.WriteLine("Неверный первый операнд");
                return;
            }

            try
            {
                operand2 = Convert.ToInt32(operand2String);
            } catch
            {
                Console.WriteLine("Неверный второй операнд");
                return;
            }
            switch (operation)
            {
                case "+":
                        {
                            result = operand1 + operand2;
                            break;
                        }
                    case "-":
                        {
                            result = operand1 - operand2;
                            break;
                        }
                    case "*":
                        {
                            result = operand1 * operand2;
                            break;
                        }
                    case "/":
                        {
                            try
                        {
                            result = operand1 / operand2;
                        } catch (DivideByZeroException e)
                        {
                            Console.WriteLine("Деление на ноль");
                            return;
                        }
                            break;
                        }
            }
            Console.WriteLine("Результат - " + result);
        }
    }
}
