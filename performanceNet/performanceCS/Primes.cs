using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performanceCS
{
    public class Primes
    {
        private static IEnumerable<int> GetRange(int from, int to)
        {
            for (int i = from; i <= to; i += 2)
                yield return i;

        }

        public static List<int> GetPriemsBelow(int below)
        {
            var priems = new List<int>();
            priems.Add(2);
            for (int i = 3; i < below; i += 2)
            {
                bool isPriem = true;
                int sqrt = (int)Math.Sqrt((int)i) + 1;

                foreach (var priem in priems)
                {
                    if (priem > sqrt) break;
                    if (i % priem == 0)
                    {
                        isPriem = false;
                        break;
                    }
                }
                if (isPriem)
                {
                    priems.Add(i);
                }
            }
            return priems;
        }
    }
}
