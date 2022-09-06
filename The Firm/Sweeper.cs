using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class Sweeper : Employee
    {

        //Constructer
        public Sweeper(string firstName, string lastName, string cpr) : base(firstName, lastName, cpr)
        {

        }
        //Overrides the method from the Employee class
        protected internal override void GetProperties()
        {
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.CPR);
            Console.WriteLine("");
        }
    }
}
