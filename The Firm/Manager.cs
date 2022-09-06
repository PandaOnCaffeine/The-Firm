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
        //Overrides the method from the Employee class
        protected internal override void GetProperties()
        {
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.CPR);
            Console.WriteLine(this.PhoneNumber);
            Console.WriteLine("");
        }
    }
}
