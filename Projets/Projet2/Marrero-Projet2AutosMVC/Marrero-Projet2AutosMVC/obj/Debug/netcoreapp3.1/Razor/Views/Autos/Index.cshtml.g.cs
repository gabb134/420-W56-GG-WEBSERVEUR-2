#pragma checksum "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea1695537fa90284fe9e933ae5d04f6c92545aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autos_Index), @"mvc.1.0.view", @"/Views/Autos/Index.cshtml")]
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
#line 1 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\_ViewImports.cshtml"
using Marrero_Projet2AutosMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\_ViewImports.cshtml"
using Marrero_Projet2AutosMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea1695537fa90284fe9e933ae5d04f6c92545aa", @"/Views/Autos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b57e1ee36e8e3ff5424873779cdf65423082f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Autos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Marrero_Projet2AutosMVC.Models.Auto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 85% "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea1695537fa90284fe9e933ae5d04f6c92545aa6288", async() => {
                WriteLiteral("Ajouter une auto");
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
            WriteLiteral("\r\n</p>\r\n<div class=\"card\" style=\"width: 80rem;\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Liste d\'autos</h4>\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row d-inline-flex\">\r\n");
#nullable restore
#line 15 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12 col-sm-6 col-md-4 col-lg-3 p-2"">
                        <div class=""card m-3"" style=""min-width: 18rem; max-width: 20%"">

                            <div class="" card-body-header""> <h4 style=""font-size: 130% ""> Identificateur : ");
#nullable restore
#line 20 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                                                      Write(item.nom);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                                                               Write(item.Couleur.Nom.Substring(0, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                                                                                                Write(item.AutoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h4> </div>\r\n\r\n                            <img class=\"card-img-top imageThumbnail\" style=\"max-width:100%;  max-height : 50%;\"");
            BeginWriteAttribute("src", " src=\"", 893, "\"", 973, 1);
#nullable restore
#line 22 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
WriteAttributeValue("", 899, Url.Content("~/images/"+item.nom +item.Couleur.Nom.Substring(0,1)+".png"), 899, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\">\r\n                            <div class=\"card-footer\">\r\n                                <h4 style=\"font-size: 130% \">Marque : ");
#nullable restore
#line 24 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                 Write(item.Marque.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                <h4 class=\"card-title\" style=\"font-size: 130% \"> Modèle : ");
#nullable restore
#line 25 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                                     Write(item.Modele);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                <p class=\"card-text\" style=\"font-size: 130% \">Couleur : ");
#nullable restore
#line 26 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                                                   Write(item.Couleur.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea1695537fa90284fe9e933ae5d04f6c92545aa11555", async() => {
                WriteLiteral("Modifier");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                       WriteLiteral(item.AutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea1695537fa90284fe9e933ae5d04f6c92545aa13992", async() => {
                WriteLiteral("Détails");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                          WriteLiteral(item.AutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea1695537fa90284fe9e933ae5d04f6c92545aa16431", async() => {
                WriteLiteral("Supprimer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                                                         WriteLiteral(item.AutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVC\Marrero-Projet2AutosMVC\Views\Autos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!--<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n}\r\n    </tbody>\r\n</table>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Marrero_Projet2AutosMVC.Models.Auto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
