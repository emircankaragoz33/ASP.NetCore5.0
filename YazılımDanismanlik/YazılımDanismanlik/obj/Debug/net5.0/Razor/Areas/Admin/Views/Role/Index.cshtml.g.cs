#pragma checksum "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46f646409e3c4779910f7b037f3d0948a4a0c7907956ac703d9a84b67915b426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46f646409e3c4779910f7b037f3d0948a4a0c7907956ac703d9a84b67915b426", @"/Areas/Admin/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9e2ab8744b76b690719990e1b91be1cb6987b34539f69f12668cefeb82318f76", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebRole>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";
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
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Yetki Adı</th>
                <th scope=""col"">Yetki açıklaması</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Oluşturlduğu Tarih</th>
                <th scope=""col"">Yetkiyi kaldır.</th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 25 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
                   Write(item.RolTanimi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
                   Write(item.RolOlusturmaTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1358, "\"", 1396, 2);
            WriteAttributeValue("", 1365, "/Admin/Role/DeleteRole/", 1365, 23, true);
#nullable restore
#line 44 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"
WriteAttributeValue("", 1388, item.Id, 1388, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Yetkiyi kaldır. </a></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\emircankaragoz\Desktop\YazılımDanismanlik\YazılımDanismanlik\Areas\Admin\Views\Role\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <br />\r\n\r\n\r\n    <a style=\"margin-left:20px\" href=\"/Admin/Role/CreateRole/\" class=\"btn btn-primary\"> Yeni Yetki ekle! </a>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
