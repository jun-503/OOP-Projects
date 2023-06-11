using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;

namespace Ocean_Navigation.UI
{
    class MenuUI
    {
        public static int Menu()
        {
            
            Console.WriteLine("1. Add Ship ");
            Console.WriteLine("2. View Ship ");
            Console.WriteLine("3. View Ship Serial Number ");
            Console.WriteLine("4. Change Ship Position ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("9. Exit");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Select one of them ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
