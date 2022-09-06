using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm
{
    internal class ProjectManager : Manager
    {
        //Properties
        private string email;

        //Encapsulation
        public string Email { get { return email; } }

        //Constructer
        public ProjectManager(string firstName, string lastName, string cpr, string phoneNumber, string email) : base(firstName, lastName, cpr, phoneNumber)
        {
            this.email = email;
        }
    }
}
