#pragma checksum "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395ae006b5f244008a10152b2fbfa8ba2348a823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
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
#line 1 "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\_ViewImports.cshtml"
using AppVsCode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\_ViewImports.cshtml"
using AppVsCode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395ae006b5f244008a10152b2fbfa8ba2348a823", @"/Views/Demo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30978462ebafde0cbd3f75d4cf86d0fa37385071", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\Demo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Toutes les démos disponibles:</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\Demo\Index.cshtml"
Write(Html.ActionLink("Bootstrap", "Bootstrap", "Demo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br>\r\n");
#nullable restore
#line 9 "C:\Users\renau\Documents\WebApp Projects\AppVsCode\AppVsCode\Views\Demo\Index.cshtml"
Write(Html.ActionLink("Razor", "Razor", "Demo"));

#line default
#line hidden
#nullable disable
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