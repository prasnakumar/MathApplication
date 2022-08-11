using Model;
using System;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMathRepo
    {
        public double Add(MathValue value);
        public double Sub(MathValue value);
        public double Multiple(MathValue value);
        public double div(MathValue value);

    }
}
