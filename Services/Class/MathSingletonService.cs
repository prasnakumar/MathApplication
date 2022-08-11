using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Class
{
   public  class MathSingletonService :IMathSingleton
    {
        public MathSingletonService()
        {
            Console.WriteLine("SingletonService");
        }
        public double Add(MathValue value)
        {

            double result = value.value1 + value.value2;

            return result;
        }

        public double div(MathValue value)
        {
            double result;
            result = value.value1 / value.value2;
            if (double.IsNaN(result))
            {
                throw new DivideByZeroException();

            }
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
