using OOP_Workshop.Persistance.User;

namespace OOP_Workshop
{
    internal class Program
    {
        static Borrower user1 = new Borrower(1,"User",20,"123456-22");
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {user1.Name}!");
            Console.WriteLine("What would you like to do?");
            Console.ReadLine();
        }
    }
}
