#pragma checksum "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4c9caec482ff8b632e1cadea53ed8c74e8764f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personas_Index), @"mvc.1.0.view", @"/Views/Personas/Index.cshtml")]
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
#line 1 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\_ViewImports.cshtml"
using ProyectoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\_ViewImports.cshtml"
using ProyectoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4c9caec482ff8b632e1cadea53ed8c74e8764f", @"/Views/Personas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0378b43b9232801b78718c0a3b25e112dceeb53c", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoWeb.Models.TbPersonas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\">\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb4c9caec482ff8b632e1cadea53ed8c74e8764f4480", async() => {
                WriteLiteral("Nuevo Cliente/Proveedor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n    <input id=\"controller\" type=\"hidden\" value=\"Personas\" />\r\n    <table id=\"tableInfo\" class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 11 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    RFC\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Entidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Codigo Postal\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </th>
                <th>
                    Correo
                </th>
                <th>
                    Nombre de la empresa
                </th>
                <th>
                    Tipo
                </th>
                <th>
                    ");
#nullable restore
#line 44 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Estado\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Entidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NombreEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 87 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                         if (item.ClienteProveedor == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>Cliente</a>\r\n");
#nullable restore
#line 90 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                        }
                        else if (item.ClienteProveedor == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>Proveedor</a>\r\n");
#nullable restore
#line 94 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 97 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 3459, "\"", 3518, 2);
            WriteAttributeValue("", 3464, "status-", 3464, 7, true);
#nullable restore
#line 99 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
WriteAttributeValue("", 3471, Html.DisplayFor( modelItem => item.IdPersona ), 3471, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 100 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                         if (item.Status == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button");
            BeginWriteAttribute("value", " value=\"", 3632, "\"", 3655, 1);
#nullable restore
#line 102 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
WriteAttributeValue("", 3640, item.IdPersona, 3640, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"baja btn btn-success\">Activo</button>\r\n");
#nullable restore
#line 103 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                        }
                        else if (item.Status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button");
            BeginWriteAttribute("value", " value=\"", 3844, "\"", 3867, 1);
#nullable restore
#line 106 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
WriteAttributeValue("", 3852, item.IdPersona, 3852, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alta btn btn-danger\">Inactivo</button>\r\n");
#nullable restore
#line 107 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb4c9caec482ff8b632e1cadea53ed8c74e8764f16125", async() => {
                WriteLiteral("<i class=\"icon-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
                                               WriteLiteral(item.IdPersona);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 113 "C:\Users\Eduar\source\repos\ProyectoWeb\ProyectoWeb\Views\Personas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoWeb.Models.TbPersonas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
