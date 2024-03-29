#pragma checksum "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2c570da591c7df188c2d87defaf59f684f8e2b55f3d0075dc53e46400534375c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Products), @"mvc.1.0.view", @"/Views/Admin/Products.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2c570da591c7df188c2d87defaf59f684f8e2b55f3d0075dc53e46400534375c", @"/Views/Admin/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b32976d848800e0b6faf4b3a7d5f99508237ff15d4d72d6a2611ecfca7233485", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineStore.Models.ViewModel.AdminProducts>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Products</h1>\n<style>\n    .btn a {\n        margin-left: 3px;\n    }\n</style>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <td>Name</td>\n            <td>Owner</td>\n            <td>Actions</td>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 22 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
         foreach (var i in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 503, "\"", 524, 2);
            WriteAttributeValue("", 510, "/product/", 510, 9, true);
#nullable restore
#line 26 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
WriteAttributeValue("", 519, i.Id, 519, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
                                        Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </td>\n                <td>\n                    ");
#nullable restore
#line 29 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
               Write(i.CreatorUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
                                      Write(i.CreatorUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 730, "\"", 793, 4);
            WriteAttributeValue("", 737, "/api/product/remove/", 737, 20, true);
#nullable restore
#line 32 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
WriteAttributeValue("", 757, i.Id, 757, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 762, "?redirect=", 762, 10, true);
#nullable restore
#line 32 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
WriteAttributeValue("", 772, Context.Request.Path, 772, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a>\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 849, "\"", 875, 2);
            WriteAttributeValue("", 856, "/product/edit/", 856, 14, true);
#nullable restore
#line 33 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
WriteAttributeValue("", 870, i.Id, 870, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 36 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Admin\Products.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div class=\"container\">\n    <a class=\"btn btn-outline-success\" href=\"/product/edit/-10\">\n        New\n    </a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineStore.Models.ViewModel.AdminProducts> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
