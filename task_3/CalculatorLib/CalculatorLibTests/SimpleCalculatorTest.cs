using System;
using Xunit;
using CalculatorLib;
using System.Collections.Generic;

namespace CalculatorLibTests
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void SimpleCalculator_Calculate_AdditionOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new List<IOperation>
            {
                new AdditionOperation()
            };

            SimpleCalculator calculator = new SimpleCalculator(operations);

            //Act

            int result = calculator.Calculate("2+2");

            //Assert

            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleCalculator_Calculate_SubtractionOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new List<IOperation>
            {
                new SubtractionOperation()
            };

            SimpleCalculator calculator = new SimpleCalculator(operations);

            //Act

            int result = calculator.Calculate("2-2");

            //Assert

            Assert.Equal(0, result);
        }

        [Fact]
        public void SimpleCalculator_Calculate_MultiplicationOperation_Calculated()
        {
            //Arrange

            List<IOperation> operations = new List<IOperation>
            {
                new MultiplicationOperation()
            };

            SimpleCalculator calculator = new SimpleCalculator(operations);

            //Act

            int result = calculator.Calculate("5*2");

            //Assert

            Assert.Equal(10, result);
        }
    }
}
