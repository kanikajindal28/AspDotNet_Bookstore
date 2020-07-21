using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using BookstoreApp.Models;
using System.Globalization;

namespace BookstoreApp.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            /*var obj = new{ id= 1 ,name ="Kanika"};
            return View("AboutUs",obj);*/
            /* return View("TempView/Index2.cshtml");*/
            /* return View("../../TempView/Index2"); //relative Path*/


            /*ViewBag.Title = "Home";*/

            Title = "Home from controller";
             

            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "kanika";
            ViewBag.Data = data;

            ViewBag.Type = new BookModel() { Id = 2, Author = "This is Author" };
            return View();
        }

        public ViewResult AboutUs()
        {
            ViewData["Property1"] = "Kanika Jindal";

            ViewData["book"] = new BookModel() { Id = 3, Author = "This is Author's Name" };
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
