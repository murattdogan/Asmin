#pragma checksum "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30c4101f54d48e201396b49581e6c4ed3a5f0e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\_ViewImports.cshtml"
using Asmin.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
using Asmin.Core.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30c4101f54d48e201396b49581e6c4ed3a5f0e6", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4aa6dd8791b426bf85d14725cecca62b2e5b02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <!-- table primary start -->
    <div class=""col-lg-12 mt-5"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Thead Primary</h4>
                <div class=""single-table"">
                    <div class=""table-responsive"">
                        <table class=""table text-center"">
                            <thead class=""text-uppercase bg-primary"">
                                <tr class=""text-white"">
                                    <th scope=""col"">ID</th>
                                    <th scope=""col"">Image</th>
                                    <th scope=""col"">Full Name</th>
                                    <th scope=""col"">E-mail</th>
                                    <th scope=""col"">action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 23 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                 foreach (var user in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 26 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                                   Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                        <td>
                                            <img width=""36"" height=""36""
                                                 style=""border-radius:100%""
                                                 src=""/assets/admin/images/author/avatar.png"" />
                                        </td>
                                        <td>");
#nullable restore
#line 32 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                                       Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 33 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td>
                                            <i class=""ti-pencil"" onclick=""showUpdatesMessage()""></i>
                                            &nbsp;
                                            &nbsp;
                                            &nbsp;
                                            <i class=""ti-trash"" onclick=""showUpdatesMessage()""></i>
                                        </td>
                                    </tr>
");
#nullable restore
#line 42 "D:\Program Files\GitHub\Asmin\src\Asmin\Asmin.WebMVC\Areas\Admin\Views\User\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- table primary end -->
</div>

<script>
    const showUpdatesMessage = () => {
        alert(""I will be fix this soon, follow the updates  :)"");
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
