using System;
using Xunit;
using SimpleCalculator;
using System.Collections.Generic;
using System.Linq;



namespace SimpleCalculator.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void MakeEquation_FirstNum_IsTrue()
        {
            var calculator = new Calculator();
            //Arrange
            var inputEquation = "10 + 3";

            //Act
            calculator.MakeEquation(inputEquation);
            var firstNum = calculator.FirstNumber;

            //Assert
            Assert.Equal(10, firstNum);
        }


        [Fact]
        public void MakeEquation_Operator_IsTrue()
        {
            var calculator = new Calculator();

            //Arrange
            var inputEquation = "10 + 3";

            //Act
            calculator.MakeEquation(inputEquation);
            var operatr = calculator.Operator;

            //Assert
            Assert.Equal("+", operatr);
        }

        [Fact]
        public void MakeEquation_SecondNum_IsTrue()
        {
            var calculator = new Calculator();
            //Arrange
            var inputEquation = "10 + 3";

            //Act
            calculator.MakeEquation(inputEquation);
            var secondNum = calculator.SecondNumber;

            //Assert
            Assert.Equal(3, secondNum);
        }

        [Fact]
        public void MakeEquation_FirstNum_ThrowsException()
        {
            var calculator = new Calculator();
            //Arrange
            var inputEquation = "? + 3";

            //Assert
            Assert.Throws<Exception>(() => calculator.MakeEquation(inputEquation));
           
        }

        [Fact]
        public void MakeEquation_Operator_ThrowsException()
        {
            var calculator = new Calculator();
            var inputEquation = "10 ? 3";

            Assert.Throws<Exception>(() => calculator.MakeEquation(inputEquation));
        }
    }    
}
