using System;
using System.Collections.Generic;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book book = new Book();
            book.NumberOfPages = 100;
            book.Title = "Fahrenheit 451";
            book.Id = 2;
            book.Display();

            Book book2 = new Book();

            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book2);

            Album album = new Album();
            album.Id = 3;
            album.Title = "Beatles";
            album.Tracks = 16;
            album.Display();

            List<Album> albums = new List<Album>();
            albums.Add(album);






            Media bk = new Book();
            Media alb = new Album();
            Media mov = new Movie();

            List<Media> media = new List<Media>();
            media.Add(bk);
            media.Add(alb);
            media.Add(mov);

            // CANNOT DO THIS
            //List<Book> bookList = new List<Book>();
            //bookList.Add(bk);
        }
    }
}
