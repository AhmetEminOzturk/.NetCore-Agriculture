#pragma checksum "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0490800dcb8048748326b2abd12ab7abe4acb53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_Index), @"mvc.1.0.view", @"/Views/Image/Index.cshtml")]
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
#line 1 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0490800dcb8048748326b2abd12ab7abe4acb53e", @"/Views/Image/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Image_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Görsel Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 23 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                            <td class=\"py-1\"><img");
            BeginWriteAttribute("src", " src=\"", 890, "\"", 910, 1);
#nullable restore
#line 26 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
WriteAttributeValue("", 896, item.ImageUrl, 896, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" /></td>\r\n                            <td>");
#nullable restore
#line 27 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1017, "\"", 1056, 2);
            WriteAttributeValue("", 1024, "/Image/DeleteImage/", 1024, 19, true);
#nullable restore
#line 28 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
WriteAttributeValue("", 1043, item.ImageID, 1043, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1137, "\"", 1174, 2);
            WriteAttributeValue("", 1144, "/Image/EditImage/", 1144, 17, true);
#nullable restore
#line 29 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
WriteAttributeValue("", 1161, item.ImageID, 1161, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 31 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Image\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Image/AddImage/\" class=\"btn btn-outline-info\">Yeni Görsel Girişi</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
