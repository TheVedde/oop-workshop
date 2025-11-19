namespace OOP_Workshop
{
    public class Library
    {
        List<BaseMedia> files;
        public Library()
        {
            files = new List<BaseMedia>();
        }
        public void Borrow()
        {

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
            files.GroupBy(m => m.GetType()).ToList();
            foreach (BaseMedia media in files)
            {
                Console.WriteLine(media.title);
            }
        }

        public void AddEntry(BaseMedia media) {
            
            files.Add(media);
        }
        public void RemoveEntry(BaseMedia media) { files.Remove(media); }
        
    }
}
