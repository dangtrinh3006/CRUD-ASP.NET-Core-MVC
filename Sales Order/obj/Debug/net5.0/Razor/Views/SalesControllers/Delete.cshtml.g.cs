#pragma checksum "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99116a852f91741f7a7ab8ead7b43b5d5ed8ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesControllers_Delete), @"mvc.1.0.view", @"/Views/SalesControllers/Delete.cshtml")]
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
#line 1 "C:\Users\dangt\source\repos\Sales Order\Views\_ViewImports.cshtml"
using Sales_Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dangt\source\repos\Sales Order\Views\_ViewImports.cshtml"
using Sales_Order.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99116a852f91741f7a7ab8ead7b43b5d5ed8ad3", @"/Views/SalesControllers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b4601ab33122e5f1d522223e92a879c2e0d746", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesControllers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sales_Order.Models.Sales>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header"">
                    <h1>Delete</h1>
                </div>
                <div class=""card-body"">
                    <h3>Are you sure you want to delete this?</h3>
                    <hr />

                    <div class=""row"">
                        <div class=""col-sm-4 font-weight-bold"">Sales Order:</div>
                        <div class=""col-sm-8"">");
#nullable restore
#line 20 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.SalesOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Sales Order Item:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 24 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.SalesOrderItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Work Order:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 28 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.WorkOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Product ID:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 32 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Product Description:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 36 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Order Quantity:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 40 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.OrderQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Order Status:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 44 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-4 font-weight-bold\">Timestamp:</div>\r\n                        <div class=\"col-sm-8\">");
#nullable restore
#line 48 "C:\Users\dangt\source\repos\Sales Order\Views\SalesControllers\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n\r\n                    <div class=\"text-center mt-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99116a852f91741f7a7ab8ead7b43b5d5ed8ad39069", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-danger mr-2\">Delete</button>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99116a852f91741f7a7ab8ead7b43b5d5ed8ad39456", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sales_Order.Models.Sales> Html { get; private set; }
    }
}
#pragma warning restore 1591