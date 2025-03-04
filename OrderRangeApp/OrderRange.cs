using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRangeApp
{
    class OrderRange
    {
        public (List<int> evenNumbers, List<int> oddNumbers) Build(List<int> numbers)
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            var oddNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList();
            return (evenNumbers, oddNumbers);
        }

    }
}
