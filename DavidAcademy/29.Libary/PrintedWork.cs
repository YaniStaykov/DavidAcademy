namespace _29.Libary
{
    public class PrintedWork
    {
        public PrintedWork(string title, string language, string publishingHouse)
        {
            this.Title = title;
            this.Language = language;
            this.PublishingHouse = publishingHouse;
        }
        public string Title { get; set; }

        public string Language { get; set; }

        public string PublishingHouse { get; set; }
    }
}
