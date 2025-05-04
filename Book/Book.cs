using System;

namespace book
{
    public class Book
    {
        private string author;
        private string title;
        private int yearOfPublication;
        private int price;

       
        public Book(string author, string title, int yearOfPublication, int price)
        {
            this.author = author;
            this.title = title;
            this.yearOfPublication = (yearOfPublication < 1950 || yearOfPublication > 2021) ? 2021 : yearOfPublication;
            this.price = (price < 1000) ? 1000 : price;
        }

        
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
            this.yearOfPublication = DateTime.Now.Year;
            this.price = 2500;
        }

        public int Price
        {
            get { return price; }
            set
            {
                
                price = (value < 1000) ? 1000 : value;
            }
        }

        public int YearOfPublication
        {
            get { return yearOfPublication; }
            set
            {
                
                yearOfPublication = (value < 1950 || value > 2021) ? 2021 : value;
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int GetPrice()
        { return Price; }

        public void SetPrice(int value)
        { Price = value; }

        public int GetYearOfPublication()
        { return YearOfPublication; }

        public void SetYearOfPublication(int value)
        { YearOfPublication = value; }

        public string GetTitle()
        { return Title; }

        public void SetTitle(string value)
        { Title = value; }

        public string GetAuthor()
        { return Author; }

        public void SetAuthor(string value)
        { Author = value; }

        public void IncreasePrice(int percentage)
        {
            if (percentage > 0)
                price += (int)Math.Round(price * percentage / 100.0);
        }

        
        public string DisplayInformation()
        {
            return author + ": " + title + ", " + yearOfPublication + ". Price: " + price + " Ft";
        }

        
        public override string ToString()
        {
            return DisplayInformation();
        }

        
        public static int ComparePublicationDate(Book book1, Book book2)
        {
            if (book1.yearOfPublication > book2.yearOfPublication)
                return 1;
            else if (book1.yearOfPublication < book2.yearOfPublication)
                return 2;
            else
                return 0;
        }
    }
}
