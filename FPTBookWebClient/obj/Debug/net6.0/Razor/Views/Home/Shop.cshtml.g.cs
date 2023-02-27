#pragma checksum "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 1 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\_ViewImports.cshtml"
using FPTBookWebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\_ViewImports.cshtml"
using FPTBookWebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15ffbbfc225e3d1ffd2c461a4478629e6526f0b", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df26dc013fcd8f29fe11b47c1e876fbdb36450e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObjects.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/shop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "displaybookbygenre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "displaybookbyauthor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-reset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
  
	ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            DefineSection("stylesheets", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b6515", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<section class=""container-fluid row my-3"">
	<nav class=""accordion arrows col-lg-2 col-md-3 custom-dropdown"">
		<!-- Navbar -->
		<nav class=""navbar navbar-expand-md navbar-light bg-info rounded"">
			<!-- Toggle button -->
			<button class=""navbar-toggler ms-2"" type=""button"" data-toggle=""collapse"" data-target=""#sidebarMenu"">
				<span class=""navbar-toggler-icon""></span>
			</button>

			<!-- Brand -->
			<a class=""text-white"" style=""text-decoration: none;"" href=""/"">
				<h3 class=""fw-bold mx-3"">FPT Book</h3>
			</a>
		</nav>
		<!-- Navbar -->
		<nav id=""sidebarMenu"" class=""collapse d-md-block bg-white"">
			<input type=""radio"" name=""accordion"" id=""cb1"" />
			<section class=""box"">
				<label class=""all-book"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b8520", async() => {
                WriteLiteral("All Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</label>\r\n\t\t\t</section>\r\n\t\t\t<input type=\"radio\" name=\"accordion\" id=\"cb2\" />\r\n\t\t\t<section class=\"box\">\r\n\t\t\t\t<label class=\"box-title\" for=\"cb2\">Genre</label>\r\n\t\t\t\t<label class=\"box-close\" for=\"acc-close\"></label>\r\n");
#nullable restore
#line 32 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                 foreach (var genre in ViewBag.Genre)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"box-content\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b10544", async() => {
#nullable restore
#line 35 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                                                         Write(genre.GenreName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-genreId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                 WriteLiteral(genre.GenreId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genreId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-genreId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genreId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</section>\r\n\t\t\t<input type=\"radio\" name=\"accordion\" id=\"cb3\" />\r\n\t\t\t<section class=\"box\">\r\n\t\t\t\t<label class=\"box-title\" for=\"cb3\">Author</label>\r\n\t\t\t\t<label class=\"box-close\" for=\"acc-close\"></label>\r\n");
#nullable restore
#line 43 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                 foreach (var author in ViewBag.Author)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"box-content\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b13921", async() => {
#nullable restore
#line 46 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                                                             Write(author.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-authorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                   WriteLiteral(author.AuthorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["authorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-authorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["authorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 48 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</section>\r\n\t\t\t<input type=\"radio\" name=\"accordion\" id=\"acc-close\" />\r\n\t\t</nav>\r\n\t</nav>\r\n\t<div class=\"col-lg-10 col-md-9 col-12\">\r\n\t\t<div class=\"text-center\">\r\n\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 56 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                 foreach (var book in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-xl-2 col-lg-3 col-md-4 col-sm-6 col-12 mb-4\">\r\n\t\t\t\t\t\t<div class=\"card\">\r\n\t\t\t\t\t\t\t<div class=\"bg-image hover-zoom ripple\" data-mdb-ripple-color=\"light\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2228, "\"", 2249, 1);
#nullable restore
#line 61 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
WriteAttributeValue("", 2234, book.BookImage, 2234, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\" />\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b17873", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"mask\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"d-flex justify-content-start align-items-end h-100\">\r\n\t\t\t\t\t\t\t\t\t\t\t<h5>\r\n");
#nullable restore
#line 66 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                 if (DateTime.Compare(book.BookLastUpdated.AddDays(7), DateTime.Now) > 0)
												{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-primary ms-2\">New</span>\r\n");
#nullable restore
#line 69 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
												}

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                 if (book.SalePercent != 0)
												{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-danger ms-2\">-");
#nullable restore
#line 72 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                                   Write(book.SalePercent);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</span>\r\n");
#nullable restore
#line 73 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
												}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"hover-overlay\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"mask\" style=\"background-color: rgba(251, 251, 251, 0.15);\">\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                               WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b22399", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<h5 class=\"card-title mb-3\">");
#nullable restore
#line 85 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                           Write(book.BookTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                               WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15ffbbfc225e3d1ffd2c461a4478629e6526f0b25282", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 88 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                  Write(book.Genre.GenreName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                               WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<h6 class=\"mb-3\">\r\n");
#nullable restore
#line 91 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                      
										decimal PriceSale = book.BookPrice - (book.BookPrice * ((decimal)book.SalePercent / 100m));
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                     if (book.BookPrice != PriceSale)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<s>$");
#nullable restore
#line 96 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                       Write(book.BookPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</s>\r\n");
#nullable restore
#line 97 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<strong class=\"ms-2 text-danger\">$");
#nullable restore
#line 98 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
                                                                 Write(PriceSale.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t\t</h6>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 103 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Shop.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
	<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
	<script type=""text/javascript"">
		$('.custom-dropdown').on('show.bs.dropdown', function () {
			var that = $(this);
			setTimeout(function () {
				that.find('.dropdown-menu').addClass('active');
			}, 100);


		});

		$('.custom-dropdown').on('hide.bs.dropdown', function () {
			$(this).find('.dropdown-menu').removeClass('active');
		});
	</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObjects.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
