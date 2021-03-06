#pragma checksum "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1ddaedba6368ff5cc47f8f05e6b8a706c684261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_getOneBook), @"mvc.1.0.view", @"/Views/Book/getOneBook.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 8 "D:\AspNet\BookstoreApp\BookstoreApp\Views\_ViewImports.cshtml"
using BookstoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ddaedba6368ff5cc47f8f05e6b8a706c684261", @"/Views/Book/getOneBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d65c7887259ac20bdece23a62891e0585185a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_getOneBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
  
    ViewData["Title"] = "Book Detail: " + Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Book Details</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""demo"" class=""carousel slide"" data-ride=""carousel"">

                <!-- Indicators -->
                <ul class=""carousel-indicators"">
                    <li data-target=""#demo"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#demo"" data-slide-to=""1""></li>
                    <li data-target=""#demo"" data-slide-to=""2""></li>
                </ul>

                <!-- The slideshow -->
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img ");
            WriteLiteral(" src=\"~/images/book/book1.jpg\" alt=\"image1\">\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <img ");
            WriteLiteral(" src=\"~/images/book/book2.jpg\" />\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <img ");
            WriteLiteral(@" src=""~/images/book/book3.jpg"" />
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class=""carousel-control-prev"" href=""#demo"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon""></span>
                </a>
                <a class=""carousel-control-next"" href=""#demo"" data-slide=""next"">
                    <span class=""carousel-control-next-icon""></span>
                </a>

            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 48 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12 text-primary"">
                    <span class=""col-form-label label-primary"">By:- </span>
                    <span class=""text-monospace"">");
#nullable restore
#line 54 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 \">\r\n                    <p class=\"description\">");
#nullable restore
#line 59 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4 "">
                    <button class=""btn btn-outline-primary"">Read Now!</button>
                </div>
            </div>

            <hr />

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span>");
#nullable restore
#line 71 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                                                        Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total Pages - </span>");
#nullable restore
#line 72 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                                                           Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language - </span>");
#nullable restore
#line 73 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                                                        Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <hr />\r\n    <div class=\"py-5 bg-light\" id=\"similarbooks\">\r\n        <h3 class=\"h3\">Similar Books</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 83 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
             for (int i = 0; i < 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4"">
                    <div class=""card-mb-4 shadow-sm"">
                        <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"">
                            <div class=""card-body"">
                                <h3 class=""card-title"">");
#nullable restore
#line 89 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 90 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                <div class=\"d-flex justify-content-between align-items-center\">\r\n                                    <div class=\"bth-group\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3984, "\"", 4017, 2);
            WriteAttributeValue("", 3991, "/book/getonebook/", 3991, 17, true);
#nullable restore
#line 93 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
WriteAttributeValue("", 4008, Model.Id, 4008, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">View Details</a>\r\n                                    </div>\r\n                                    <small class=\"text-muted\">");
#nullable restore
#line 95 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
                                                         Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n                        </svg>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 101 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Book\getOneBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
