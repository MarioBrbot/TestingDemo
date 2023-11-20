using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5.25, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected) 
        {
         

            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        
        
        }


    }
}
