using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Galactic_GPS
{
    public struct Location
    {
        private double lontitude;
        private double latitude;
        public Planet planet { get; set; }

        public Location(double lontitude ,double lantitude, Planet otherPlanet):this()
        {
            this.Lontitude = lontitude;
            this.Latitude = latitude;
            this.planet = otherPlanet;
        }
        public double Lontitude
        {
            get
            {
                return this.lontitude;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative lontitude");
                }
                this.lontitude = value;
            }
        }
        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative latitude");
                }
                this.latitude = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                this.lontitude, this.latitude, this.planet);
        }
    }
}
