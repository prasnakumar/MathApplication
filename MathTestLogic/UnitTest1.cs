using Model;
using Services;
using System;
using Xunit;

namespace MathTestLogic
{
    public class UnitTest1
    {
        MathServices math = new MathServices();
        MathValue value = new MathValue() { value1 = 10, value2 = 20 };
        [Fact]
        public void Add()
        {
            Assert.Equal(30, math.Add(value));
        }
        [Fact]
        public void Sub()
        {
            Assert.Equal(-10, math.Sub(value));

        }
        [Fact]
        public void Multiple()
        {
            Assert.Equal(200, math.Multiple(value));
        }
        [Fact]
        public void Div()
        {
            Assert.Equal(0.5, math.div(value));
        }
        [Fact]
        public void DivByZero()
        {
            MathValue value1 = new MathValue() { value1 = 0, value2 = 0 };
        
            Assert.Throws<DivideByZeroException>(()=> math.div(value1));
        }
    }
}
