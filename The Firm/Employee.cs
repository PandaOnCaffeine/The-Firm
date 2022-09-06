using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Employee
    {
        //Properties
        private string firstName;
        private string lastName;
        private string cpr;

        //Encapsulation
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string CPR { get { return cpr; } }

        //Constructer
        public Employee(string firstName, string lastName, string cpr)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cpr = cpr;
        }
    }
}

