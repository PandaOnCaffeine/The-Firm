using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Manager : Employee
    {
        //Properties
        private string phoneNumber;

        //Encapsulation
        public string PhoneNumber { get { return phoneNumber; } }

        //Constructer
        public Manager(string firstName, string lastName, string cpr, string phoneNumber) :base(firstName, lastName, cpr)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
