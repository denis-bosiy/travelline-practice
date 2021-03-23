using System;
using System.Collections.Generic;
using CalculatorLib;

namespace Lw3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOperation> operations = new List<IOperation>
            {
                new AdditionOperation(),
                new MultiplicationOperation(),
                new SubtractionOperation()
            };
            ICalculator calculator = new SimpleCalculator(operations);
            Console.WriteLine(calculator.Calculate("1+3"));
            Console.ReadLine();
        }
    }
}
