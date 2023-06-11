using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UI;


namespace Ocean_Navigation.BL
{
    public class Angle
    {
        public int degress;
        public float minutes;
        public char direction;
        public Angle(int degress,float minutes,char direction)
        {
            this.degress = degress;
            this.minutes = minutes;
            this.direction = direction;
        }
    }
}
