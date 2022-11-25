using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        protected int _numPassengers;


        public int NumPassengers
        {
            get => _numPassengers;
            set
            {
                if (value >= 0 && value <= _capacity)
                {
                    _numPassengers = value;
                }
            }
        }
        public int Position { get; private set; }
        public int Speed { get; init; }


        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
        }


        public Vehicle() : this(0)
        {
        }


        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;
            return $"Moving along {times} times";
        }
    }
}
