using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Robert C. Martin", "Clean Code", 2008, 8500);

            Console.WriteLine(book.DisplayInformation());
            book.IncreasePrice(10);
            Console.WriteLine(book.DisplayInformation());
            Console.WriteLine(book);
            Console.WriteLine();

           
            Book book1 = new Book("J.K. Rowling", "Harry Potter", 2008, 3500);
            Book book2 = new Book("Bán Mór", "Hunyadi");

            Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
            int result1 = Book.ComparePublicationDate(book1, book2);
            if (result1 == 1)
                Console.WriteLine("book1 újabb");
            else if (result1 == 2)
                Console.WriteLine("book2 újabb");
            else
                Console.WriteLine("A két könyv ugyanabban az évben jelent meg.");

            
            book2 = new Book("J.K. Rowling", "Harry Potter", 2008, 3500);
            book1 = new Book("Bán Mór", "Hunyadi");

            Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
            int result2 = Book.ComparePublicationDate(book1, book2);
            if (result2 == 1)
                Console.WriteLine("book1 újabb");
            else if (result2 == 2)
                Console.WriteLine("book2 újabb");
            else
                Console.WriteLine("A két könyv ugyanabban az évben jelent meg.");

           
            book2 = new Book("J.K. Rowling", "Harry Potter");
            book1 = new Book("Bán Mór", "Hunyadi");

            Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
            int result3 = Book.ComparePublicationDate(book1, book2);
            if (result3 == 1)
                Console.WriteLine("book1 újabb");
            else if (result3 == 2)
                Console.WriteLine("book2 újabb");
            else
                Console.WriteLine("A két könyv ugyanabban az évben jelent meg.");
        }
    }
}
