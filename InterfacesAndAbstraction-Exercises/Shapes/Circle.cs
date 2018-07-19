﻿namespace Shapes
{
    using System;

    public class Circle : IDrawable
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public void Draw()
        {
            var rIn = this.Radius - 0.4;
            var rOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x+= 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}