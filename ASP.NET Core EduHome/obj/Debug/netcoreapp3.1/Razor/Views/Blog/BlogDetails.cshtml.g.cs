#pragma checksum "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a844feef15229716ca2dda2ede6ef0fbe9770ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
#line 1 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a844feef15229716ca2dda2ede6ef0fbe9770ec", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d7cf99da114e41c6da78a115ba833bc7b75b1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>blog details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""blog-details-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""blog-details"">
                    <div class=""blog-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a844feef15229716ca2dda2ede6ef0fbe9770ec6770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 871, "~/assets/img/blog/", 871, 18, true);
#nullable restore
#line 30 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
AddHtmlAttributeValue("", 889, Model.Blog.Image, 889, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"blog-details-content\">\n                        <h2>");
#nullable restore
#line 33 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                       Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n                        <h6>");
#nullable restore
#line 34 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                       Write(Model.Blog.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 34 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                                            Write(Model.Blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> 4</h6>\n                        <p> ");
#nullable restore
#line 35 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                       Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p>");
#nullable restore
#line 36 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                      Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p>");
#nullable restore
#line 37 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
                      Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a844feef15229716ca2dda2ede6ef0fbe9770ec10582", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message</span></a>
     ");
                WriteLiteral("                       <p class=\"form-messege\"></p>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-47"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a844feef15229716ca2dda2ede6ef0fbe9770ec13691", async() => {
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                    ");
#nullable restore
#line 78 "C:\Users\rasha\OneDrive\Рабочий стол\EduHome\ASP.NET Core EduHome\Views\Blog\BlogDetails.cshtml"
               Write(await Component.InvokeAsync("SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Blog End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
