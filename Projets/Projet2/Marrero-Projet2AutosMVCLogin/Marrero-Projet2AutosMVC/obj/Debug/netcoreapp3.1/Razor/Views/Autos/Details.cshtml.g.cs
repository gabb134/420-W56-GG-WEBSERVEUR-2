#pragma checksum "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6d2fce30c4bba21f0b1f2368dfe84ff1cde944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autos_Details), @"mvc.1.0.view", @"/Views/Autos/Details.cshtml")]
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
#line 1 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\_ViewImports.cshtml"
using Marrero_Projet2AutosMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\_ViewImports.cshtml"
using Marrero_Projet2AutosMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6d2fce30c4bba21f0b1f2368dfe84ff1cde944", @"/Views/Autos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b57e1ee36e8e3ff5424873779cdf65423082f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Autos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Marrero_Projet2AutosMVC.Models.Auto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Détails</h1>\r\n\r\n<div>\r\n    <h4>Auto</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modele));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modele));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marque.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Couleur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Couleur.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\" card-body-header\"> <h4> Identificateur :  ");
#nullable restore
#line 38 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                                                      Write(Model.nom);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                                                                Write(Model.Couleur.Nom.Substring(0, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                                                                                                  Write(Model.AutoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </h4> </div>\r\n\r\n    <img class=\"card-img-top imageThumbnail\" style=\"max-width: 70%;  max-height : 100%;\"");
            BeginWriteAttribute("src", " src=\"", 1221, "\"", 1305, 1);
#nullable restore
#line 40 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
WriteAttributeValue("", 1227, Url.Content("~/Images/"+@Model.nom +@Model.Couleur.Nom.Substring(0,1)+".png"), 1227, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\">\r\n    <div class=\"card-footer\">\r\n        <h4>Marque : ");
#nullable restore
#line 42 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                Write(Model.Marque.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        <h4 class=\"card-title\"> Modèle : ");
#nullable restore
#line 43 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                                    Write(Model.Modele);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        <p class=\"card-text\">Couleur : ");
#nullable restore
#line 44 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                                  Write(Model.Couleur.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb6d2fce30c4bba21f0b1f2368dfe84ff1cde94411090", async() => {
                WriteLiteral("Modifier");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\GabrielMarrero\Documents\420-W56-GG-WEBSERVEUR-2\Projets\Projet2\Marrero-Projet2AutosMVCLogin\Marrero-Projet2AutosMVC\Views\Autos\Details.cshtml"
                               WriteLiteral(Model.AutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb6d2fce30c4bba21f0b1f2368dfe84ff1cde94413406", async() => {
                WriteLiteral("Retour à la liste");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n \r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Marrero_Projet2AutosMVC.Models.Auto> Html { get; private set; }
    }
}
#pragma warning restore 1591
