#pragma checksum "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b207483671c733df648189f7ce3af3a42d9476ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
#line 1 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\_ViewImports.cshtml"
using BookCatalogue;

#line default
#line hidden
#line 2 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\_ViewImports.cshtml"
using BookCatalogue.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b207483671c733df648189f7ce3af3a42d9476ce", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3e341844b1e70867f1fc803cb47ab86b608b64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookCatalogue.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
   
    ViewBag.Title = "Подтвердите удаление";

#line default
#line hidden
            BeginContext(88, 119, true);
            WriteLiteral("\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>Названи книги</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(208, 37, false);
#line 10 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(245, 85, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>Автор</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(331, 38, false);
#line 15 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(369, 84, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>Цена</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(454, 37, false);
#line 20 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(491, 84, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>Жанр</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(576, 37, false);
#line 25 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(613, 98, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>Количество страниц</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(712, 41, false);
#line 30 "C:\Users\kiril\OneDrive\Рабочий стол\Анечка тут главная\BookCatalogue\BookCatalogue\Views\Home\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PageCount));

#line default
#line hidden
            EndContext();
            BeginContext(753, 65, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(818, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b207483671c733df648189f7ce3af3a42d9476ce7039", async() => {
                BeginContext(880, 197, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <a href= \"/Home/Index/\"><input type=\"submit\" @*class=\"btn btn-default\"*@ value=\"Удалить\" /></a>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1084, 28, true);
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookCatalogue.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591