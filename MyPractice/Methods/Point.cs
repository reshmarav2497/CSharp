using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Methods
{
    internal class Point
    {
        public int X;
        public int Y;

        //Method Overloading
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //do a null check here
            if (newLocation == null)
                throw new ArgumentNullException(nameof(newLocation));
            Move(newLocation.X, newLocation.Y);
        }
    }
}
