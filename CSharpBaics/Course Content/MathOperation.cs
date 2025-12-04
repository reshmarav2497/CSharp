using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Course_Content
{
    internal class MathOperation
    {
        int abs = Math.Abs(-10);

        int sqrt = (int)Math.Sqrt(16);

        static int a = 10, b = 3;

        int max = Math.Max(a, b);

        int min = Math.Min(a, b);

        // rounds to nearest integer
        double round = Math.Round(4.7);

        // rounds up to next integer
        double ceiling = Math.Ceiling(4.3);

        // rounds down to previous integer
        double floor = Math.Floor(4.7);

        double power = Math.Pow(2, 3); // 2^3 = 8

        public void PrintValues()
        {
            Console.WriteLine($"Math.PI value -> " + Math.PI);
        }
    }
}
