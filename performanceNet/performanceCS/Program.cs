using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performanceCS
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100;i<1000 * 1000 * 1000;i *= 10)
            {
                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                Console.WriteLine($"all priems below {i} parallel");
                watch.Start();
                for (int x = 0; x < 3; x++)
                {

                    var priems = Method1(i);
                    
                }
                watch.Stop();

                Console.WriteLine(new TimeSpan(watch.Elapsed.Ticks/3));
                Console.WriteLine();
            }
            Console.Read();
        }

        public static List<int> Method1(int below)
        {
            var priems = new List<int>();
            for (int i = 2; i < below; i++)
            {
                bool isPriem = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
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
