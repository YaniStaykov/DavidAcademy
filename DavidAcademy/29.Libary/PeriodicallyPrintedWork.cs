namespace _29.Libary
{
    using System;

    public class PeriodicallyPrintedWork : PrintedWork
    {
        public PeriodicallyPrintedWork(DateTime year,string publishingIssue, string title, string language, string publishingHouse) 
            : base(title, language, publishingHouse)
        {
            this.Year = year;
            this.PublishingIssue = publishingIssue;
        }

        public DateTime Year { get; set; }

        public string PublishingIssue { get; set; }
    }
}
