#pragma checksum "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb95aa4ec54b45fedfa725fc53675618aa9f1c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb95aa4ec54b45fedfa725fc53675618aa9f1c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d65c7887259ac20bdece23a62891e0585185a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Production,Staging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
  
    dynamic data = ViewBag.Data;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb95aa4ec54b45fedfa725fc53675618aa9f1c33762", async() => {
                WriteLiteral("\r\n            <h3>Development</h3>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb95aa4ec54b45fedfa725fc53675618aa9f1c34996", async() => {
                WriteLiteral(" ");
                WriteLiteral("\r\n            <h3>Production</h3>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <h1>Welcome to the bookstore application! ");
#nullable restore
#line 13 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                             Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"lead text-muted\">\r\n            ");
#nullable restore
#line 15 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
       Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ID = ");
#nullable restore
#line 17 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
            Write(ViewBag.Type.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Author = ");
#nullable restore
#line 17 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
                                       Write(ViewBag.Type.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <br />
            Lorem Ipsum is simply dummy text of the printing and typesetting industry.
            Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
            when an unknown printer took a galley of type and scrambled it to make a type
            specimen book. It has survived not only five centuries, but also the leap into
            electronic typesetting, remaining essentially unchanged. It was popularised in
            the 1960s with the release of Letraset sheets containing Lorem Ipsum passages,
            and more recently with desktop publishing software like Aldus PageMaker including
            versions of Lorem Ipsum.
        </p>
        <p><a href=""#"" class=""btn btn-primary my-2"">Search books</a></p>
    </div>
</section>

<div class=""py-5 bg-light"">
    <div class=""container"">
        <h3 class=""my-3"">Top Books</h3>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm");
            WriteLiteral(@""">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000"">
                        <div class=""card-body"">
                            <p class=""card-text"">This section will ne used to display the short description of the book.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""bth-group"">
                                    <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                                </div>
                                <small class=""text-muted"">Author Name</small>
                            </div>
                        </div>
                    </svg>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/");
            WriteLiteral(@"2000"">
                        <div class=""card-body"">
                            <p class=""card-text"">This section will ne used to display the short description of the book.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""bth-group"">
                                    <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                                </div>
                                <small class=""text-muted"">Author Name</small>
                            </div>
                        </div>
                    </svg>
                </div>
            </div>

            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000"">
                        <div class=""card-body"">
                            <p class=""card-text"">This section w");
            WriteLiteral(@"ill ne used to display the short description of the book.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""bth-group"">
                                    <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details</a>
                                </div>
                                <small class=""text-muted"">Author Name</small>
                            </div>
                        </div>
                    </svg>
                </div>
            </div>
        </div>
    </div>
</div>




");
            WriteLiteral("\r\n<!--");
#nullable restore
#line 134 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
      
        var list = new List<int>() { 1, 2, 3, 4, 5,6 };
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 138 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
     foreach (var item in list)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 140 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 141 "D:\AspNet\BookstoreApp\BookstoreApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Message should be updated again</h1>\r\n    <img src=\"~/images/logo.png\" class=\"logo\" />\r\n\r\n<script>\r\n    $(document).ready(function () {-->\r\n");
            WriteLiteral("<!--});\r\n</script>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
