﻿namespace RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public int Power
        {
            get { return this.power; }
        }

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }
}
