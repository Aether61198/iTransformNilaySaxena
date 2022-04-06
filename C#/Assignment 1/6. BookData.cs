using System;

namespace BookData
{
    struct Book
    {
        public int bookID;
        public string? title;
        public float price;
        public int bookType;
    };

    class BookDetails
    {
        public enum bookTypes { Magazine, Novel, ReferenceBook, Miscellaneous };

        public static void DisplayBookDetails(string? bTitle, float bPrice, int bID, int bType)
        {
            Console.WriteLine("Title of the book: {0}", bTitle);
            Console.WriteLine("Book ID: {0}", bID);
            Console.WriteLine("Price of the book: {0}", bPrice);
            switch (bType)
            {
                case 1:
                    Console.WriteLine("Book Type: Magazine");
                    break;
                case 2:
                    Console.WriteLine("Book Type: Novel");
                    break;
                case 3:
                    Console.WriteLine("Book Type: ReferenceBook");
                    break;
                case 4:
                    Console.WriteLine("Book Type: Miscellaneous");
                    break;
            }
        }

        static void Main()
        {
            Book objBook;

            Console.WriteLine("Enter the title of the book");
            objBook.title = Console.ReadLine();
            Console.WriteLine("Enter the price of the book");
            objBook.price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Book ID");
            objBook.bookID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Type:-\n1. Magazine\n2. Novel\n3. ReferenceBook\n4. Miscellaneous");
            int ch = Convert.ToInt32(Console.ReadLine());
            objBook.bookType = 0;
            switch (ch)
            {
                case 1:
                    objBook.bookType = (int)bookTypes.Magazine;
                    break;
                case 2:
                    objBook.bookType = (int)bookTypes.Novel;
                    break;
                case 3:
                    objBook.bookType = (int)bookTypes.ReferenceBook;
                    break;
                case 4:
                    objBook.bookType = (int)bookTypes.Miscellaneous;
                    break;
                default:
                    Console.WriteLine("Invallid Choice...");
                    break;
            }
            BookDetails.DisplayBookDetails(objBook.title, objBook.price, objBook.bookID, objBook.bookType);
        }
    }
}