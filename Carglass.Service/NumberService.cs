using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.Service
{
    public class NumberService
    {
        public List<int> GetDivisors(int number)
        {
            var divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    divisors.Add(i);
            }
            return divisors;
        }

        public List<int> GetPrimeDivisors(List<int> divisors)
        {
            return divisors.Where(IsPrime).ToList();
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
