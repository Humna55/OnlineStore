#pragma checksum "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13bcbb92820287d31dc13e4a274544744aed8464dc11faa2fbce2407ea9bc7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"13bcbb92820287d31dc13e4a274544744aed8464dc11faa2fbce2407ea9bc7ed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b32976d848800e0b6faf4b3a7d5f99508237ff15d4d72d6a2611ecfca7233485", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineStore.Models.Database.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<div class=\"container\">\n    <a href=\"/filter\">Filtered search</a>\n</div>\n<br />\n<div class=\"card-columns\">\n");
#nullable restore
#line 11 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Home\Index.cshtml"
     foreach (var i in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_CardProduct", i));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Home\Index.cshtml"
                                                   ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineStore.Models.Database.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
