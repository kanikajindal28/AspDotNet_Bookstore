using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            /*var obj = new{ id= 1 ,name ="Kanika"};
            return View("AboutUs",obj);*/
            /* return View("TempView/Index2.cshtml");*/
            /* return View("../../TempView/Index2"); //relative Path*/
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
