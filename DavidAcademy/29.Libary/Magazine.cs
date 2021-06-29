namespace _29.Libary
{
    using System.Collections.Generic;

    public class Magazine : PeriodicallyPrintedWork
    {
        public string Topic { get; set; }

        public List<string> Autors { get; set; }

        public string CoverDescription { get; set; }
    }
}
