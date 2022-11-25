using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{

    public class Airplane : Vehicle
    {
        private string _airline;

        public int Altitude { get; set; }
        public string Airline { get => _airline; set => _airline = value; }

        public Airplane(int capacity) : base(capacity)
        {

        }

        public Airplane(int capacity, int speed) : base(capacity, speed)
        {
            Airline = _airline;
        }

        public void Ascend(int distance)
        {

        }

        public void Descend(int distance)
        {

        }

        public override string Move()
        {
            return "";
        }
        public override string Move(int times)
        {
            return "";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
