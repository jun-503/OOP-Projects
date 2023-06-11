using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UI;
using Ocean_Navigation.BL;

namespace Ocean_Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice ;
            do
            {
                choice = MenuUI.Menu();
                if (choice == 1)
                {
                   
                    MenuUI.clearScreen();
                    Ship s1 = ShipUI.takeInputForShip();
                    ShipDL.addIntoList(s1);
                    MenuUI.clearScreen();
                }
                else  if(choice==2)
                {
                    MenuUI.clearScreen();
                    Console.WriteLine("Enter Ship Serial Number to find its position:");
                    string num = Console.ReadLine();
                    Ship s1 = ShipDL.findShip(num);
                    if(s1!=null)
                    {
                        Console.WriteLine("Ship is at " + " " + s1.latitude.degress + "\u00b0" + s1.latitude.minutes + s1.latitude.direction  + " and " + " " + s1.longitude.degress + "\u00b0"+ s1.longitude.minutes+s1.longitude.direction);
                    }
                    else
                    {
                        Console.WriteLine("Enter Correct Serial Number");
                    }

                }
                else if(choice==3)
                {
                    MenuUI.clearScreen();
                    string num = ShipDL.shipSerialNum();
                    Console.WriteLine("Serial Number: ");
                    Console.WriteLine(num);
                    MenuUI.clearScreen();
                }

                else if(choice==4)
                {
                    MenuUI.clearScreen();
                    Console.WriteLine("Enter Ship Serial Number to Change its position:");
                    string num = Console.ReadLine();
                    bool check = ShipDL.ChangePosition(num);
                    if (check == true)
                    {
                        Console.WriteLine("Updated Successfully");
                    }
                    else
                        Console.WriteLine("No shIp Found");
                    MenuUI.clearScreen();

                }
                else  if(choice==9)
                {
                    MenuUI.clearScreen();
                        break;
                }
                else
                {
                    MenuUI.clearScreen();
                    Console.WriteLine("enter Correct Option");
                    MenuUI.clearScreen();
                }

            } while (choice != 9);
        }
    }
}
