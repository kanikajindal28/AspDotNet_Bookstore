using BookstoreApp.Data;
using BookstoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Repositories
{
    public class BookRepository
    {
        public readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Books()
            {
                Author = bookModel.Author,
                createdOn = DateTime.UtcNow,
                Description = bookModel.Description,
                TotalPages = bookModel.TotalPages,
                updatedOn = DateTime.UtcNow,
                Title = bookModel.Title,
                Category = bookModel.Category
            };

            await _context.Books.AddAsync(newBook);
             await _context.SaveChangesAsync();

            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allbooks =await  _context.Books.ToListAsync();
            if(allbooks?.Any()==true)
            {
                foreach (var book in allbooks)
                {
                    books.Add(new BookModel()
                    {
                        Id=book.Id,
                        Author = book.Author,
                        Description = book.Description,
                        TotalPages = book.TotalPages,
                        Title = book.Title,
                        Category = book.Category,
                        Language = book.Language
                    }) ;
                }
            }
            return books;
        }
        public async Task<BookModel> GetOneBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if(book!=null)
            {
                var bookDetails = new BookModel()
                {
                    Id = book.Id,
                    Author = book.Author,
                    Description = book.Description,
                    TotalPages = book.TotalPages,
                    Title = book.Title,
                    Category = book.Category,
                    Language = book.Language
                };
                return bookDetails;
            }
            return null;
            /* OR var book = _context.Where(x => x.Id == id).FirstOrDefaultasync();*/
        }
        public List<BookModel> SearchBooks(string title,string authorName)
        {
            return DataSource().Where(x => x.Author.Contains(authorName) || x.Title.Contains(title)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1 ,Title="Book1", Author="Kanika",Description="This is my book number 1",Category="Programming" ,Language="English",TotalPages=138},
                new BookModel(){Id =2 ,Title="Book2", Author="Kritika",Description="This is my book number 2",Category="Programming" ,Language="English",TotalPages=139},
                new BookModel(){Id =3 ,Title="Book3", Author="Karuna",Description="This is my book number 3",Category="Programming" ,Language="English",TotalPages=140},
                new BookModel(){Id =4 ,Title="Book4", Author="Hitesh",Description="This is my book number 4",Category="Programming" ,Language="English",TotalPages=141},
                new BookModel(){Id =5 ,Title="Book5", Author="Sanya",Description="This is my book number 5",Category="Programming" ,Language="English",TotalPages=142},
            };

        }

    }
}
