using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;

namespace Ocean_Navigation.UI
{
    public class AngleUI
    {
        public static Angle takeAngleForLati()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter Ship LAtitude");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter Latitude Degree");
            int degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Minute");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Direction");
            char dir = char.Parse(Console.ReadLine());
            Angle latitude = new Angle(degrees, minutes, dir);
            return latitude;
        }
        public static Angle takeAngleForLong()
        { 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter Ship LOngitude");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter Longitude Degree");
            int degrees1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude Minute");
            float minutes1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude Direction");
            char dir1 = char.Parse(Console.ReadLine());
            Angle longitude = new Angle(degrees1, minutes1, dir1);
            return longitude;
        }

        public static void changeAngle()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter Ship LAtitude");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter Latitude Degree");
            int degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Minute");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude Direction");
            char dir = char.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter Ship LOngitude");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Enter Longitude Degree");
            int degrees1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude Minute");
            float minutes1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude Direction");
            char dir1 = char.Parse(Console.ReadLine());
        }
    }
}
