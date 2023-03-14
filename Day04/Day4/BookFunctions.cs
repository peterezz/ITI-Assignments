

namespace Day4
{
    public class BookFunctions
    {
        public static string GetTitle(Book x) => x.Title;
        public static string GetAuthors(Book x) => String.Join(" - ",x.Authors);
        public static string GetPrice(Book x) => x.Price.ToString("C");
    }
}
