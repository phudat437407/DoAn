#pragma checksum "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9ea3e7337973ca697507a9d109dc392fa7a1cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Examining.Pages.Login.Pages_Login_Index), @"mvc.1.0.razor-page", @"/Pages/Login/Index.cshtml")]
namespace Examining.Pages.Login
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
#line 1 "c:\Users\admin\Desktop\DoAn\Examining\Pages\_ViewImports.cshtml"
using Examining;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9ea3e7337973ca697507a9d109dc392fa7a1cd", @"/Pages/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76afff23aa621f2f2125279181486c45f0239c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Thông Tin Đăng Kí Khám Bệnh</h1>\n\n\n<table class=\"table\">\n\n    <thead>\n\n        <tr>\n\n            <th>\n                    ");
#nullable restore
#line 16 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ListEnrollment[0].patient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </th>\n\n            <th>\n\n                ");
#nullable restore
#line 22 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ListEnrollment[0].doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </th>\n\n            <th>\n\n\n                    ");
#nullable restore
#line 29 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ListEnrollment[0].enrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("       \n\n            </th>\n\n            <th></th>\n\n        </tr>\n\n    </thead>\n\n    <tbody>\n\n");
#nullable restore
#line 41 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
         foreach (var item in Model.ListEnrollment)

        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>\n\n                    ");
#nullable restore
#line 49 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.patient.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>\n                <td>\n\n                    ");
#nullable restore
#line 54 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.doctor.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>    \n                <td>\n\n                    ");
#nullable restore
#line 59 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.enrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>\n\n                \n\n            </tr>\n");
#nullable restore
#line 66 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Examining.Pages.Login.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Examining.Pages.Login.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Examining.Pages.Login.IndexModel>)PageContext?.ViewData;
        public Examining.Pages.Login.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
