#pragma checksum "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83da781098c233e5f7e2e9a84f70463efb6e5294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Examining.Pages.Login.Pages_Login_Information), @"mvc.1.0.razor-page", @"/Pages/Login/Information.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83da781098c233e5f7e2e9a84f70463efb6e5294", @"/Pages/Login/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76afff23aa621f2f2125279181486c45f0239c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Information : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
  
    ViewData["Name"] = "Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 11 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 14 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient[0].Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient[0].BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient[0].Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 29 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
 foreach (var item in Model.Patient) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 32 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 35 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <th>\n                ");
#nullable restore
#line 41 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayNameFor(model => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <td>\n                ");
#nullable restore
#line 44 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 47 "c:\Users\admin\Desktop\DoAn\Examining\Pages\Login\Information.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Examining.Pages.Login.InforModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Examining.Pages.Login.InforModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Examining.Pages.Login.InforModel>)PageContext?.ViewData;
        public Examining.Pages.Login.InforModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
