#pragma checksum "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92d4b475be8ad92dc97c5bb79180ef1112536bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Meyah.Pages.pagina.Tareas.Pages_pagina_Tareas_Details), @"mvc.1.0.razor-page", @"/Pages/pagina/Tareas/Details.cshtml")]
namespace Meyah.Pages.pagina.Tareas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92d4b475be8ad92dc97c5bb79180ef1112536bd", @"/Pages/pagina/Tareas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7843b65d10051fb221273929a8e80ef20baf6afa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_pagina_Tareas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
  
    Layout = "../Shared/Dise??o_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"hide\">");
#nullable restore
#line 7 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
            Write(Model.Tarea.tareaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1 class=\"text-center\">Detalles Tarea</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a92d4b475be8ad92dc97c5bb79180ef1112536bd4001", async() => {
                WriteLiteral("\r\n    <div class=\"col-md-3\"></div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a92d4b475be8ad92dc97c5bb79180ef1112536bd4301", async() => {
                    WriteLiteral("\r\n\r\n        <div class=\"col-md-7\"></div>\r\n                <a class=\"btn btn-info\"");
                    BeginWriteAttribute("href", " href=\"", 340, "\"", 390, 2);
                    WriteAttributeValue("", 347, "/pagina/Tareas/Edit?id=", 347, 23, true);
#nullable restore
#line 14 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 370, Model.Tarea.tareaId, 370, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"> Editar</a> |
                <input class=""btn btn-danger"" id=""Submit1"" type=""submit"" name=""button"" value=""Eliminar"" />
        <div class=""col-md-7""></div>
        <br />

        <div class=""form-row"">
            <div class="" form-group col-md-12"">
                <label for=""nombreProducto""><strong>Descripci??n:</strong></label>
                <textarea class=""form-control"" rows=""5"" cols=""20""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 800, "\"", 838, 1);
#nullable restore
#line 22 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 814, Model.Tarea.descripcion, 814, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled""></textarea>

            </div>
        </div>

        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label><strong>Fecha de Inicio:</strong></label>
                <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 1113, "\"", 1145, 1);
#nullable restore
#line 30 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 1121, Model.Tarea.fechainicio, 1121, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group col-md-6"">
                <label><strong>Fecha de Entrega:</strong></label>
                <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 1411, "\"", 1444, 1);
#nullable restore
#line 35 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 1419, Model.Tarea.fechaentrega, 1419, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                <span class=""text-danger""></span>
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label><strong>Fecha de creaci??n:</strong></label>
                <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 1759, "\"", 1786, 1);
#nullable restore
#line 42 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 1767, Model.Tarea.creado, 1767, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group col-md-6"">
                <label><strong>Fecha de Modificaci??n:</strong></label>
                <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 2057, "\"", 2088, 1);
#nullable restore
#line 47 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 2065, Model.Tarea.modificado, 2065, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                <span class=""text-danger""></span>
            </div>
        </div>
        <div class=""form-row"">
            <div class="" form-group col-md-6"">
                <label for=""nombreProducto""><strong>Pedido ID</strong></label>
                <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                    BeginWriteAttribute("value", " value=\"", 2446, "\"", 2475, 1);
#nullable restore
#line 54 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 2454, Model.Tarea.pedidoId, 2454, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" disabled=\"disabled\">\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label><strong>Empleado ID:</strong></label>\r\n                <input type=\"text\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2683, "\"", 2714, 1);
#nullable restore
#line 58 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Tareas\Details.cshtml"
WriteAttributeValue("", 2691, Model.Tarea.empleadoId, 2691, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                <span class=""text-danger""></span>
            </div>
        </div>
        <!--
      <div class=""col py-3 px-lg-5 border bg-light""> <button type=""submit"" class=""btn btn-round btn-warning col-lg-3"">Eliminar</button></div>
    <div class=""col py-3 px-lg-5 border bg-light""><button type=""submit"" class=""btn btn-round btn-danger col-lg-3"">Cancelar</button></div>-->

        <div class=""col-md-3""></div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meyah.Pages.pagina.Tareas.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Tareas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Tareas.DetailsModel>)PageContext?.ViewData;
        public Meyah.Pages.pagina.Tareas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
