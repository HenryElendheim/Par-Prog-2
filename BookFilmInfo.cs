using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Par_Prog_2
{
    internal class BookFilmInfo
    {

        public string Title;
        public string Year;
        public string Description;
        public string Author;
        public string Actor;

        private List<BookFilmInfo> info = new List<BookFilmInfo>();

        public BookFilmInfo(string title = "Default", string year = "Default", string description = "Default", string author = "Default", string actor = "Default")
        {
            Title = title;
            Year = year;
            Description = description;
            Author = author;
            Actor = actor;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("hva er tittelen på boka?");
                string title = Console.ReadLine();

                Console.WriteLine("hvilken år kom det ut");
                string year = Console.ReadLine();

                Console.WriteLine("skriv kort beskrivelse");
                string description = Console.ReadLine();

                Console.WriteLine("hvem er forfatteren/regisør?");
                string author = Console.ReadLine();

                Console.WriteLine("hvem er skuespilleren");
                string actor = Console.ReadLine();

                BookFilmInfo value = new BookFilmInfo(title, year, description, author, actor);

                info.Add(value);

                Console.WriteLine($"Det er så mange bøker/filmer i listen: {info.Count}");
                foreach (var infoValue in info)
                {
                    Console.WriteLine($"\nTittel: {infoValue.Title}\n" +
                                      $"År: {infoValue.Year}\n" +
                                      $"Beskrivelse: {infoValue.Description}\n" +
                                      $"Forfatter/Regissør: {infoValue.Author}\n" +
                                      $"Skuespillere: {infoValue.Actor}");
                }
                Console.WriteLine("\n\nTrykk en tast for å legge til flere...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
