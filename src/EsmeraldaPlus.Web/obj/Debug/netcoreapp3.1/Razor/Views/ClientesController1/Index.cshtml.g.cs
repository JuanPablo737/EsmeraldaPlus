#pragma checksum "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c933e6c5c0f4499fa0deecab62a62bf11ddb662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClientesController1_Index), @"mvc.1.0.view", @"/Views/ClientesController1/Index.cshtml")]
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
#line 1 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\_ViewImports.cshtml"
using EsmeraldaPlus.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\_ViewImports.cshtml"
using EsmeraldaPlus.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c933e6c5c0f4499fa0deecab62a62bf11ddb662", @"/Views/ClientesController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0cf49ccd08657a636061ace1b2be34536fb198", @"/Views/_ViewImports.cshtml")]
    public class Views_ClientesController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EsmeraldaPlus.Core.Domain.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c933e6c5c0f4499fa0deecab62a62bf11ddb6623812", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodTelefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdRoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodTelefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdRoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 84 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 85 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 88 "C:\Users\USUARIO\EsmeraldaPlus\src\EsmeraldaPlus.Web\Views\ClientesController1\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EsmeraldaPlus.Core.Domain.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
