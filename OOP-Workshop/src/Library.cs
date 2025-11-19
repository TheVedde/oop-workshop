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

            for (int i = 0; i < files.Count; i++)
            {
                Console.WriteLine(files[i].type + " -> " + files[i].title);
            }
        }

        public void AddEntry(BaseMedia media) {
            
            files.Add(media);
        }
        public void RemoveEntry(BaseMedia media) { files.Remove(media); }
        
    }
}
