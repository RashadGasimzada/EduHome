#pragma checksum "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d009ad79fff3af6a1959a38ae9a8fdfd50e79beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\_ViewImports.cshtml"
using ASP.NET_Core_EduHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d009ad79fff3af6a1959a38ae9a8fdfd50e79beb", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d7cf99da114e41c6da78a115ba833bc7b75b1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SideBarVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-10 mb-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"single-blog-widget mb-50\">\n    <h3>categories</h3>\n    <ul>\n");
#nullable restore
#line 6 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
         foreach (var categorie in Model.CourseCategories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a href=\"#\">");
#nullable restore
#line 8 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
                       Write(categorie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 8 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
                                        Write(categorie.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\n");
#nullable restore
#line 9 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </ul>\n</div>\n<div class=\"single-blog-widget mb-50\">\n    <div class=\"single-blog-banner\">\n        <a href=\"blog-details.html\" id=\"blog\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d009ad79fff3af6a1959a38ae9a8fdfd50e79beb6800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 392, "~/assets/img/blog/", 392, 18, true);
#nullable restore
#line 16 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
AddHtmlAttributeValue("", 410, Model.Advertisments.Image, 410, 26, false);

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
            WriteLiteral("</a>\n        ");
#nullable restore
#line 17 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
   Write(Html.Raw(Model.Advertisments.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n<div class=\"single-blog-widget mb-50\">\n    <h3>latest post</h3>\n");
#nullable restore
#line 22 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
     foreach (var blog in Model.Blogs.Take(3))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-post\">\n            <div class=\"single-post-img\">\n                <a href=\"blog-details.html\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d009ad79fff3af6a1959a38ae9a8fdfd50e79beb9289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 784, "~/assets/img/post/", 784, 18, true);
#nullable restore
#line 27 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
AddHtmlAttributeValue("", 802, blog.PostImage, 802, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""blog-hover"">
                        <i class=""fa fa-link""></i>
                    </div>
                </a>
            </div>
            <div class=""single-post-content"">
                <h4><a href=""blog-details.html"">");
#nullable restore
#line 34 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
                                           Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n                <p>");
#nullable restore
#line 35 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
              Write(blog.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 35 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
                             Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n            </div>\n        </div>\n");
#nullable restore
#line 38 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"single-blog-widget\">\n    <h3>tags</h3>\n    <div class=\"single-tag\">\n");
#nullable restore
#line 43 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
         foreach (var tag in Model.Tags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d009ad79fff3af6a1959a38ae9a8fdfd50e79beb12813", async() => {
#nullable restore
#line 45 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"
                                                                             Write(tag.Name);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 46 "C:\Users\rasha\OneDrive\Рабочий стол\New folder\ASP.NET Core EduHome\ASP.NET Core EduHome\Views\Shared\Components\SideBar\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SideBarVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
