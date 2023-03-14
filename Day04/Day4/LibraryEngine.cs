using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public delegate string GetBookData(Book x);
    public class LibraryEngine
    {



        public static void ProcessBooks(List<Book> listBook,GetBookData fPtr)
        {
            foreach (Book book in listBook)
            {
                Console.WriteLine(fPtr(book));
            }
        }
        public static void ProcessBooks(List<Book> listBook, Func<Book,string> fPtr)
        {
            foreach (Book book in listBook)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
