#pragma checksum "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f01f2067941248c58c85524339b5cf3332ca4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elecciones_Elecciones), @"mvc.1.0.view", @"/Views/Elecciones/Elecciones.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elecciones/Elecciones.cshtml", typeof(AspNetCore.Views_Elecciones_Elecciones))]
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
#line 1 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\_ViewImports.cshtml"
using ItlaElector;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f01f2067941248c58c85524339b5cf3332ca4b", @"/Views/Elecciones/Elecciones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c4a648d3ab0fa21d24c31d82e563320db9f320", @"/Views/_ViewImports.cshtml")]
    public class Views_Elecciones_Elecciones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataBase.ViewModels.EleccionesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info ml-auto btn-group-sm rounded pt-1 mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:17px; font-family: \'Lemonada\', cursive; height:2%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control shadow-sm p-3 bg-white rounded-pill form-control-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingresar Nombre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingresar Fecha"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("datetimepicker4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Elecciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Elecciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white btn btn-danger shadow-lg ml-auto  btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:16px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(@"background: #000000;  /* fallback for old browsers */
background: -webkit-linear-gradient(to right, #434343, #000000);  /* Chrome 10-25, Safari 5.1-6 */
background: linear-gradient(to right, #434343, #000000); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
  
    ViewData["Title"] = "Elecciones";
    Layout = "~/Views/Shared/_LayoutStart.cshtml";

#line default
#line hidden
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(149, 11639, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5e2b11ab5f24c1682adfc66e608618b", async() => {
                BeginContext(446, 334, true);
                WriteLiteral(@"

    <header class=""container-fluid shadow position-relative fixed-top col-lg-pull-2 border-bottom bg-light"" id=""HeaderHome"">

        <div class=""row ml-4 p-1"">

            <div class=""font-weight-bolder pt-2"" style=""font-family: 'Lemonada', cursive;"">
                <h1>Elecciones</h1>
            </div>

            ");
                EndContext();
                BeginContext(780, 227, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f494ebf765446718fa4338d997255c5", async() => {
                    BeginContext(953, 50, true);
                    WriteLiteral("<i class=\"fa fa-home\" aria-hidden=\"true\"></i> Home");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1007, 2058, true);
                WriteLiteral(@"

        </div>

    </header>

    <div class=""container mt-5 d-flex justify-content-center table-responsive-lg table-responsive-sm"">


        <table class=""table table-hover shadow rounded table-borderless"">

            <thead class=""thead-primary shadow-sm"">
                <tr class=""bg-primary"">
                    <th scope=""col"" colspan=""3"">
                        <h2 class=""mr-auto text-white"" style=""font-family: 'Abril Fatface', cursive;""><i class=""fa fa-certificate"" style=""color:orange"" aria-hidden=""true""></i> Listado de Elecciones</h2>
                    </th>
                    <th scope=""col"" class=""text-center"">
                        <a data-toggle=""modal"" data-target=""#agregarNewPuesto"" class=""shadow-sm btn btn-success ml-auto btn-lg  text-white"" style=""margin-right:5px;"">Iniciar Nuevo Proceso Electivo</a>

                        <div class=""modal fade"" id=""agregarNewPuesto"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLab");
                WriteLiteral(@"el"" aria-hidden=""true"">
                            <div class=""modal-dialog modal-dialog-centered"">
                                <div class=""modal-content bg-success"">

                                    <div class=""modal-header bg-success text-white rounded-bottom shadow"">


                                        <div class="" mr-auto"">
                                            <h2 class=""modal-title""><i class=""fa fa-bar-chart"" aria-hidden=""true""></i> Agregar Elecciones</h2>
                                        </div>
                                        <div class="""">
                                            <button type=""button"" class=""btn btn-danger btn-sm text-white p-2 rounded-pill"" style=""font-size:14px;"" data-dismiss=""modal"" aria-label=""Close"">
                                                Cancelar
                                            </button>
                                        </div>

                                    </div>
                          ");
                WriteLiteral("          ");
                EndContext();
                BeginContext(3065, 2852, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f063a8b97704c378f6e24ca25b2fe11", async() => {
                    BeginContext(3137, 351, true);
                    WriteLiteral(@"
                                        <div class=""modal-body bg-light text-dark"">

                                            <div class=""form-group "">
                                                  <label class=""ml-3"" style=""font-family: 'Rowdies', cursive; font-size:15px;"">Nombre</label>
                                                ");
                    EndContext();
                    BeginContext(3488, 129, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d3b8e06c8604623ad1f119026ee1bfb", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 60 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nombre);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3617, 546, true);
                    WriteLiteral(@"
                                                <span class=""text-danger""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label class=""ml-3"" style=""font-family: 'Rowdies', cursive; font-size:15px;"">Fecha</label>
                                                <div class=""row"">
                                                    <div class='col-12'>
                                                        ");
                    EndContext();
                    BeginContext(4163, 148, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51b598b9f6804ed5941d04f2978c0433", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 68 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fecha);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4311, 62, true);
                    WriteLiteral("\r\n                                                    </div>\r\n");
                    EndContext();
                    BeginContext(4760, 1150, true);
                    WriteLiteral(@"                                                </div>
                                                <span class=""text-danger""></span>
                                            </div>



                                            <input type=""hidden"" name=""Estado"" value=""En Progreso"" />

                                            <div class=""form-group row mt-4"">
                                                <div class=""col"">
                                                    <input type=""submit"" value=""Agregar"" class=""btn btn-outline-success btn-block"" style=""font-family: 'Rowdies', cursive; font-size:15px;"" />
                                                </div>
                                                <div class=""col"">
                                                    <input type=""reset"" value=""Limpiar"" class=""btn btn-outline-warning btn-block"" style=""font-family: 'Rowdies', cursive; font-size:15px;"" />
                                                </div>
              ");
                    WriteLiteral("                              </div>\r\n\r\n                                        </div>\r\n\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5917, 695, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>


                    </th>

         

                </tr>
            </thead>

            <thead class=""table-info text-dark font-weight-light text-center"" style=""font-family: 'Abril Fatface', cursive; font-size:15px;"">
                <tr>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Fecha</th>
                    <th scope=""col"">Estado</th>
                    <th scope=""col"">Resultado</th>
                </tr>
            </thead>
            <tbody style=""font-size:14px; overflow-y: scroll"" class=""text-center"">
");
                EndContext();
#line 116 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                 foreach (var e in Model.elecciones)
                {

#line default
#line hidden
                BeginContext(6685, 76, true);
                WriteLiteral("                    <tr class=\"bg-light mt-3\">\r\n                        <td>");
                EndContext();
                BeginContext(6762, 38, false);
#line 119 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                       Write(Html.DisplayFor(ModelItem => e.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(6800, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(6836, 37, false);
#line 120 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                       Write(Html.DisplayFor(ModelItem => e.Fecha));

#line default
#line hidden
                EndContext();
                BeginContext(6873, 72, true);
                WriteLiteral("</td>\r\n                        <td class=\"text-info font-weight-bolder\">");
                EndContext();
                BeginContext(6946, 38, false);
#line 121 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                                                            Write(Html.DisplayFor(ModelItem => e.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(6984, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
                BeginContext(7082, 30, true);
                WriteLiteral("                        <td>\r\n");
                EndContext();
#line 124 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                             if (e.Estado == "Finalizado")
                            {
                                

#line default
#line hidden
                BeginContext(7254, 78, true);
                WriteLiteral("                                <a data-toggle=\"modal\" data-target=\"#resultado");
                EndContext();
                BeginContext(7334, 12, false);
#line 127 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                                                                          Write(e.IdEleccion);

#line default
#line hidden
                EndContext();
                BeginContext(7347, 133, true);
                WriteLiteral("\" class=\"text-link text-primary\" style=\"font-size:14px; \">Ver Resultado</a>\r\n                                <div class=\"modal fade \"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7480, "\"", 7509, 2);
                WriteAttributeValue("", 7485, "resultado", 7485, 9, true);
#line 128 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
WriteAttributeValue("", 7494, e.IdEleccion, 7494, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7510, 1340, true);
                WriteLiteral(@" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-sm"">
                                        <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                                            <div class=""modal-header bg-danger p-1 rounded"">

                                                <h5 class=""modal-title text-white font-weight-light mr-auto"" id=""staticBackdropLabel"" style=""font-family: 'Rowdies', cursive; font-size:20px;"">Eliminar</h5>

                                                <button type=""button"" class=""btn btn-primary btn-sm text-white p-1 rounded mt-2 shadow-sm"" style=""font-size:11px;"" data-dismiss=""modal"" aria-label=""Close"">
                                                    Cancelar
                                                </button>

                                            </div>

                             ");
                WriteLiteral(@"               <div class=""modal-body bg-light text-center"">
                                                <h4>¿SEGURO QUE QUIERE ELIMINAR ESTE CANDIDATO?</h4>

                                                <div class=""mt-4 d-flex justify-content-center"">
                                                    ");
                EndContext();
                BeginContext(8850, 172, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7682e8e71c7d4fa4af1f56622a76289b", async() => {
                    BeginContext(8972, 46, true);
                    WriteLiteral("<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9022, 246, true);
                WriteLiteral("\r\n\r\n                                                </div>\r\n\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 154 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"

                            }
                            else
                            {
                                

#line default
#line hidden
                BeginContext(9432, 73, true);
                WriteLiteral("                                <a data-toggle=\"modal\" data-target=\"#des-");
                EndContext();
                BeginContext(9507, 12, false);
#line 159 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                                                                     Write(e.IdEleccion);

#line default
#line hidden
                EndContext();
                BeginContext(9520, 157, true);
                WriteLiteral("\" class=\"btn btn-danger btn-sm text-white\" style=\"font-size:12px; \"><i class=\"fa fa-times-circle\" style=\"color:white\" aria-hidden=\"true\"></i> Finalizar</a>\r\n");
                EndContext();
                BeginContext(9679, 56, true);
                WriteLiteral("                                <div class=\"modal fade \"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 9735, "\"", 9759, 2);
                WriteAttributeValue("", 9740, "des-", 9740, 4, true);
#line 161 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
WriteAttributeValue("", 9744, e.IdEleccion, 9744, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9760, 1373, true);
                WriteLiteral(@" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog  modal-sm"">
                                        <div class=""modal-content bg-info  p-1 rounded"">

                                            <div class=""modal-header bg-info rounded"">

                                                <h5 class=""modal-title text-white font-weight-light mr-auto"" id=""staticBackdropLabel"" style=""font-family: 'Rowdies', cursive; font-size:20px;"">Advertencía!</h5>
                                                <button type=""button"" class=""btn btn-danger text-white p-1 rounded mt-2 shadow-sm"" style=""font-size:11px;"" data-dismiss=""modal"" aria-label=""Close"">
                                                    Cancelar
                                                </button>
                                            </div>

                                            <div clas");
                WriteLiteral(@"s=""modal-body bg-light text-center"">
                                                <h4 class=""text-dark"">¿Seguro que deseas  <span class=""text-danger"">Finalizar</span> estas Elecciones?</h4>


                                                <div class=""mt-4 d-flex justify-content-center"">
                                                    ");
                EndContext();
                BeginContext(11133, 212, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b03807c0cac84bcd90de5c55d2c6c593", async() => {
                    BeginContext(11250, 91, true);
                    WriteLiteral("<i class=\"fa fa-check-circle-o\" style=\"color:greenyellow\" aria-hidden=\"true\"></i> Finalizar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11345, 244, true);
                WriteLiteral("\r\n                                                </div>\r\n\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 185 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"

                            }

#line default
#line hidden
                BeginContext(11622, 68, true);
                WriteLiteral("                            </td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
                EndContext();
#line 192 "C:\Users\Pablo Molina\source\repos\ProyectoFinal\ItlaElector\Views\Elecciones\Elecciones.cshtml"
                }

#line default
#line hidden
                BeginContext(11709, 72, true);
                WriteLiteral("\r\n\r\n                </tbody>\r\n        </table>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_18);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11788, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataBase.ViewModels.EleccionesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
