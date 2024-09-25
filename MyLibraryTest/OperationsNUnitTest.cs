using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void add_InputNumbers_Return_Number()
        {
            // 1. Arrange
            //Operations operations = new Operations();
            //Operations operations = new();
            var operations = new Operations();
            // 2. Act
            int num1 = 2;
            int num2 = 5;
            int resultadoEsperado = 7;
            int result = operations.add(num1, num2);
            // 3. Assert
            Assert.That(result, Is.EqualTo(resultadoEsperado));
        }
        [Test]
        [TestCase(10,ExpectedResult=true)]
        [TestCase(11, ExpectedResult = false)]
        [TestCase(14, ExpectedResult = true)]
        public void isEven_InputNumber_ReturnTrue(int number)
        {
            // 1. Arrange 
            Operations operations = new Operations();
            //int number = 11;
            var resultado = operations.isEven(number);
            Assert.That(resultado, Is.True);
        }

        [Test]
        [TestCase(2.2,1.2)]
        //[TestCase(2.23, 1.24)]
        public void addDecimal_InputDoublenumbers_ReturnsDoublNumber(double num1, double num2)
        {
            Operations operations = new Operations();
            double result = operations.addDecimal(num1, num2);
            Assert.That(result, Is.EqualTo(3.4).Within(0.1));
            
        }
    }
}
