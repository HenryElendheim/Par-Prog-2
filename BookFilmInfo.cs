using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_2
{
    internal class BookFilmInfo
    {

        public string Title;
        public string Year;
        public string Description;
        public string Author;
        public string Actor;

        public BookFilmInfo(string title, string year, string description, string author, string actor)
        {
            Title = title;
            Year = year;
            Description = description;
            Author = author;
            Actor = actor;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"tittel: {Title}\n" +
                $"ÅR: {Year}\n" +
                $"Beskrivelse: {Description}\n" +
                $"Forfatter/Regissør: {Author}\n" +
                $"Skuespillere: {Actor}");
        }

    }
}
