using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using BMS.DL;
using BMS.UI;
using System.IO;
namespace BMS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool check = Customer_UI.readCustomerData();
            bool check1 = Employee_UI.readEmployeeData();

            if (check==true && check1==true)
            {
                Console.WriteLine("Data loaded Successfully; ");

            }
            else
            {
                Console.WriteLine("Data Not Loaded");
                Console.ReadKey();
            }

            MainMenuUI.clearScreen();
            MainMenuUI.printHeader();
            int option;
            do
            {
                option = MainMenuUI.mainMenu();
                if (option == 1)
                {
                    MainMenuUI.clearScreen();
                    MainMenuUI.printHeader();
                    MUser user = MUserUI.takeInputWithoutRole();
                    if (user != null)
                    {
                        string name = user.Naam;
                        string password = user.password;
                        string role = MUser_DL.signIn(name,password);
                        {
                            if (role == "User not found")
                            {
                                Console.WriteLine("Invalid User");
                            }
                            else if (role=="Employee")
                            {
                                Console.WriteLine("Admin Menu");
                                int adminOpt = -1;
                            }
                            else
                            {
                                int custOp = 0;
                                do
                                {
                                    MainMenuUI.clearScreen();
                                    MainMenuUI.printHeader();
                                    custOp = Customer_UI.customerMenu();
                                    if (custOp == 1)
                                    {
                                        MainMenuUI.clearScreen();
                                        MainMenuUI.printHeader();
                                        bool result = CustomerDL.depositMoney();
                                        if(result==true)
                                        {
                                            writeDataInFile();
                                            Console.WriteLine("AMount added successfully");
                                        }
                                        
                                    }
                                    else if(custOp==2)
                                    {
                                        MainMenuUI.clearScreen();
                                        MainMenuUI.printHeader();
                                        bool result = CustomerDL.withDrawMoney();
                                        if (result == true)
                                        {
                                            writeDataInFile();
                                            Console.WriteLine("AMount withDrawn successfully");
                                        }
                                    }
                                    if(custOp==9)
                                    {
                                        MainMenuUI.clearScreen();
                                        break;
                                    }
                                } while (custOp != 9);
                            }
                        }
                    }
                }
                else if (option == 2)
                {
                    MainMenuUI.clearScreen();
                    MainMenuUI.printHeader();
                    Console.WriteLine(" Enter '1' to SignUp as Employee");
                    Console.WriteLine(" Enter '2' to SignUp as Customer");
                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Employee e1;
                        MainMenuUI.clearScreen();
                        MainMenuUI.printHeader();
                        e1 = Employee_UI.takeInput();
                        if (e1 == null)
                        {
                            Console.WriteLine("Account Not  created");
                            MainMenuUI.clearScreen();
                            MainMenuUI.printHeader();
                        }
                        else
                        {
                            MUser_DL.addIntoList(e1);
                            // EmployeeDL.writeDatainEmployeeFile(e1);
                            writeDataInFile();
                            Console.WriteLine("Account Created Successfully");
                           
                        }
                    }
                    else if (choose == 2)
                    {
                        Customer c1;
                        MainMenuUI.clearScreen();
                        MainMenuUI.printHeader();
                        c1 = Customer_UI.takeInput();
                        if (c1 == null)
                        {
                            Console.WriteLine("Account Not  created");
                            MainMenuUI.clearScreen();
                            MainMenuUI.printHeader();
                        }

                        else
                        {
                            MUser_DL.addIntoList(c1);
                            //  CustomerDL.writeDatainCustomerFile(c1);
                            Customer.addintoCustomerList(c1);
                            writeDataInFile();
                            Console.WriteLine("Account Created Successfully");
                            MainMenuUI.clearScreen();
                            MainMenuUI.printHeader();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter Correct option");
                        option = 2;

                    }
                }
                else if (option == 9)
                {
                    MainMenuUI.clearScreen();
                    break;
                }
                else
                {
                    Console.WriteLine("please enter correct option");

                }
            } while (option != 9);

        }
        static void writeDataInFile()
        {
            int count = 0;
            StreamWriter f1;
            foreach (MUser storedUser in MUser.users)
            {
                count++;
               
                if(storedUser.role=="Customer")
                {
                    string path  = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Customer.txt";
                    if (count == 1)
                    {
                        f1 = new StreamWriter(path, false);
                    }
                    else
                        f1 = new StreamWriter(path, true);
                    storedUser.saveDataInFile(path,f1);
                }
                else
                {
                    string path = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Employee.txt";
                    if (count == 1)
                    {
                        f1 = new StreamWriter(path, false);
                    }
                    else
                        f1 = new StreamWriter(path, true);
                    storedUser.saveDataInFile(path,f1);
                }
            }
        }
    }
}
