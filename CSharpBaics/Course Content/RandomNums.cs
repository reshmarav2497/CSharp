using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Course_Content
{
    public class RandomNums
    {
        public void GenerateRandomNumbers()
        {
            Random random = new Random();

            // Generate a random integer
            int randomInt = random.Next();
            Console.WriteLine($"Random Integer: {randomInt}");

            // Generate a random integer within a specific range (0 to 99)
            int randomIntInRange = random.Next(0, 100);
            Console.WriteLine($"Random Integer (0-99): {randomIntInRange}");

            // Generate a random double between 0.0 and 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine($"Random Double (0.0-1.0): {randomDouble}");

            // Generate a random boolean value
            bool randomBool = random.Next(0, 2) == 1;
            Console.WriteLine($"Random Boolean: {randomBool}");
        }
    }
}
