using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMS.BL
{
    class Employee:MUser
    {
        private string employeeID;
        private string email;
        private string rank;
        private string contactNumber;
        private List<Employee> employees = new List<Employee>();
        public Employee(string mName,string mPassword,string mRole,string employeeID,string email,string rank,string contactNumber):base(mName,mPassword,mRole)
        {
            this.employeeID = employeeID;
            this.email = email;
            this.rank = rank;
            this.contactNumber = contactNumber;
        }
        public string empID
        {
            get { return employeeID; }
        }
        public string Email
        {
            get { return email; }
        }
        public string Rank
        {
            get { return rank; }
        }
        public string cNum
        {
            get { return contactNumber; }
        }
        public override string saveDataInFile(string Path,StreamWriter f1)
        {
           
            f1.WriteLine(base.saveDataInFile(Path,f1) + "," + employeeID + "," + email + "," + rank + "," + contactNumber);
            f1.Flush();
            f1.Close();
            return null;
        }
    }
}
