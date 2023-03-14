using Day4;




List<Book> listBook = new List<Book>()
{
    new Book("daslsk1","test1",new string[] {"author11", "author21","author31"},DateTime.Now,30),
    new Book("daslsk2","test2",new string[] {"author12", "author22","author32"},DateTime.Now.AddDays(5),40),
    new Book("daslsk3","test3",new string[] {"author13", "author23","author33"},DateTime.Now.AddDays(20),60),

};

//a. User Defined Delegate Datatype
GetBookData fPtr = new GetBookData(BookFunctions.GetAuthors);
LibraryEngine.ProcessBooks(listBook, fPtr);


//b. BCL Delegates
Func<Book, string> fPtrr = BookFunctions.GetPrice;
LibraryEngine.ProcessBooks(listBook, fPtrr);

//c. Anonymous Method (ISBN)
fPtr = delegate(Book book) { return book.ISBN; };
LibraryEngine.ProcessBooks(listBook, fPtr);

//d.Lambda Expression(GetPublicationDate)
 Func<Book,string> fPtrrr=(book)=> book.ToString();
LibraryEngine.ProcessBooks(listBook, fPtrrr);










