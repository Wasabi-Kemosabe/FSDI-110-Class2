#pragma checksum "/Users/atotanes/Desktop/SDGKU/FSDI110/Class2/CarRental/Views/Catalog/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde5432cf48699506f0b0ff48ed316b78b10a559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Register), @"mvc.1.0.view", @"/Views/Catalog/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Register.cshtml", typeof(AspNetCore.Views_Catalog_Register))]
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
#line 1 "/Users/atotanes/Desktop/SDGKU/FSDI110/Class2/CarRental/Views/_ViewImports.cshtml"
using CarRental;

#line default
#line hidden
#line 2 "/Users/atotanes/Desktop/SDGKU/FSDI110/Class2/CarRental/Views/_ViewImports.cshtml"
using CarRental.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde5432cf48699506f0b0ff48ed316b78b10a559", @"/Views/Catalog/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/register.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                BeginContext(17, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(18, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fde5432cf48699506f0b0ff48ed316b78b10a5594583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(67, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(70, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(71, 2301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde5432cf48699506f0b0ff48ed316b78b10a5596009", async() => {
                BeginContext(77, 2288, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""make"">Make</label>
        <input type=""string"" class=""form-control"" id=""make"" placeholder=""Enter make"">
    </div>
    <div class=""form-group"">
        <label for=""model"">Model</label>
        <input type=""string"" class=""form-control"" id=""model"" placeholder=""Enter model"">
    </div>
    <div class=""form-group"">
        <label for=""year"">Year of car</label>
        <input type=""number"" class=""form-control"" id=""year"" placeholder=""Enter year of manufacture"">
    </div>
    <div class=""form-group"">
        <label for=""color"">Color</label>
        <input type=""string"" class=""form-control"" id=""color"" placeholder=""Enter color"">
    </div>
    <div class=""form-group"">
        <label for=""cylinders"">Cylinders</label>
        <input type=""number"" class=""form-control"" id=""cylinders"" placeholder=""Enter number of cylinders"">
    </div>
    <div class=""form-group"">
        <label for=""horsePower"">Horsepower</label>
        <input type=""number"" class=""form-control"" id=""hors");
                WriteLiteral(@"ePower"" placeholder=""Enter horsepower of car"">
    </div>
    <div class=""form-group"">
        <label for=""doors""># of Doors</label>
        <input type=""number"" class=""form-control"" id=""doors"" placeholder=""Enter number of doors"">
    </div>
    <div class=""form-group"">
        <label for=""seats""># of Seats</label>
        <input type=""number"" class=""form-control"" id=""seats"" placeholder=""Enter number of seats"">
    </div>
    <div class=""form-group"">
        <label for=""mileage""># of Mileage</label>
        <input type=""number"" class=""form-control"" id=""mileage"" placeholder=""Enter number of mileage"">
    </div>
    <div class=""form-group"">
        <label for=""dailyPrice"">Daily Price</label>
        <input type=""number"" class=""form-control"" id=""dailyPrice"" placeholder=""Enter daily rent price"">
    </div>
    <div class=""form-group"">
        <label for=""imageURL"">Image URL of car</label>
        <input type=""string"" class=""form-control"" id=""imageURL"" placeholder=""Enter the URL of the image"">
    </div>
    <div ");
                WriteLiteral("class=\"form-group\">\n        <label for=\"description\">Description</label>\n        <textarea class=\"form-control\" id=\"description\" rows=\"3\"></textarea>\n    </div>\n    <button id=\"btnSave\" type=\"button\" class=\"btn btn-primary\">Submit</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2372, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2392, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2393, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fde5432cf48699506f0b0ff48ed316b78b10a55910112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2433, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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