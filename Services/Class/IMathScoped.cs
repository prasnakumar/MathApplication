using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Class
{
   public  interface IMathScoped
    {

        public double Add(MathValue value);
        public double Sub(MathValue value);
        public double Multiple(MathValue value);
        public double div(MathValue value);
    }
}
