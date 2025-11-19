using OOP_Workshop.Persistance.User;

namespace OOP_Workshop
{
    internal class Program
    {
        static Borrower user1 = new Borrower(1,"User",20,"123456-22");
        static Library library1 = new Library();
        static BaseMedia book = new E_Book("this title", "", 0, 0, "", "");
        static void Main(string[] args)
        {
            library1.AddEntry(book);
            Console.WriteLine($"Hello {user1.Name}!");
            Console.WriteLine("What would you like to do?");
            Console.ReadLine();
            library1.DisplayEntries();
            library1.DisplayEntriesByType();

        }
    }
}
