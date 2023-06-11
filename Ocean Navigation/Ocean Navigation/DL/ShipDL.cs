using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.DL
{
    class ShipDL
    {
        public static void addIntoList(Ship s1)
        {
            Ship.ships.Add(s1);
        }
        public static Ship findShip(string num)
        {
            foreach(Ship s1 in Ship.ships)
            {
                if(s1.shipNum==num)
                {
                    return s1;
                }
            }
            return null;
        }
        public static string shipSerialNum()
        {
            Angle latitude = AngleUI.takeAngleForLati();
            Angle longitude = AngleUI.takeAngleForLong();
            foreach(Ship storedShip in Ship.ships)
            {
                if((latitude.degress==storedShip.latitude.degress && latitude.minutes==storedShip.latitude.minutes && latitude.direction==storedShip.latitude.direction) &&( longitude.degress==storedShip.longitude.degress && longitude.minutes==storedShip.longitude.minutes && longitude.direction==storedShip.longitude.direction))
                {
                    return storedShip.shipNum;
                }
            }
            return "No ship Present";
        }
        public static bool ChangePosition(string number)
        {
            foreach(Ship storedShip in Ship.ships)
            {
                if(number==storedShip.shipNum)
                {
                    storedShip.latitude = AngleUI.takeAngleForLati();
                    storedShip.longitude = AngleUI.takeAngleForLong();
                    return true;
                }
            }
            return false;
        }
    }
}
