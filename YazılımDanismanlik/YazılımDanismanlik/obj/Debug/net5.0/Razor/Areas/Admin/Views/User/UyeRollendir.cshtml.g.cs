#pragma checksum "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a682b7e2dc2281e7197d30bee5a9090e98a48554efe7ab0fdd708fdff135080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UyeRollendir), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UyeRollendir.cshtml")]
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
#line 1 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"
using YazilimDanismanlik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8a682b7e2dc2281e7197d30bee5a9090e98a48554efe7ab0fdd708fdff135080", @"/Areas/Admin/Views/User/UyeRollendir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9e2ab8744b76b690719990e1b91be1cb6987b34539f69f12668cefeb82318f76", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_UyeRollendir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserRoleViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"
  
    ViewData["Title"] = "UyeRollendir";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 style=""text-align:center"" class=""mb-0"">Yetkiler ve yetkileri düzenleme işlemleri</h3>
</div>

<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
               
                <th scope=""col"" class=""sort"" data-sort=""budget"">Kullanıcı Adı</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Yetkilendir</th>
              

            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 28 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"
             foreach (var item in list)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                   \r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"
                   Write(item.WebUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th class=\"budget\">\r\n\r\n                   ");
#nullable restore
#line 38 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"
              Write(Html.DropDownListFor(x=>x.WebRole.Id , (List<SelectListItem>)ViewBag.degerler));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n\r\n                    </th> \r\n\r\n                \r\n\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\User\UyeRollendir.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br />\r\n\r\n\r\n    \r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public List<UserRoleViewModel> list { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserRoleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
