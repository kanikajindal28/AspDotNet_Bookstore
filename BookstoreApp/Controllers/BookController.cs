using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreApp.Models;
using BookstoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    
    public class BookController : Controller
    {
        private readonly BookRepository bookrepo = null;
        public BookController()
        {
            bookrepo = new BookRepository();
        }
        public List<BookModel> getAllBooks()
        {
            return bookrepo.GetAllBooks();
           /* url used to get this is https://localhost:5001/book/getallbooks */
        }

        public BookModel getOneBook(int id)
        {
            /*$"Book with id : \n";*/
            return bookrepo.GetOneBook(id);
            /* url used to get this is https://localhost:5001/book/getonebook/2 */
        }

        public List<BookModel> searchBook(string bookName ,string authorName)
        {
            /*return $"book with name = {bookName} and author Name = {authorName}";*/
            return bookrepo.SearchBooks(bookName, authorName);
            /* url used to get this is https://localhost:5001/book/searchbook?bookName=MVC&authorName=kanika */
        }
    }
}
