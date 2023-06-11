using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
using BMS.DL;

namespace BMS.UI
{
    class Employee_UI
    {
        private static readonly string  employeePath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Employee.txt";
        public static Employee takeInput()
        {
           MUser user =  MUserUI.takeInputWithRole();
            if (user != null)
            {
                string name = user.Naam;
                string password = user.password;
                string role = "Employee";
                string ID = $"{ MUser.users.Count + 1} EZ";
                Console.WriteLine("Enter your employee email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your rank: ");
                string rank = Console.ReadLine();
                Console.WriteLine("Enter your contact: ");
                string contact = Console.ReadLine();
                Employee e1 = new Employee(name, password, role, ID, email, rank, contact);
                return e1;
            }
            return null;
        }
        public static bool readEmployeeData()
        {
            if (File.Exists(employeePath))
            {
                StreamReader fileVariable = new StreamReader(employeePath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedData = record.Split(',');
                    string name = splittedData[0];
                    string password = splittedData[1];
                    string role = splittedData[2];
                    string ID = splittedData[3];
                    string email = splittedData[4];
                    string rank = splittedData[5];
                    string cNum = splittedData[6];
                    Employee e1 = new Employee(name, password, role, ID, email, rank, cNum);
                    MUser_DL.addIntoList(e1);


                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
