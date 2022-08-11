﻿using Model;
using Repository;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class MathServices : IMathServices
    {
        double check1;
        public MathServices()
             
        {
            check1 = check1 + 1;
            Console.WriteLine(check1);
        }
        public double  Add(MathValue value)
        {
            
            double result = value.value1 + value.value2;
          
            return  result;
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
