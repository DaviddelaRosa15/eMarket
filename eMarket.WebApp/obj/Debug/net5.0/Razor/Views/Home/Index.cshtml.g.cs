#pragma checksum "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f28f7e281c05322633c9555582997e44b9665de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\_ViewImports.cshtml"
using eMarket.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\_ViewImports.cshtml"
using eMarket.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
using eMarket.Core.Application.ViewModels.Articles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
using eMarket.Core.Application.ViewModels.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28f7e281c05322633c9555582997e44b9665de4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445a8200585d1e7a20287503c35a4951a30a8e4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-dark details-hov"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-3"">
            <div class=""card shadow-sm"">
                <div class=""card-header text-light bgfondoCardHeader"">
                    <h4>Filtros</h4>
                </div>
                <div class=""card-body text-dark bgfondoCard"">
                    <h4 class=""card-title"">Categorias</h4>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28f7e281c05322633c9555582997e44b9665de46017", async() => {
                WriteLiteral(@"

                        <div class=""mb-3"">
                            <div class=""form-check"">
                                <input class=""form-check-input fs-5"" value=""0"" type=""radio"" name=""CategoryId"" id=""category-all"" onchange=""unSelectChecks()"" />
                                <label class=""form-check-label fs-5"" for=""category-all"">Todas</label>
                            </div>
                        </div>

");
#nullable restore
#line 27 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                         foreach (CategoryViewModel category in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"mb-3 justify-content-center\">\r\n                                <div class=\"form-check\">\r\n                                    <input class=\"form-check-input fs-5\"");
                BeginWriteAttribute("value", " value=\"", 1401, "\"", 1421, 1);
#nullable restore
#line 31 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1409, category.Id, 1409, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"checkbox\" name=\"CategoryId\"");
                BeginWriteAttribute("id", " id=\"", 1456, "\"", 1482, 2);
                WriteAttributeValue("", 1461, "category-", 1461, 9, true);
#nullable restore
#line 31 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1470, category.Id, 1470, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onchange=\"unSelectRadio()\" />\r\n                                    <label class=\"form-check-label fs-5\"");
                BeginWriteAttribute("for", " for=\"", 1587, "\"", 1614, 2);
                WriteAttributeValue("", 1593, "category-", 1593, 9, true);
#nullable restore
#line 32 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1602, category.Id, 1602, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                                                Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 35 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                </div>
            </div>
        </div>
        <div class=""col-9"">
            <div class=""card mx-0"">
                <div class=""card-header mb-0 text-light bgfondoCardHeader"">
                    <h2 class=""text-lg-center mb-2"">!Encuentra el articulo!</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28f7e281c05322633c9555582997e44b9665de411283", async() => {
                WriteLiteral(@"
                        <div class=""input-group mb-1"">
                            <button type=""submit"" class=""btn btn-danger"" onclick=""reiniciarListado()"">Mostrar todos</button>
                            <input type=""search"" class=""form-control rounded"" name=""ArticleName"" id=""ArticleTxt"" placeholder=""??Escribe el nombre del articulo!"" aria-label=""??Escribe el nombre del articulo!"" aria-describedby=""search-addon"" />
                            <button type=""submit"" class=""btn btn-success"">Buscar</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                 if (Model == null || Model.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"text-lg-center mb-3\">No hay articulos</h3>\r\n");
#nullable restore
#line 60 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body bgfondoCard\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 65 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                             foreach (ArticleViewModel item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-6 mb-3 card-sizing\">\r\n                                    <div class=\"card shadow-sm card-sizing color-card mx-lg-2\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28f7e281c05322633c9555582997e44b9665de414938", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 3508, "\"", 3531, 1);
#nullable restore
#line 69 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3514, item.ImageUrlOne, 3514, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-product-size bd-placeholder-img card-img-top details-hov\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                  WriteLiteral(item.Id);

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
            WriteLiteral("\r\n\r\n                                        <div class=\"card-body\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28f7e281c05322633c9555582997e44b9665de417672", async() => {
                WriteLiteral("<h3>");
#nullable restore
#line 72 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                                                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                            <p class=\"card-text\">");
#nullable restore
#line 73 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <ul class=""list-group list-group-flush"">
                                            <li class=""list-group-item color-card"">
                                                <div class=""d-flex justify-content-between align-items-center"">
                                                    <small>Categor??a: <span class=""fw-bold"">");
#nullable restore
#line 78 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></small>
                                                </div>
                                            </li>

                                            <li class=""list-group-item color-card"">
                                                <div class=""d-flex justify-content-between align-items-center"">
                                                    <small>Precio: <span class=""fw-bold"">$");
#nullable restore
#line 84 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></small>\r\n                                                </div>\r\n                                            </li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 90 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 93 "C:\Users\rlope\source\repos\eMarket\eMarket.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    function reiniciarListado() {
        var txtBusqueda = document.getElementById(""ArticleTxt"");
        var texto = null;
        document.getElementById(""ArticleTxt"").value = texto;
    }

    //control filtros
    function unSelectChecks() {
        document.querySelectorAll('[name=CategoryId]').forEach((x) => x.checked = false);
        document.querySelectorAll('[id=category-all]').forEach((x) => x.checked = true);
    }

    function unSelectRadio() {
        document.querySelectorAll('[id=category-all]').forEach((x) => x.checked = false);
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticleViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
