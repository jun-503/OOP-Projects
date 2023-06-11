using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.BL
{
   public class Ship
    {
       public static List<Ship> ships = new List<Ship>();
        public string shipNum;
        public Angle latitude;
        public Angle longitude;
        public Ship(string shipNum,Angle latitude,Angle longitude)
        {
            this.shipNum = shipNum;
           this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
