#pragma checksum "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8175d8d0010d0ff801bdbb7f5784e42ae0df6dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8175d8d0010d0ff801bdbb7f5784e42ae0df6dd5", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df26dc013fcd8f29fe11b47c1e876fbdb36450e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessObjects.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
  
	ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            DefineSection("stylesheets", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8175d8d0010d0ff801bdbb7f5784e42ae0df6dd55344", async() => {
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
            WriteLiteral("\r\n<div class=\"pd-wrap\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t<div id=\"slider\"");
            BeginWriteAttribute("class", " class=\"", 264, "\"", 272, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<div class=\"item text-center\">\r\n\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 323, "\"", 345, 1);
#nullable restore
#line 15 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
WriteAttributeValue("", 329, Model.BookImage, 329, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50%\" width=\"50%\" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 19 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
              
				decimal PriceSale = Model.BookPrice - (Model.BookPrice * ((decimal)Model.SalePercent / 100m));
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t<div class=\"product-dtl\">\r\n\t\t\t\t\t<div class=\"product-info\">\r\n\t\t\t\t\t\t<div class=\"product-name\">");
#nullable restore
#line 25 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                             Write(Model.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t<div class=\"product-price-discount\">\r\n\t\t\t\t\t\t\t<span>$");
#nullable restore
#line 27 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                              Write(PriceSale.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 28 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                             if (@Model.BookPrice != PriceSale)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span class=\"line-through\">$");
#nullable restore
#line 30 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                                       Write(Model.BookPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t");
#nullable restore
#line 35 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                   Write(Model.BookDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</p>\r\n");
#nullable restore
#line 37 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                     if (Model.BookStock == 0)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\tOut of Stock\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 42 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\tStock: <span id=\"stock\">");
#nullable restore
#line 46 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                               Write(Model.BookStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 48 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"product-count\">\r\n\t\t\t\t\t\t<label for=\"size\" class=\"mb-2\">Quantity</label>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8175d8d0010d0ff801bdbb7f5784e42ae0df6dd511062", async() => {
                WriteLiteral(@"
							<div class=""d-flex"">
								<div class=""qtyminus"">-</div>
								<input type=""text"" readonly name=""quantity"" value=""1"" class=""qty"" />
								<div class=""qtyplus"">+</div>
							</div>
							<button type=""submit"" class=""round-black-btn"">Add to Cart</button>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                                                                 WriteLiteral(Model.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1392, "return", 1392, 6, true);
            AddHtmlAttributeValue(" ", 1398, "CheckStock(", 1399, 12, true);
#nullable restore
#line 51 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 1410, Model.BookStock, 1410, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1426, ")", 1426, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

					</div>
				</div>
			</div>
		</div>
		<div class=""product-info-tabs"">
			<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
				<li class=""nav-item"">
					<a class=""nav-link active"" id=""description-tab"" data-toggle=""tab"" href=""#description"" role=""tab""
					   aria-controls=""description"" aria-selected=""true"">Description</a>
				</li>
				<li class=""nav-item"">
					<a class=""nav-link"" id=""review-tab"" data-toggle=""tab"" href=""#review"" role=""tab""
					   aria-controls=""review"" aria-selected=""false"">Reviews (");
#nullable restore
#line 72 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                                                        Write(Model.Feedbacks.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a>
				</li>
			</ul>
			<div class=""tab-content"" id=""myTabContent"">
				<div class=""tab-pane fade show active"" id=""description"" role=""tabpanel""
					 aria-labelledby=""description-tab"">
					<div class=""col-lg-12 col-md-12 col-sm-12"">
						<h3 class=""box-title mt-5"">General Info</h3>
						<div class=""table-responsive"">
							<table class=""table table-striped table-product"">
								<tbody>
									<tr>
										<td width=""40%"" class=""fw-bold"">Genre</td>
										<td>");
#nullable restore
#line 85 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                       Write(Model.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td width=\"40%\" class=\"fw-bold\">Publisher</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 89 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                       Write(Model.Publisher.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td width=\"40%\" class=\"fw-bold\">Author</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 93 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                       Write(Model.Author.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td width=\"40%\" class=\"fw-bold\">Detail Description</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<p style=\"text-align: justify;\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 99 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                           Write(Model.BookDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
											</p>
										</td>
									</tr>
									<tr>
										<td width=""40%"" class=""fw-bold"">Delivery Condition</td>
										<td>Knock Down</td>
									</tr>
									<tr>
										<td width=""40%"" class=""fw-bold"">Type</td>
										<td>Book</td>
									</tr>
									<tr>
										<td width=""40%"" class=""fw-bold"">Upholstery Included</td>
										<td>Yes</td>
									</tr>
									<tr>
										<td width=""40%"" class=""fw-bold"">Upholstery Type</td>
										<td>Cushion</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
				</div>
				<div class=""tab-pane fade"" id=""review"" role=""tabpanel"" aria-labelledby=""review-tab"">
					<div class=""tab-content"" id=""myTabContent"">
						<h3 class=""box-title mt-5 mb-3"">Feedback from customer</h3>
");
#nullable restore
#line 127 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                         if (Model.Feedbacks.Count != 0)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"							<table class=""table table-striped table-product"">
								<thead class=""fw-bold"">
									<tr>
										<td width=""25%"">Full Name</td>
										<td width=""50%"">Content</td>
										<td width=""25%"">Date</td>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 138 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                     foreach (var feedback in Model.Feedbacks)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 141 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                           Write(feedback.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 141 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                                                    Write(feedback.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 142 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                           Write(feedback.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 143 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
                                           Write(feedback.FeedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 145 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\r\n\t\t\t\t\t\t\t</table>\r\n");
#nullable restore
#line 149 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<!-- if does not have any feedback -->\r\n\t\t\t\t\t\t\t<div class=\"fw-bold\">No feedback</div>\r\n");
#nullable restore
#line 154 "D:\1. Greenwich\1670 Application Development\Source_Code\FPTBookWebClient\Views\Home\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
		integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
		crossorigin=""anonymous""></script>
	<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
		integrity=""	sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
		crossorigin=""anonymous""></script>
	<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>
	<script>
		$(document).ready(function () {
			$("".qtyminus"").on(""click"", function () {
				var now = $("".qty"").val();
				if ($.isNumeric(now)) {
					if (parseInt(now) - 1 > 0) { now--; }
					$("".qty"").val(now);
				}
			})

			$("".qtyplus"").on(""click"", function () {
				var now = $("".qty"").val();
				var stock = document.getElementById('stock').innerHTML;
				if ($.isNumeric(now)) {
					if (parseInt(now");
                WriteLiteral(@") + 1 <= parseInt(stock)) { now++; }
					$("".qty"").val(now);
				}
			});
		});

		function CheckStock(stock) {
			if (parseInt(stock) === 0) {
				Swal.fire(
					'Out of Stock',
					'Out of stock, please choose another product',
					'warning'
				)
				return false;
			}
			return true;
		}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessObjects.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
