#pragma checksum "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b9bceb253c2dda01530041176e17771f090406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\_ViewImports.cshtml"
using ReaAkademiProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\_ViewImports.cshtml"
using ReaAkademiProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b9bceb253c2dda01530041176e17771f090406", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363de012646bfbf8879bff4efe209563bcaccfe3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Team ID</th>
            <th scope=""col"">Team Name</th>
            <th scope=""col"">Team Surname</th>
            <th scope=""col"">Team Department</th>
            <th scope=""col"">Team Salary</th>
            <th scope=""col"">Team Password</th>
            <th scope=""col"">Team Role</th>
        </tr>
    </thead>
");
#nullable restore
#line 16 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\n            <tr>\n                <td>");
#nullable restore
#line 20 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
               Write(item.teammate_Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n        </tbody>\n");
#nullable restore
#line 29 "C:\Users\Yasin\Desktop\ASP-NET-MVC-Blog-main\ReaAkademiProje\ReaAkademiProje\Views\Team\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591