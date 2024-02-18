using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Angle
    {
        public int angle;
        public float minutes;
        public char direction;
        public Angle(int angle, float minutes, char direction)
        {
            this.angle = angle;
            this.minutes = minutes;
            this.direction = direction;
        }   
        public string displayAngle()
        {
            return angle +("\u00b0")+minutes+"'"+direction;
        }
        public void changeAngle(Angle a)
        {
            this.angle = a.angle;
            this.minutes = a.minutes;
            this.direction = a.direction;
        }

    }
}
