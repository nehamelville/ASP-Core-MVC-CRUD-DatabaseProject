#pragma checksum "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01272a9a9392b0ed7790026b69fcf6650bc45b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewProduct), @"mvc.1.0.view", @"/Views/Product/ViewProduct.cshtml")]
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
#line 1 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/_ViewImports.cshtml"
using Testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/_ViewImports.cshtml"
using Testing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01272a9a9392b0ed7790026b69fcf6650bc45b1f", @"/Views/Product/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018a65008c34fbd6017f4402c979ada59302986c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>");
#nullable restore
#line 5 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Information</h3>\n<table class=\"table\">\n    <tr>\n        <th>ProductID</th>\n        <th>Name</th>\n        <th>Price</th>\n        <th>CategoryID</th>\n        <th>On Sale</th>\n        <th>Stock Level</th>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 16 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 17 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 18 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 19 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 20 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.OnSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 21 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
       Write(Model.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n\n</table>\n<div style=\"display: block\">\n    <a");
            BeginWriteAttribute("href", " href=\"", 621, "\"", 667, 2);
            WriteAttributeValue("", 628, "/Product/UpdateProduct/", 628, 23, true);
#nullable restore
#line 26 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
WriteAttributeValue("", 651, Model.ProductID, 651, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update this Product</a>\n</div>\n\n<div style=\"display: block\">\n");
#nullable restore
#line 30 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
     using (Html.BeginForm("DeleteProduct", "Product", "Post"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01272a9a9392b0ed7790026b69fcf6650bc45b1f6005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
                                            WriteLiteral(Model.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <input type=\"submit\" onclick=\"return confirm(\'Are you sure?\')\" value=\"Delete this product\" />\n");
#nullable restore
#line 34 "/Users/neha.melville/Desktop/Repo/ASPNET/Testing/Views/Product/ViewProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
