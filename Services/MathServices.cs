using Model;
using Repository;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class MathServices : IMathRepo
    {
        public double  Add(MathValue value)
        {
            double result = value.value1 + value.value2;
            return  result;
        }

        public double div(MathValue value)
        {
            double result = value.value1 / value.value2;
            return result;
        }

        public double Multiple(MathValue value)
        {
            double result = value.value1 * value.value2;
            return result;
        }

        public double Sub(MathValue value)
        {
            double result = value.value1 - value.value2;
            return result;
        }
    }
}
