using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal abstract class Employee
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
        //makes a abstract method that the subclasses can initiate and override the method
        protected internal abstract void GetProperties();
    }
}

