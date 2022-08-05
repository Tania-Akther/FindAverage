using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FindAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { -4, 3, -9, 0, 4, 1 };
            plusMinus(array);
            void plusMinus(List<int> arr)
            {
                var total = arr.Count;
                var positive = (decimal)arr.Count(x => x > 0) / total;
                var negative = (decimal)arr.Count(x => x < 0) / total;
                var zero = (decimal)arr.Count(x => x == 0) / total;
                Console.WriteLine(positive.ToString(".000000"));
                Console.WriteLine(negative.ToString(".000000"));
                Console.WriteLine(zero.ToString(".000000"));
            }

            List<int> a = new List<int> { 1, 2, 3, 4, 5 };
            miniMaxSum(a);

            void miniMaxSum(List<int> arr)
            {
                var minList = arr.OrderBy(x => x).Take(4).Aggregate<int,long>(0,(x, y) => x + y);
                var maxList = arr.OrderByDescending(x => x).Take(4).Aggregate<int,long>(0,(x, y) => x + y);
                Console.WriteLine($"{minList} {maxList}");
            }

        }
    }
}
