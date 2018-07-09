namespace ClassBox
{
    using System;

    public class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Box(decimal length, decimal width, decimal height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public decimal Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string CalculateSurfaceArea()
        {
            var surfaceArea = 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
            return $"Surface Area - {surfaceArea:f2}";
        }

        public string CalculateLateralSurfaceArea()
        {
            var lateralSurfaceArea = 2 * this.length * this.height + 2 * this.width * this.height;
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string CalculateVolume()
        {
            var volume = this.length * this.width *this.height;
            return $"Volume - {volume:f2}";
        }
    }
}
