namespace Shapes
{
    using System;

    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Height), $"{nameof(this.Height)} cannot be null or negative");
                }
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Width), $"{nameof(this.Width)} cannot be null or negative");
                }
                this.width = value;
            }
        }

        public override double CalculateArea()
        {
            var area = this.Height * this.Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
