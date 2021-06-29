namespace _29.Libary
{
    using System;

    public class IndependentPrintedWork : PrintedWork
    {
        public IndependentPrintedWork(string title, string language, string publishingHouse) 
            : base(title, language, publishingHouse)
        {
        }

        public DateTime DateOfIssue { get; set; }

        public string Author { get; set; }

        public int NumberOfPages { get; set; }
    }
}
