using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Ship
    {
        public string serialNumber;
        public Angle Latitude;
        public Angle Longitude;
        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            this.serialNumber = serialNumber;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public void printPosition()
        {
            Console.WriteLine("Ship is at"+ Latitude.displayAngle() + Longitude.displayAngle());
        }
        public string getSerial()
        {
            return serialNumber;
        }
    }
}
