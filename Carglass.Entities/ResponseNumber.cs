using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.Entities
{
    public class ResponseNumber
    {
        public int InputNumber { get; set; }
        public List<int> Divisors { get; set; }
        public List<int> PrimeDivisors { get; set; }
    }
}
