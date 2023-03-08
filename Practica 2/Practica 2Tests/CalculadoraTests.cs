using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void DividirDosNumerosTest()
        {
            // Arrange
            int num1 = 10;
            int num2 = 2;
            int expected = 5;
            Calculadora calculadora = new Calculadora();
            // Act
            int actual =  calculadora.DividirDosNumeros(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}