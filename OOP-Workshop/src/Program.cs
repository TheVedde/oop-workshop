using System.ComponentModel.Design;
using OOP_Workshop.Persistance.User;

namespace OOP_Workshop
{
    internal class Program
    {
        static Borrower user1 = new Borrower(1,"User",20,"123456-22");
        static Library library1 = new Library();

        static string view = "View library items";
        static string select = "";
        static string borrow = "";
        static string review = "";

        public struct Command
        {
            public string commandText;
            public ConsoleKey keyActivation;
            public Action functionCall;

            public Command[] nextCommands;
        }

        static void Main(string[] args)
        {
            int media = 0;

            Command borrowCommand = new Command
            {
                commandText = "Which item do you wish to borrow?",
                keyActivation = ConsoleKey.D1,
                functionCall = () => library1.Borrow(media),
                nextCommands = new Command[0]
            };

            AddDummyData(25);
            Console.WriteLine($"Hello {user1.Name}!");
            Console.WriteLine("What would you like to do?");
            Console.CursorVisible = false;

            Command[] currentCommands =
            [
                new Command { 
                    commandText = new string(" -> " + view),
                    keyActivation = ConsoleKey.D1,
                    functionCall = () => library1.DisplayEntriesByType(), 
                    nextCommands = new Command[0]
                }
            ];

            do
            {
                foreach (Command command in currentCommands)
                {
                    Console.WriteLine(command.keyActivation + command.commandText);
                }
                Console.WriteLine("\nWaiting for input...");
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                foreach (Command command in currentCommands)
                {
                    if (keyPressed == command.keyActivation)
                    {
                        command.functionCall();
                    }
                }

            } while (true);
            //library1.DisplayEntries();
            library1.DisplayEntriesByType();

        }

        private static void AddDummyData(int amount)
        {
            // 25 Book Titles
            string[] titles = 
            [
                "The Silent Echo",
                "Midnight at the Oasis",
                "Quantum Shadows",
                "The Last Algorithm",
                "Whispers of the Old World",
                "Journey to the Center",
                "The Crimson Sky",
                "Beyond the Horizon",
                "Echoes of Eternity",
                "The Forgotten Key",
                "Digital Dreams",
                "The Glass Fortress",
                "Winds of Change",
                "The Iron Duke",
                "Velvet Morning",
                "Mystery of the Blue Train",
                "The Hollow Man",
                "Rogue Agent",
                "Starlight and Ash",
                "The Broken Mirror",
                "Coding the Future",
                "Secrets of the Deep",
                "The Phantom Signal",
                "Golden Years",
                "Shadows of the Past"
            ];

            // 25 Authors
            string[] authors = 
            [
                "James R. Sterling",
                "Elena Vance",
                "Marcus Thorne",
                "Sarah Jenkins",
                "David Kim",
                "Olivia Martinez",
                "Samuel Oak",
                "Linda Carter",
                "Thomas Anderson",
                "Jessica Day",
                "Kevin Malone",
                "Angela Martin",
                "Oscar Nunez",
                "Pamela Beesly",
                "Dwight K. Schrute",
                "Michael G. Scott",
                "Stanley Hudson",
                "Phyllis Lapin",
                "Kelly Kapoor",
                "Ryan Howard",
                "Toby Flenderson",
                "Meredith Palmer",
                "Creed Bratton",
                "Darryl Philbin",
                "Erin Hannon"
            ];

            // 25 Publishers
            string[] publishers = 
            [
                "Bluebird Press",
                "Horizon Media",
                "Starlight Books",
                "Ironclad Publishing",
                "Riverview House",
                "Summit Publications",
                "North Star Press",
                "Global Media Group",
                "Vintage Classics",
                "Modern Age Books",
                "TechStream",
                "Paperback Heroes",
                "Grand Oak Publishing",
                "Silver Lining Press",
                "Crimson House",
                "Deep Dive Media",
                "Apex Books",
                "Lighthouse Publishing",
                "Urban Tales",
                "Next Gen Readers",
                "Classic Ink",
                "Scholar Press",
                "Dreamweaver Books",
                "Infinity Publishing",
                "Echo Valley Press"
            ];

            // 25 People (General Names)
            string[] people = 
            [
                "Alice Johnson",
                "Bob Smith",
                "Charlie Davis",
                "Diana Prince",
                "Ethan Hunt",
                "Fiona Gallagher",
                "George Miller",
                "Hannah Abbott",
                "Ian Wright",
                "Julia Styles",
                "Kevin Hart",
                "Liam Neeson",
                "Mia Wallace",
                "Noah Bennett",
                "Oliver Queen",
                "Peter Parker",
                "Quinn Fabray",
                "Rachel Green",
                "Steve Rogers",
                "Tony Stark",
                "Ursula Buffay",
                "Victor Stone",
                "Wanda Maximoff",
                "Xander Cage",
                "Yara Greyjoy"
            ];

            for (int i = 0; i < amount; i++)
            {
                Random rand = new Random();
                int mediaTypeIndex = rand.Next(0, 7);

                BaseMedia newMedia;
                string type = "";

                switch (mediaTypeIndex)
                {
                    case 0:
                        newMedia = new App(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], 0, "", new string[0]);
                        break;
                    case 1:
                        newMedia = new E_Book(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], 0, 2025, "", "");
                        break;
                    case 2:
                        newMedia = new Image(titles[rand.Next(0, titles.Length)], "", "", 0, "");
                        break;
                    case 3:
                        newMedia = new Movie(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], "", 0, "", 0);
                        break;
                    case 4:
                        newMedia = new PodcastEpisode(titles[rand.Next(0, titles.Length)], new string[0], new string[0], 0, 2025, "", false);
                        break;
                    case 5:
                        newMedia = new Song(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], publishers[rand.Next(0, publishers.Length)], "", "", "", 0);
                        break;
                    case 6:
                        newMedia = new Video_Game(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], "", 0, new string[0], false);
                        break;
                    default:
                        newMedia = new App(titles[rand.Next(0, titles.Length)], publishers[rand.Next(0, publishers.Length)], 0, "", new string[0]);
                        break;
                }

                library1.AddEntry(newMedia);
            }
        }
    }
}
