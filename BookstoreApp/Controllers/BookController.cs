using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreApp.Data;
using BookstoreApp.Models;
using BookstoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.Controllers
{
    
    public class BookController : Controller
    {
        private readonly BookRepository bookrepo = null;
        public BookController(BookRepository bookRepository)
        {
            bookrepo = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await bookrepo.GetAllBooks();
            return View(data);
           /* url used to get this is https://localhost:5001/book/getallbooks */
        }

        public async Task<ViewResult> getOneBook(int id)
        {
            /*$"Book with id : \n";*/
            var data= await bookrepo.GetOneBook(id);
            return View(data);
            /* url used to get this is https://localhost:5001/book/getonebook/2 */
        }

        public List<BookModel> searchBook(string bookName ,string authorName)
        {
            /*return $"book with name = {bookName} and author Name = {authorName}";*/
            return bookrepo.SearchBooks(bookName, authorName);
            /* url used to get this is https://localhost:5001/book/searchbook?bookName=MVC&authorName=kanika */
        }
        public ViewResult AddNewBook(bool isSuccess = false,int bookId= 0)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.bookId = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            int id = await bookrepo.AddNewBook(bookModel);
            if(id>0)
            {
                return RedirectToAction("AddNewBook",new { isSuccess = true, bookId = id });
            }    
            return View();
        }
    }
}
