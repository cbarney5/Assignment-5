#pragma checksum "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe091ddeea539462ff63de96c67cf53ffc6fdf2"
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
#line 1 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/_ViewImports.cshtml"
using Assignment5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe091ddeea539462ff63de96c67cf53ffc6fdf2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61665519b41838e6b755733af02d48e6858089e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\n    <h1>Online Bookstore</h1>\n</header>\n\n");
#nullable restore
#line 9 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h4>Book Title: ");
#nullable restore
#line 12 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
               Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <p>Author First Name: ");
#nullable restore
#line 13 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
                     Write(x.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Author Last Name: ");
#nullable restore
#line 14 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
                    Write(x.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Publisher: ");
#nullable restore
#line 15 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
             Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>ISBN: ");
#nullable restore
#line 16 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
        Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Classification: ");
#nullable restore
#line 17 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
                  Write(x.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Category: ");
#nullable restore
#line 18 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
            Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Price: $");
#nullable restore
#line 19 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
          Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n</div>\n");
#nullable restore
#line 22 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe091ddeea539462ff63de96c67cf53ffc6fdf25722", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 23 "/Users/coltinb/OneDrive/School/IS 413/Assignment5/Assignment5/Views/Home/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591