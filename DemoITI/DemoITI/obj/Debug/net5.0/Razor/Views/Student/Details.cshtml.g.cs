#pragma checksum "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53ad5de43536760c5c95d03b3e98cc12f33a7246824aa78b274c6f5c85ea8da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53ad5de43536760c5c95d03b3e98cc12f33a7246824aa78b274c6f5c85ea8da9", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b37dc55dbb1efce1fb688b3a3f0913553df9635033efabbca28a97cd19eff174", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 180, "\"", 204, 2);
            WriteAttributeValue("", 186, "/Imgs/", 186, 6, true);
#nullable restore
#line 7 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Details.cshtml"
WriteAttributeValue("", 192, Model.Image, 192, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 9 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Details.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 10 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Student\Details.cshtml"
                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a href=\"Student/Index\" class=\"btn btn-primary\">Go Back</a>\r\n    </div>\r\n</div>");
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
