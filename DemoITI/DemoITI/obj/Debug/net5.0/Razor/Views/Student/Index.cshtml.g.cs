#pragma checksum "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1d79a81e43aca657bce69fdeba0b50511d386fe04b837f1bcb88ca05babeb4b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\_ViewImports.cshtml"
using DemoITI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\_ViewImports.cshtml"
using DemoITI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1d79a81e43aca657bce69fdeba0b50511d386fe04b837f1bcb88ca05babeb4b1", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b37dc55dbb1efce1fb688b3a3f0913553df9635033efabbca28a97cd19eff174", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-bordered table-hover\">\r\n\r\n");
#nullable restore
#line 9 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
     foreach (Student item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 363, "\"", 386, 2);
            WriteAttributeValue("", 369, "/Imgs/", 369, 6, true);
#nullable restore
#line 15 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
WriteAttributeValue("", 375, item.Image, 375, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 50px; height:50px\" /></td>\r\n        </tr>\r\n");
#nullable restore
#line 17 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
