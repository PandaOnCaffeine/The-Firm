namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates 3 objekts
            Employee sweeper = new Sweeper("Jacob", "Anderson", "2312313333");
            Employee manager = new Manager("Joey","Joe","0230123230", "34234485");
            Employee pm = new ProjectManager("Bob", "jakobsen", "5127335346", "29349529", "EMAIL@something.dk");

            //Calls the GetProperties Method from manager, pm and sweeper
            manager.GetProperties();
            pm.GetProperties();
            sweeper.GetProperties();
        }
    }
}