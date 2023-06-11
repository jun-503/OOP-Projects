using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS.BL;

namespace BMS.DL
{
    class CustomerDL
    {
       
        private static string customerPath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Customer.txt";
        //public static void writeDatainUsersFile(Customer c1)
        //{
        //    StreamWriter file = new StreamWriter(usersPath, true);
        //    file.WriteLine(c1.Naam + "," + c1.password + "," + c1.role);
        //    file.Flush();
        //    file.Close();
        //}
        public static void writeDatainCustomerFile(Customer c1)
        {
            
            StreamWriter file = new StreamWriter(customerPath, true);
           
            string AccountInfo = c1.acc.accNum + ";" + c1.acc.Holder + ";" + c1.acc.balance;
            file.WriteLine(c1.Naam+","+c1.password+","+c1.role+","+c1.custID + "," + c1.custNum + "," + c1.Address + "," + AccountInfo);
            file.Flush();
            file.Close();
        }
        public static bool depositMoney()
        {
            Console.WriteLine("Enter your Account Number");
            int accNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you want to deposit");
            double amount = double.Parse(Console.ReadLine());
            foreach(var customer in MUser.users)
            {
                if(accNum==customer.acc.accNum)
                {
                    Bank_DL.Deposit(customer.acc, amount);
                }
                return true;
            }
            return false;
        }
        public static bool withDrawMoney()
        {
            Console.WriteLine("Enter your Account Number");
            int accNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you want to withDraw");
            double amount = double.Parse(Console.ReadLine());
            foreach (Customer customer in MUser.users)
            {
                if (accNum == customer.acc.accNum)
                {
                    Bank_DL.Withdraw(customer.acc, amount);
                }
                return true;
            }
            return false;
        }


    }
}
