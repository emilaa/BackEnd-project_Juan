#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\_ViewImports.cshtml"
using Asp.Net_end_project.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d6", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c707f3425efd93b446e5e6ebb261fbf9192a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("author thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main wrapper start -->
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Blog</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Blog Left Sidebar</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- blog main wrapper start -->
    <div class=""blog-main-wrapper section-padding"">
        <div cl");
            WriteLiteral("ass=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-3 order-2 order-lg-1\">\r\n                    <div class=\"blog-widget-wrapper\">\r\n                        <!-- widget item start -->\r\n");
#nullable restore
#line 35 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                         foreach (var item in Model.Customers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"blog-widget\">\r\n                                <div class=\"blog-widget-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d68071", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1556, "~/assets/img/blog/", 1556, 18, true);
#nullable restore
#line 39 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1574, item.Image, 1574, 11, false);

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
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"blog-author-title text-center\">\r\n                                    <h5>");
#nullable restore
#line 42 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                   Write(item.BlogAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <span>");
#nullable restore
#line 43 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                     Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <div class=\"blog-widget-icon\">\r\n");
#nullable restore
#line 45 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                         foreach (var icon in item.Socials)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 2103, "\"", 2128, 3);
            WriteAttributeValue("", 2111, "fa", 2111, 2, true);
            WriteAttributeValue(" ", 2113, "fa-", 2114, 4, true);
#nullable restore
#line 48 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2117, icon.Image, 2117, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 49 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 53 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- widget item end -->\r\n                        <!-- widget item start -->\r\n                        <div class=\"blog-widget\">\r\n                            <h4 class=\"blog-widget-title\">Search</h4>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d612290", async() => {
                WriteLiteral("\r\n                                <input placeholder=\"Search keyword\" type=\"text\" class=\"search-field\">\r\n                                <button type=\"submit\" class=\"search-btn\"><i class=\"fa fa-search\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Recent Posts</h4>
                            <ul class=""recent-posts-inner"">
");
#nullable restore
#line 68 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                 foreach (var item in Model.ResentPosts)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"recent-posts\">\r\n                                        <div class=\"recent-posts-image\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d614699", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d614916", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3566, "~/assets/img/blog/", 3566, 18, true);
#nullable restore
#line 72 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 3584, item.Image, 3584, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                                WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"recent-posts-body\">\r\n                                            <span class=\"recent-posts-meta\">");
#nullable restore
#line 75 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                       Write(item.CreateDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <h6 class=\"recent-posts-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d619331", async() => {
#nullable restore
#line 76 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                                                               WriteLiteral(item.Id);

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
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 79 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Categories</h4>
                            <ul class=""blog-categories"">
                                <li><a href=""blog-details.html"">Shoes</a><span>(20)</span></li>
                                <li><a href=""blog-details.html"">Fashion</a><span>(18)</span></li>
                                <li><a href=""blog-details.html"">Wallet</a><span>(40)</span></li>
                                <li><a href=""blog-details.html"">Life Style</a><span>(66)</span></li>
                                <li><a href=""blog-details.html"">Electronics</a><span>(66)</span></li>
                                <li><a href=""blog-details.html"">Jewellery & Cosmetics</a><span>(30)</span></li>
                            </ul>
                        ");
            WriteLiteral(@"</div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Tags</h4>
                            <div class=""blog-tag"">
");
#nullable restore
#line 100 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                 foreach (var tag in Model.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d624147", async() => {
#nullable restore
#line 102 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                 Write(tag.TagName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <!-- widget item end -->
                    </div>
                </div>
                <div class=""col-lg-9 order-1 order-lg-2"">
                    <div class=""row"">
");
#nullable restore
#line 112 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                         foreach (var item in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-6"">
                                <!-- blog single item start -->
                                <div class=""blog-post-item mb-30"">
                                    <div class=""blog-thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d626860", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d627160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6484, "~/assets/img/blog/", 6484, 18, true);
#nullable restore
#line 119 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 6502, item.Image, 6502, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"blog-content\">\r\n                                        <h5 class=\"blog-title\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d85b9cda1f1f5d68acca1c89c1fa94ac99c4d631256", async() => {
                WriteLiteral("\r\n                                                ");
#nullable restore
#line 125 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                                                                WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                        </h5>\r\n                                        <ul class=\"blog-meta\">\r\n                                            <li><span>By: </span>");
#nullable restore
#line 129 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                            Write(item.Admin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li><span>On: </span>");
#nullable restore
#line 130 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                                                            Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                        </ul>
                                        <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                                    </div>
                                </div>
                                <!-- blog single item start -->
                            </div>
");
#nullable restore
#line 137 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-6"">
                            <!-- blog single item start -->
                            <div class=""blog-post-item mb-30"">
                                <div class=""blog-thumb embed-responsive embed-responsive-16by9"">
                                    <iframe src=""https://www.youtube.com/embed/4qNHr0W6F0o"" allow=""autoplay; encrypted-media"" allowfullscreen></iframe>
                                </div>
                                <div class=""blog-content"">
                                    <h5 class=""blog-title"">
                                        <a href=""blog-details.html"">
                                            Children Left Home Alone For 4 Days In TV Series Experiment
                                        </a>
                                    </h5>
                                    <ul class=""blog-meta"">
                                        <li><span>By: </span>Admin,</li>
                                        <");
            WriteLiteral(@"li><span>On: </span>14.07.2029</li>
                                    </ul>
                                    <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                                </div>
                            </div>
                            <!-- blog single item start -->
                        </div>
                        <div class=""col-md-6"">
                            <!-- blog single item start -->
                            <div class=""blog-post-item mb-30"">
                                <div class=""blog-thumb embed-responsive embed-responsive-16by9"">
                                    <iframe src=""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/501298839&amp;color=%23ff5500&amp;auto_play=false&amp;hide_related=true&amp;show_comments=false&amp;show_user=true&amp;show_reposts=false&amp;show_teaser=true&amp;visual=true""></iframe>
                                </div>
                                <div class=""blog-conten");
            WriteLiteral(@"t"">
                                    <h5 class=""blog-title"">
                                        <a href=""blog-details.html"">
                                            People Are Willing Lie When To Comes Money Research from
                                        </a>
                                    </h5>
                                    <ul class=""blog-meta"">
                                        <li><span>By: </span>Admin,</li>
                                        <li><span>On: </span>14.07.2029</li>
                                    </ul>
                                    <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                                </div>
                            </div>
                            <!-- blog single item start -->
                        </div>

                    </div>
                    <!-- start pagination area -->
                    <div class=""paginatoin-area text-center"">
                        <ul ");
            WriteLiteral(@"class=""pagination-box"">
                            <li><a class=""Previous"" href=""#""><i class=""ion-ios-arrow-left""></i></a></li>
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a class=""Next"" href=""#""><i class=""ion-ios-arrow-right""></i></a></li>
                        </ul>
                    </div>
                    <!-- end pagination area -->
                </div>
            </div>
        </div>
    </div>
    <!-- blog main wrapper end -->
</main>
<!-- main wrapper end -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
