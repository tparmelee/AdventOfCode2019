using System;
using System.Collections.Generic;

using System.Text;

namespace Implementation.Day03
{
    public class Point
    {
        public int X;
        public int Y;
        public int Steps;

        public Point(int x, int y, int s)
        {
            X = x;
            Y = y;
            Steps = s;
        }

        public int ManhattenDistance()
        {
            return Math.Abs(X) + Math.Abs(Y);
        }
    }
}
