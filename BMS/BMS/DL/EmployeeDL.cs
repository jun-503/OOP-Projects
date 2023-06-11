using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;

namespace BMS.DL
{
    class EmployeeDL
    {
        private static string employeePath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Employee.txt";
        private static string usersPath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\users.txt";
        //public static void writeDatainUsersFile(Employee e1)
        //{
        //    StreamWriter file = new StreamWriter(usersPath, true);
        //    file.WriteLine(e1.Naam + "," + e1.password + "," + e1.role);
        //    file.Flush();
        //    file.Close();
        //}
        public static void writeDatainEmployeeFile(Employee e1)
        {
           
            StreamWriter file = new StreamWriter(employeePath, true);
            file.WriteLine(e1.Naam + "," + e1.password + "," + e1.role+","+e1.empID + "," + e1.Email + "," + e1.Rank+ "," + e1.cNum);
            file.Flush();
            file.Close();
        }


    }
}
