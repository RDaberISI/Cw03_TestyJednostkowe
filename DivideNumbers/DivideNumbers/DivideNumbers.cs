using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideNumbers
{
    public class DivideNumbers
    {
        public Double Podziel(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }

    public class DivideByZeroException : ApplicationException
    {

    }
}
