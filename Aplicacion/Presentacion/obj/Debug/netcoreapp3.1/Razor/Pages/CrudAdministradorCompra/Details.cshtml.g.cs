#pragma checksum "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a769b96ab7215f826439deaf1142b94fb86e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentacion.Pages.CrudAdministradorCompra.Pages_CrudAdministradorCompra_Details), @"mvc.1.0.razor-page", @"/Pages/CrudAdministradorCompra/Details.cshtml")]
namespace Presentacion.Pages.CrudAdministradorCompra
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
#line 1 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a769b96ab7215f826439deaf1142b94fb86e2f", @"/Pages/CrudAdministradorCompra/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182c3e91b32ea8a235c851f1e3419ceac5b361a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudAdministradorCompra_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>AdministradorCompra</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.CodigoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.CodigoEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.Sucursal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.Sucursal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdministradorCompra.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdministradorCompra.NumeroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a769b96ab7215f826439deaf1142b94fb86e2f10176", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\Usuarios\Documents\ProyectExito\ProyectoExito\Aplicacion\Presentacion\Pages\CrudAdministradorCompra\Details.cshtml"
                           WriteLiteral(Model.AdministradorCompra.AdministradorCompraId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a769b96ab7215f826439deaf1142b94fb86e2f12394", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentacion.Pages.CrudAdministradorCompra.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.CrudAdministradorCompra.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.CrudAdministradorCompra.DetailsModel>)PageContext?.ViewData;
        public Presentacion.Pages.CrudAdministradorCompra.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591