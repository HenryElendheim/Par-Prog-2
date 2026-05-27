
using Par_Prog_2;

List<BookFilmInfo> info = new List<BookFilmInfo>();
bool addingproducts = true;
while (addingproducts)
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

    var bookfilminfo = new BookFilmInfo(title, year, description, author, actor);
    string answer = Console.ReadLine();
    if (answer == "N")
    {
        addingproducts = false;
    }

    Console.WriteLine("Vil du legge til flere bøker? (Y/N)");
    for (int i = 0; i < info.Count; i++)
    {
        Console.WriteLine($"tittel: {title}\n" +
                   $"ÅR: {year}\n" +
                   $"Beskrivelse: {description}\n" +
                   $"Forfatter/Regissør: {author}\n" +
                   $"Skuespillere: {actor}");
    }

}