#pragma checksum "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Areas\AdminArea\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed61f21a93c1e89e9a60505a79b6f5a08cce7a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Category_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Category/Detail.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Asp.Net_end_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Areas\AdminArea\Views\_ViewImports.cshtml"
using Asp.Net_end_project.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed61f21a93c1e89e9a60505a79b6f5a08cce7a2", @"/Areas/AdminArea/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2387c33b306051546941b5e5bfbe0cb524530ac", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Areas\AdminArea\Views\Category\Detail.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/AdminArea/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"" style=""width:100% !important"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Categories Details</h4>
            <div class=""table-responsive pt-3"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Name
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                ");
#nullable restore
#line 24 "C:\Users\Emil Abdullayev\Desktop\Asp.Net-end-project\Asp.Net end project\Areas\AdminArea\Views\Category\Detail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
