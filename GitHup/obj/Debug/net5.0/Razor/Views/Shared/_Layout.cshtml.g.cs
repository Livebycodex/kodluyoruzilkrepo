#pragma checksum "C:\Users\Oğuz\Desktop\kodluyoruzilkrepo-master\GitHup\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca4549bb132117cf3f3e64ca7e69c6534212ac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 3 "C:\Users\Oğuz\Desktop\kodluyoruzilkrepo-master\GitHup\Views\_ViewImports.cshtml"
using GitHup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca4549bb132117cf3f3e64ca7e69c6534212ac6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b79761821d700072ba2abe54227b6ef84f26a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca4549bb132117cf3f3e64ca7e69c6534212ac63421", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 192, "\"", 202, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 230, "\"", 240, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>kodluyoruzilkrepo</title>
    <link rel=""icon"" type=""image/x-icon"" href=""assets/img/favicon.ico"" />
    <!-- Font Awesome icons (free version)-->
    <script src=""https://use.fontawesome.com/releases/v5.15.3/js/all.js"" crossorigin=""anonymous""></script>
    <!-- Google fonts-->
    <link href=""https://fonts.googleapis.com/css?family=Saira+Extra+Condensed:500,700"" rel=""stylesheet"" type=""text/css"" />
    <link href=""https://fonts.googleapis.com/css?family=Muli:400,400i,800,800i"" rel=""stylesheet"" type=""text/css"" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href=""css/styles.css"" rel=""stylesheet"" />
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca4549bb132117cf3f3e64ca7e69c6534212ac65544", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <nav class=""navbar navbar-expand-lg navbar-dark bg-primary fixed-top"" id=""sideNav"">
        <a class=""navbar-brand js-scroll-trigger"">
            <span class=""d-block d-lg-none"">Oguz Turkmen</span>
            <span class=""d-none d-lg-block""><img class=""img-fluid img-profile rounded-circle mx-auto mb-2"" src=""MyStaticFiles/Image/oguz.jpg"" alt=""..."" /></span>
        </a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
       ");
#nullable restore
#line 28 "C:\Users\Oğuz\Desktop\kodluyoruzilkrepo-master\GitHup\Views\Shared\_Layout.cshtml"
  Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    </nav>
    <!-- Page Content-->
    <div class=""container-fluid p-0"">
        <!-- About-->
        <section class=""resume-section"" id=""Hakkımda"">
            <div class=""resume-section-content"">
                <h1 class=""mb-0"">
                    Oguz
                    <span class=""text-primary"">Turkmen</span>
                </h1>
                <div class=""subheading mb-5"">

                    <text>
                        E Posta :</style>
                        <style></style>
                    </text>oguzztrkmn@gmail.com
                </div>
                <p class=""lead mb-5""><h2>İstanbul</h2></p>
                <div class=""social-icons"">
                    <a class=""social-icon"" href=""https://www.linkedin.com/in/oguztrkmn/""><i class=""fab fa-linkedin-in""></i></a>
                    <a class=""social-icon"" href=""https://github.com/Livebycodex""><i class=""fab fa-github""></i></a>
                    <a class=""social-icon"" href=""https://twitter.com/oguztrkmn""><i class=""fab fa-twitter""><");
                WriteLiteral(@"/i></a>
                    <a class=""social-icon"" href=""https://www.facebook.com/oguztrkmn/""><i class=""fab fa-facebook-f""></i></a>
                </div>
            </div>
        </section>
        <hr class=""m-0"" />
       
        <!-- Education-->
        <section class=""resume-section"" id=""Eğitim"">
            <div class=""resume-section-content"">
                <h1 class=""mb-5"">Egitim</h1>
                <div class=""d-flex flex-column flex-md-row justify-content-between mb-5"">
                    <div class=""flex-grow-1"">
                        <h3 class=""mb-0"">Anadolu Universitesi</h3>
                        <div class=""subheading mb-3"">Isletme</div>
                       
                    </div>
                    <div class=""flex-shrink-0""><span class=""text-primary"">Eylul 2018 - Haziran 2020</span></div>
                </div>
                <div class=""d-flex flex-column flex-md-row justify-content-between"">
                    <div class=""flex-grow-1"">
                        <h3 class=""");
                WriteLiteral(@"mb-0"">Istanbul Universitesi</h3>
                        <div class=""subheading mb-3"">Cografi Bilgi Sistemleri</div>
                       
                    </div>
                    <div class=""flex-shrink-0""><span class=""text-primary"">Eylul 2014 - May 2017</span></div>
                </div>
            </div>
        </section>
        <hr class=""m-0"" />
      
        <!-- Interests-->
        <section class=""resume-section"" id=""Hobiler"">
            <div class=""resume-section-content"">
                <h2 class=""mb-5"">Hobiler</h2>
                <p>Spor yapmak, Film izlemek, Bilgisayar Programlama</p>
            </div>
        </section>
        <hr class=""m-0"" />
        <!-- Awards-->
        
    <!-- Bootstrap core JS-->
    <script src=""fergthyjujthrgfed""></script>
    <!-- Core theme JS-->
    <script src=""js/scripts.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
