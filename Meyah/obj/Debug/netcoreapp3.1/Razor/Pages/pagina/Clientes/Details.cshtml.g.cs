#pragma checksum "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a6ea79272c64c329e7e974dd76292d92ac5f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Meyah.Pages.pagina.Clientes.Pages_pagina_Clientes_Details), @"mvc.1.0.razor-page", @"/Pages/pagina/Clientes/Details.cshtml")]
namespace Meyah.Pages.pagina.Clientes
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
#line 1 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\_ViewImports.cshtml"
using Meyah;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a6ea79272c64c329e7e974dd76292d92ac5f80", @"/Pages/pagina/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7843b65d10051fb221273929a8e80ef20baf6afa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_pagina_Clientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
  
    Layout = "../Shared/Dise??o_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"hidden\">");
#nullable restore
#line 6 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
             Write(Model.Cliente.clienteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>       \r\n<h1 class=\"text-center\">Detalles Cliente</h1>\r\n<br />\r\n\r\n    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a6ea79272c64c329e7e974dd76292d92ac5f804255", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"col-md-5\"></div>\r\n    <a class=\"btn btn-info m-2\"");
                BeginWriteAttribute("href", " href=\"", 324, "\"", 380, 2);
                WriteAttributeValue("", 331, "/pagina/Clientes/Edit?id=", 331, 25, true);
#nullable restore
#line 14 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 356, Model.Cliente.clienteId, 356, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"> Editar</a> |
    <input class=""btn btn-danger m-2 "" id=""Submit1"" type=""submit"" name=""button"" value=""Eliminar"" />
    <div class=""col-md-5""></div>
    <br />

    

    <div class=""form-group"">
        <div class=""col-md-6"">
            <label for=""nombreProducto""><strong>Nombre:</strong></label>
            <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                BeginWriteAttribute("value", " value=\"", 771, "\"", 802, 1);
#nullable restore
#line 24 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 779, Model.Cliente.nombrecl, 779, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"">
            <span class=""text-danger""></span>
        </div>

        <div class="" col-md-6"">
            <label for=""exampleFormControlInput1""><strong>Apellido:</strong></label>
            <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                BeginWriteAttribute("value", " value=\"", 1091, "\"", 1124, 1);
#nullable restore
#line 30 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 1099, Model.Cliente.apellidocl, 1099, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"">
            <span class=""text-danger""></span>
        </div>
        <br />
        <br />
        <br />

    </div>
    

    <div class=""form-row"">

        <div class=""form-group col-md-4"">
            <label><strong>Direcci??n:</strong></label>
            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1461, "\"", 1493, 1);
#nullable restore
#line 44 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 1469, Model.Cliente.direccion, 1469, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
            <span class=""text-danger""></span>
        </div>
        
       

        <div class=""form-group col-md-4"">
            <label><strong>Tel??fono:</strong></label>
            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1752, "\"", 1783, 1);
#nullable restore
#line 52 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 1760, Model.Cliente.telefono, 1760, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
            <span class=""text-danger""></span>
        </div>
        

        <div class=""form-group col-md-4"">
            <label><strong>Fecha de nacimiento:</strong></label>
            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2044, "\"", 2097, 1);
#nullable restore
#line 59 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 2052, Model.Cliente.nacimiento.ToShortDateString(), 2052, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" />
            <span class=""text-danger""></span>
        </div>
        

    </div>
    

    <div class=""form-group"">

        <div class="" col-md-6"">
            <label for=""nombreProducto""><strong>Fecha de registro:</strong></label>
            <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                BeginWriteAttribute("value", " value=\"", 2449, "\"", 2498, 1);
#nullable restore
#line 71 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 2457, Model.Cliente.creado.ToShortDateString(), 2457, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"">
            <span class=""text-danger""></span>
        </div>
        <br />
    

        <div class=""col-md-6"">
            <label for=""exampleFormControlInput1""><strong>Fecha de modificaci??n:</strong></label>
            <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                BeginWriteAttribute("value", " value=\"", 2821, "\"", 2854, 1);
#nullable restore
#line 79 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Clientes\Details.cshtml"
WriteAttributeValue("", 2829, Model.Cliente.modificado, 2829, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled=\"disabled\">\r\n            <span class=\"text-danger\"></span>\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <br />\r\n    </div>\r\n    \r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meyah.Pages.pagina.Clientes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Clientes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Clientes.DetailsModel>)PageContext?.ViewData;
        public Meyah.Pages.pagina.Clientes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
