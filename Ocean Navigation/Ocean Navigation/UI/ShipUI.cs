using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;

namespace Ocean_Navigation.UI
{
    class ShipUI
    {
        public static Ship takeInputForShip()
        {
            Console.WriteLine("Enter Ship Number");
            string number = Console.ReadLine();

            Angle latitude = AngleUI.takeAngleForLati();
            Angle longitude = AngleUI.takeAngleForLong();
            Ship s1 = new Ship(number, latitude, longitude);
            return s1;


        }
    }
}
