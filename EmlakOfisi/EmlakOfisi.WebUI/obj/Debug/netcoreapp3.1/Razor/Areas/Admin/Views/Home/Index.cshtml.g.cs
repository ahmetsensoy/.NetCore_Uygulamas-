#pragma checksum "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3cb18657b57ee638515c75a1d3a9ab09a269616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3cb18657b57ee638515c75a1d3a9ab09a269616", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmlakOfisi.WebUI.Models.AgentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>


    <div class=""row justify-content-sm-around mt-3"">
        <div class=""col ml-5"" style=""text-align:left;"">
            <a class=""btn btn-success"" href=""/Admin/CreateAgent"">Yeni Emlakçı Kayıt Oluştur</a>
        </div>
        <div class=""col mr-5"" style=""text-align:right;"">
            <a class=""btn btn-warning"" href=""/Login/Exit"">Çıkış Yap</a>
        </div>
    </div>
    <div class=""m-5"">
        <div class=""text-center mb-4"" style=""font-size:xx-large"">Kayıtlı Emlakçılar</div>
        <table class=""table table-bordered"" style=""background-color:rgba(255, 255, 255, 0.5);"">


            <tr>
                <th>Id</th>
                <th>Kullanıcı Adı</th>
                <th>Şirket İsmi</th>
                <th>Sil</th>

            </tr>
");
#nullable restore
#line 31 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
             foreach (var d in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"satir\"");
            BeginWriteAttribute("id", " id=\"", 1030, "\"", 1054, 2);
            WriteAttributeValue("", 1035, "advertisement-", 1035, 14, true);
#nullable restore
#line 33 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1049, d.Id, 1049, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
                   Write(d.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
                   Write(d.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
                   Write(d.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1230, "\"", 1261, 2);
            WriteAttributeValue("", 1237, "/Admin/Home/Delete/", 1237, 19, true);
#nullable restore
#line 37 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1256, d.Id, 1256, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\MONSTER\Desktop\Proje\EOfis\EmlakOfisi\EmlakOfisi.WebUI\Areas\Admin\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmlakOfisi.WebUI.Models.AgentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
