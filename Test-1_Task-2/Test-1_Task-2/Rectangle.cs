using System;

namespace Test_1_Task_2
{
    /// <summary>
    /// Contains rectangle's properties.
    /// </summary>
    public class Rectangle
    {
        private double length;
        private double width;
        private double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                length = value;
            }
        }
        private double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                width = value;
            }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Counts and returns rectangle's square.
        /// </summary>
        /// <returns>Square</returns>
        public double GetSquare()
        {
            return Length * Width;
        }
    }
}
