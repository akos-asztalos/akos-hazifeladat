using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
			Book book = new Book("Robert C. Martin", "Clean Code", 2008, 8500);
			//book.SetAuthor("Robert C. Martin");
			//book.SetTitle("Clean Code: A Handbook of Agile Software Craftsmanship");
			//book.SetYearOfPublication(2008);
			//book.SetPrice(8500);

			//book.Author = "Robert C. Martin";
			//book.Title = "Clean Code: A Handbook of Agile Software Craftsmanship";
			//book.YearOfPublication = 2008;
			//book.Price = 8500;

			Console.WriteLine(book.DisplayInformation());
			book.IncreasePrice(10);
			Console.WriteLine(book.DisplayInformation());
            Console.WriteLine(book);
            Console.WriteLine();

			// Test 1: book2 is newer
			Book book1 = new Book("J.K. Rowling", "Harry Potter", 2008, 3500);
			Book book2 = new Book("Bán Mór", "Hunyadi");

            Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
			//MEGOLDAS HELYE


			// Test 2: book1 is newer
			book2 = new Book("J.K. Rowling", "Harry Potter", 2008, 3500);
			book1 = new Book("Bán Mór", "Hunyadi");

			Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
			//MEGOLDAS HELYE

			// Test 3: book1 and book2 are published in the same year
			book2 = new Book("J.K. Rowling", "Harry Potter");
			book1 = new Book("Bán Mór", "Hunyadi");

			Console.WriteLine("Feladat: osszehasonlitani book1-et es book2-t!!!");
			//MEGOLDAS HELYE
		}
	}
}
