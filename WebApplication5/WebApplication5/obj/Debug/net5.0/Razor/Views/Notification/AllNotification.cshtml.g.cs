#pragma checksum "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2964ff8b10b5cb002476a15177c56329b776818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
#line 1 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2964ff8b10b5cb002476a15177c56329b776818", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bildirimler</h1>\r\n<table class=\"table table-primary\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Bildirim</th>\r\n        <th>Tarih</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Canda\source\repos\WebApplication5\WebApplication5\Views\Notification\AllNotification.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
