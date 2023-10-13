#pragma checksum "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748157e4ee1b35080b7fbd7f30abc4a6a5a6f613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Index), @"mvc.1.0.view", @"/Views/Address/Index.cshtml")]
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
#line 1 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748157e4ee1b35080b7fbd7f30abc4a6a5a6f613", @"/Views/Address/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa27564c578f8bd032750b8d5a0983009bfabfa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Address_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Adres Listesi</h4>\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 14 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                 if (Model.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>Açıklama 1</th>
                                <th>Açıklama 2</th>
                                <th>Açıklama 3</th>
                                <th>Açıklama 4</th>
                                <th>Güncelle</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 30 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                                   Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 31 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                                   Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                                   Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 33 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                                   Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1373, 2);
            WriteAttributeValue("", 1337, "/Address/EditAddress/", 1337, 21, true);
#nullable restore
#line 34 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
WriteAttributeValue("", 1358, item.AddressID, 1358, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 39 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""alert alert-danger"">
                        <strong>UYARI!</strong> Veri Tabanınızda Personel Bulunamamıştır.
                    </div>
                    <div class=""alert alert-warning"">
                        <strong>UYARI!</strong> Lütfen Personel Girişi Yapınız.
                    </div>
");
#nullable restore
#line 48 "C:\GitHub\.NetProjects\Project4-Agriculture-MVC-Core-CodeFirst\AgriculturePresentation\AgriculturePresentation\Views\Address\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <a href=\"/Employee/AddEmployee\" class=\"btn btn-outline-success\">Yeni Adres Girişi</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Address>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
