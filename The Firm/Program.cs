namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sweeper sweeper = new Sweeper("Jacob", "Anderson", "2312313333");
            Manager manager = new Manager("Joey","Joe","0230123230", "34234485");
            ProjectManager pm = new ProjectManager("Bob", "jakobsen", "5127335346", "29349529", "EMAIL@something.dk");

            Console.WriteLine(sweeper.FirstName);
            Console.WriteLine(sweeper.LastName);
            Console.WriteLine(sweeper.CPR);

            Console.WriteLine(manager.FirstName);
            Console.WriteLine(manager.LastName);
            Console.WriteLine(manager.PhoneNumber);

            Console.WriteLine(pm.Email);
        }
    }
}