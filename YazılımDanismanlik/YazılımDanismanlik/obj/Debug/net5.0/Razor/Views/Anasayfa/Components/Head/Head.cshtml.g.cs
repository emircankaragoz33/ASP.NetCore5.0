#pragma checksum "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41d55607725bfd1047315dc5bcfe6da9cd3c292fba689a34f4ad46c35682ad14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Components_Head_Head), @"mvc.1.0.view", @"/Views/Anasayfa/Components/Head/Head.cshtml")]
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
#line 1 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\_ViewImports.cshtml"
using YazılımDanismanlik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\_ViewImports.cshtml"
using YazılımDanismanlik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"41d55607725bfd1047315dc5bcfe6da9cd3c292fba689a34f4ad46c35682ad14", @"/Views/Anasayfa/Components/Head/Head.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92eaea6c4b0b5baca2e985ad9aa968da47fcef095714c00fa8ef5f94ed47a81c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Anasayfa_Components_Head_Head : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Head>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header class=\"masthead\">\r\n    <div class=\"container px-4 px-lg-5 h-100\">\r\n        <div class=\"row gx-4 gx-lg-5 h-100 align-items-center justify-content-center text-center\">\r\n");
#nullable restore
#line 7 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml"
             foreach (var item in Model)
            {
                
           

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-8 align-self-end\">\r\n                <h1 style=\"color:white\">");
#nullable restore
#line 12 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml"
                                   Write(item.KarsilamaBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <hr class=\"divider\" />\r\n            </div>\r\n            <div class=\"col-lg-8 align-self-baseline\">\r\n                <p class=\"text-white-75 mb-5\">");
#nullable restore
#line 16 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml"
                                         Write(item.KarsilamaAciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a class=\"btn btn-secondary btn-xl\" href=\"/Egitmen/Index\">Eğitmenlerimize Ulaş!!</a>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Views\Anasayfa\Components\Head\Head.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Head>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
