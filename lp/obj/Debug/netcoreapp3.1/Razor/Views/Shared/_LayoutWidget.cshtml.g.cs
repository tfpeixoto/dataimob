#pragma checksum "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_LayoutWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb4b9e041d8fbb93d9494cabdad2b0d93996a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutWidget), @"mvc.1.0.view", @"/Views/Shared/_LayoutWidget.cshtml")]
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
#line 1 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_ViewImports.cshtml"
using CalculadoraDataImob;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_ViewImports.cshtml"
using CalculadoraDataImob.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb4b9e041d8fbb93d9494cabdad2b0d93996a3d", @"/Views/Shared/_LayoutWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6262cb91d1de1f45d19760c712f5e5ee76ba41", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared__LayoutWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logowidget"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Imagens/horizontal padrao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("DataImob"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light d-flex flex-column h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\" class=\"h-100\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb4b9e041d8fbb93d9494cabdad2b0d93996a3d5346", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_LayoutWidget.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" DataImob</title>

    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1"" crossorigin=""anonymous"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"" rel=""stylesheet"" integrity=""sha512-HK5fgLBL+xu6dm/Ii3z4xhlSUyZgTT9tuc/hSrtw6uzJOvgRr2a9jyxxT1ely+B+xFAmJKVSTbpM/CuL7qxO8w=="" crossorigin=""anonymous"">
    <link href=""/widget/css/configuracoes.css?v=00.6"" rel=""stylesheet"">
    <script src=""/widget/js/fontAW_a076d05399.js?v=00.4""></script>

    <style>
                .search-input.active input {
                    border-radius: 5px 5px 0 0;
                }

                .search-input .autocom-box {
                    padding: 0;
                    opacity: 0;
                    pointer-events: none;
                    max-height: 280px;
                    overflow-y: auto;
                }

           ");
                WriteLiteral(@"     .search-input.active .autocom-box {
                    padding: 10px 8px;
                    opacity: 1;
                    pointer-events: auto;
                }

                .autocom-box li {
                    list-style: none;
                    padding: 8px 12px;
                    display: none;
                    width: 100%;
                    cursor: default;
                    border-radius: 3px;
                }

                .search-input.active .autocom-box li {
                    display: block;
                }

                .autocom-box li:hover {
                    background: #efefef;
                }

                .search-input .icon {
                    position: absolute;
                    right: 0px;
                    top: 0px;
                    height: 55px;
                    width: 55px;
                    text-align: center;
                    line-height: 55px;
                    font-size: 20px;
           ");
                WriteLiteral(@"         color: #644bff;
                    cursor: pointer;
                }

                .h2 {
                    font-size: calc(1.135rem + .9vw);
                }

                /* Custom page CSS
        -------------------------------------------------- */
                /* Not required for template or sticky footer method. */

                .container-fluid {
                    width: auto;
                    max-width: 680px;
                    padding: 0 15px;
                    
                }

                footer {
                    border-top: 0.1px solid #CCCCCC;
                }
                #logowidget{
                    width: 40%;
                }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb4b9e041d8fbb93d9494cabdad2b0d93996a3d9579", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-dark bg-secondary text-white py-3  px-0"">
        <div class=""container-fluid"" style=""width: -webkit-fill-available"">
            <h1 id=""TituloWidget"" class=""text-uppercase text-center text-secondary h2 mb-0""><i class=""fas fa-search-dollar""></i> Avalie o seu imóvel</h1>
            <h6 id=""Titulo"" class=""text-center text-secondary mt-0""></h6>
        </div>
    </nav>
    <div class=""container-fluid pl-2 pr-4"">
        ");
#nullable restore
#line 93 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_LayoutWidget.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 96 "C:\GitLab\DataImob\DataImobSite\CalculadoraDataImob\WebApplication10\Views\Shared\_LayoutWidget.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js?v=00.4""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.4/popper.min.js?v=00.4""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js?v=00.4""></script>

    <!--JavaScript -->
    <script src=""/widget/js/ScriptSugestao.js?v=00.7""></script>
    <script src=""/widget/js/suggestions.js?v=00.5""></script>
    <script src=""/js/jquery.maskMoney.min.js""></script>
    <script src=""/js/jquery.mask.js""></script>
    <script src=""/widget/js/ScriptWidget.js?v=00.14""></script>

    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src=""https://www.googletagmanager.com/gtag/js?id=G-9WW50PGE9R""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('j");
                WriteLiteral(@"s', new Date());

        gtag('config', 'G-9WW50PGE9R');
    </script>

    <footer class=""footer mt-auto"">
        <div class=""container-fluid text-center"">
            <span style=""display: inline-block; font-size: 0.6rem; font-weight: bold;"">Powered by </span> <a target=""_blank"" href=""https://dataimob.com.br/"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cb4b9e041d8fbb93d9494cabdad2b0d93996a3d12267", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n        </div>\r\n    </footer>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n \r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
