#pragma checksum "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\Shared\_ProductListPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db117caccea3a0feb714436212aa147c04a3a486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductListPartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductListPartialView.cshtml")]
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
#line 1 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\_ViewImports.cshtml"
using PartialViewDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\_ViewImports.cshtml"
using PartialViewDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db117caccea3a0feb714436212aa147c04a3a486", @"/Views/Shared/_ProductListPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e318ce20f422b3115d29a19dc6000f25befec4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductListPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartialViewDemo.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 6 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\Shared\_ProductListPartialView.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\Shared\_ProductListPartialView.cshtml"
   Write(await Html.PartialAsync("_ProductCardPartialView", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetmvc\lektion-2\PartialViewDemo\PartialViewDemo\Views\Shared\_ProductListPartialView.cshtml"
                                                                 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartialViewDemo.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
