using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Repositories
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetOneBook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Author.Contains(authorName) || x.Title.Contains(title)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1 ,Title="Book1", Author="Kanika"},
                new BookModel(){Id =2 ,Title="Book2", Author="Kritika"},
                new BookModel(){Id =3 ,Title="Book3", Author="Karuna"},
                new BookModel(){Id =4 ,Title="Book4", Author="Hitesh"},
                new BookModel(){Id =5 ,Title="Book5", Author="Sanya"},
            };

        }

    }
}
