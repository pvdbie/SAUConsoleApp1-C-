using System;

namespace SAUConsoleApp1
{
    internal class Program6
    {
        enum BType{
        CarToon,Newspaper,Magazine,Sports,TextBook}
        struct Book
        {
            public string Bookid;
            public string BookName;
            public double BookPrice;

            public BType BookType;
        }
        static void Main6(string[] args)
        {
            Book myBook;
            myBook.Bookid = "b0001";
            myBook.BookName = "C# Programming";
            myBook.BookPrice = 250.45;
            myBook.BookType = BType.TextBook;
            Console.WriteLine($"Book ID :{myBook.Bookid} Book Name:{myBook.BookName} Book Price: {myBook.BookPrice}");
            
        }
    }
}
