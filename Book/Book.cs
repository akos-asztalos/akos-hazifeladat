using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    //Egészítse ki a definiált Könyv osztályt 2 konstruktorral.
    //Az egyik konstruktornak a könyv minden adatát meg kell adni, 
    //a másiknak csak a szerzőt és a címet, az ár 2500 Ft, a megjelenés éve pedig az aktuális év.
    //Definiálja felül a ToString metódust a DisplayInformation metódus tartalmával.
    //Írjon osztályszintű összehasonlító metódust(ComparePublicationDate), 
    //amely 1-et ad vissza, ha az első paraméterként megadott könyv az újabb, 
    //2-t ha a második, és 0-t, ha ugyanabban az évben jelentek meg.

    //Értékadás előtti ellenőrzések:
    //- a megjelenés éve, ha nem 1950 és 2021 között van, legyen 2021, egyébként a megadott érték
    //- az ár legyen 1000 forint 1000-nél kisebb értékekre, egyébként a megadott érték

    //Módosítsa a Könyv osztályt használó osztályt ennek megfelelően.
    //A BookTest osztályban hozzon létre 2 könyvet (a 2 konstruktort felhasználva) és
    //jelenítse meg az adataikat a ToString metódust használva.
    //Hasonlítsa össze a két könyv megjelenési évét.

    public class Book
    {
        private string author;
        private string title;
        private int yearOfPublication;
        private int price;

        public int Price
        {
            get { return price; }
            set 
            {
                //Értékadás előtti ellenőrzés:
                //- az ár legyen 1000 forint 1000-nél kisebb értékekre, egyébként a megadott érték
                price = value; 
            }
        }

        public int YearOfPublication
        {
            get { return yearOfPublication; }
            set 
            {
                //Értékadás előtti ellenőrzés:
                //- a megjelenés éve, ha nem 1950 és 2021 között van, legyen 2021, egyébként a megadott érték
                yearOfPublication = value; 
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
                price +=  (int)Math.Round(price * percentage / 100.0);
        }

        public string DisplayInformation()
        {
            return author + ": " + title + ", " + yearOfPublication + ". Price: " + price + " Ft";
        }


    }
}
