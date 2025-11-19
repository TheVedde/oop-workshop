namespace OOP_Workshop
{
    public class Library
    {
        List<BaseMedia> files;

        public Library()
        {
            files = new List<BaseMedia>();
        }
        public BaseMedia Borrow(int fileId)
        {
            return files[fileId];
        }

        public void DisplayEntries()
        {
            foreach (BaseMedia media in files)
            {
                Console.WriteLine(media.title);
            }
        }

        public void DisplayEntriesByType()
        {
            files = files.OrderBy(m => m.type).ToList();

            string lastType = "";
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].type != lastType)
                {
                    Console.WriteLine("\n\nCategory: " + files[i].type);
                    Console.WriteLine(new string('-', 50));
                    lastType = files[i].type;
                }

                Console.WriteLine("{0, -15} {1, 0}", new string("> " + i + " - " + files[i].type), files[i].title);
                Console.WriteLine(new string('-', 50));
            }
        }

        public void AddEntry(BaseMedia media) {
            
            files.Add(media);
        }
        public void RemoveEntry(BaseMedia media) { files.Remove(media); }
        
    }
}
