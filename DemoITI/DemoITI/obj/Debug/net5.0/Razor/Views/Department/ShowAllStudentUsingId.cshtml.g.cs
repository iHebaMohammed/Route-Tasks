#pragma checksum "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7cd9c65a65b9fb941f4661d8f20dcef4454341dbc9e1152204f6d02b1b4a15ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_ShowAllStudentUsingId), @"mvc.1.0.view", @"/Views/Department/ShowAllStudentUsingId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7cd9c65a65b9fb941f4661d8f20dcef4454341dbc9e1152204f6d02b1b4a15ce", @"/Views/Department/ShowAllStudentUsingId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b37dc55dbb1efce1fb688b3a3f0913553df9635033efabbca28a97cd19eff174", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_ShowAllStudentUsingId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table table-bordered table-hover\">\r\n    <tr>\r\n        <th>Department Name</th>\r\n        <th>Manager Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
           Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
           Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
           Write(student.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
           Write(student.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "E:\Repos\Projects\Route C#\DemoITI\DemoITI\Views\Department\ShowAllStudentUsingId.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
