#pragma checksum "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b32976d848800e0b6faf4b3a7d5f99508237ff15d4d72d6a2611ecfca7233485", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineStore.Models.ViewModel.ProductViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<hr />\n<div>\n");
#nullable restore
#line 10 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
     if (Model.CanEditProduct)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a6943", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                                                                                WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 15 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" style=\"height: 300px\">\n        <img class=\"h-100\"");
            BeginWriteAttribute("src", " src=\"", 454, "\"", 492, 2);
            WriteAttributeValue("", 460, "/image/", 460, 7, true);
#nullable restore
#line 17 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 467, Model.Product.Image.Path, 467, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </div>\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Brand\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Model\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Description\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Category\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Price\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 48 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Rate\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
       Write(Model.Product.AverageRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Make rate\n        </dt>\n        <dd class=\"col-sm-10\">\n");
#nullable restore
#line 60 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
             if (User.Identity.IsAuthenticated) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                 if (!Model.Rated && Model.InPurchase)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input id=\"rate\" type=\"number\" max=\"5\" min=\"1\" value=\"0\" />\n                    <a id=\"arate\" class=\"btn btn-outline-info\"");
            BeginWriteAttribute("href", " href=\"", 1762, "\"", 1834, 4);
            WriteAttributeValue("", 1769, "/api/rate/", 1769, 10, true);
#nullable restore
#line 64 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1779, Model.Product.Id, 1779, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1796, "?rate=#&redirect=", 1796, 17, true);
#nullable restore
#line 64 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 1813, Context.Request.Path, 1813, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Rate</a>\n");
#nullable restore
#line 65 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input id=\"rate\" type=\"number\" max=\"0\" min=\"5\" alt=\"You can not rate the product\" value=\"0\" disabled />\n");
#nullable restore
#line 69 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                    if (Model.Rated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a id=\"delrate\" class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 2155, "\"", 2227, 4);
            WriteAttributeValue("", 2162, "/api/rate/remove/", 2162, 17, true);
#nullable restore
#line 71 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2179, Model.Product.Id, 2179, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2196, "?redirect=", 2196, 10, true);
#nullable restore
#line 71 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2206, Context.Request.Path, 2206, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">delete rate</a>\n");
#nullable restore
#line 72 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\n    </dl>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a16279", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <script>\n        $(\"#arate\").click(function () {\n            let rate = $(\"#rate\").val();\n            this.href = this.href.replace(\"#\", rate);\n        });\n    </script>\n    <div class=\"form-group\">\n");
#nullable restore
#line 85 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
             if (Model.InShopingCart)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Is already in shopping cart</p>\n                <a class=\"btn btn-dark\"");
            BeginWriteAttribute("href", " href=\"", 2813, "\"", 2885, 4);
            WriteAttributeValue("", 2820, "/api/cart/remove/", 2820, 17, true);
#nullable restore
#line 90 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2837, Model.Product.Id, 2837, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2854, "?redirect=", 2854, 10, true);
#nullable restore
#line 90 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 2864, Context.Request.Path, 2864, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove from shopping cart</a>\n");
#nullable restore
#line 91 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3004, "\"", 3073, 4);
            WriteAttributeValue("", 3011, "/api/cart/add/", 3011, 14, true);
#nullable restore
#line 94 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 3025, Model.Product.Id, 3025, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3042, "?redirect=", 3042, 10, true);
#nullable restore
#line 94 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 3052, Context.Request.Path, 3052, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add to shopping cart</a>\n");
#nullable restore
#line 95 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 98 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
     if ((bool)Model.Product.CommentsEnabled)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Comments ");
#nullable restore
#line 100 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                Write(Model.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a21209", async() => {
                WriteLiteral("\n");
#nullable restore
#line 102 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
             if (Model.InPurchase)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <fieldset>
                    <div class=""form-group"">
                        <label for=""disabledTextInput"">Comment</label>
                        <input type=""text"" style=""height:50px;"" rows=""4"" id=""commenttext"" class=""form-control"" placeholder=""Comment"">
                        <a id=""makecomment""");
                BeginWriteAttribute("href", " href=\"", 3619, "\"", 3697, 4);
                WriteAttributeValue("", 3626, "/api/comment/", 3626, 13, true);
#nullable restore
#line 108 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 3639, Model.Product.Id, 3639, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3656, "?comment=#&redirect=", 3656, 20, true);
#nullable restore
#line 108 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 3676, Context.Request.Path, 3676, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Send</a>\n                    </div>\n                </fieldset>\n");
#nullable restore
#line 111 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <fieldset disabled>
                    <div class=""form-group"">
                        <label for=""disabledTextInput"">Comment</label>
                        <input type=""text"" style=""height:50px;"" class=""form-control"" />
                        <button type=""submit"" class=""btn btn-primary"">Send</button>
                    </div>
                </fieldset>
");
#nullable restore
#line 121 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <script>
                $(""#makecomment"").click(function () {
                    let text = $(""#commenttext"").val();
                    if (!text) { return false; }
                    console.log(text);
                    this.href = this.href.replace(""#"", text);
                    console.log(this.href);
                });
            </script>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div class=\"container\">\n");
#nullable restore
#line 133 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
             if (Model.Comments.Count != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr />\n");
#nullable restore
#line 136 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                 foreach (var i in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"comment\">\n                        <p>");
#nullable restore
#line 139 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                      Write(i.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 139 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                                   Write(i.User.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    \n                        <p>");
#nullable restore
#line 141 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                      Write(i.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n");
#nullable restore
#line 143 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                    if (Model.CanEditComments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a58ad2f400594a82518a61e6293f0023ffda775161e95c1c232f96bfe78ef47a27096", async() => {
                WriteLiteral("Edit Comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                                    WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                                 WriteLiteral(i.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <hr />\n");
#nullable restore
#line 151 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 155 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Comments was disabled for this product</h4>\n");
#nullable restore
#line 159 "C:\Users\PMLS\Downloads\OnlineStore-master\OnlineStore-master\OnlineStore\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineStore.Models.ViewModel.ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
