#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d740401f54a3e1a7c782b1a2805ee0a2376b99"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Shop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using DataAccess.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using DataAccess.Repository.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using DataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navbar navbar-inverse");
            __builder.AddAttribute(2, "id", "navbar_box");
            __builder.AddAttribute(3, "b-sjunaijqng");
            __builder.AddMarkupContent(4, @"<div class=""navbar-header"" b-sjunaijqng><a class=""navbar-brand"" href=""/"" b-sjunaijqng><span class=""logo"" b-sjunaijqng></span> سلة</a>

        <a class=""sidebar-mobile-main-toggle"" id=""toggle-sidebar"" b-sjunaijqng><i class=""sicon-menu"" b-sjunaijqng></i></a>
        <ul class=""nav navbar-nav visible-xs navbar-top-mobile"" b-sjunaijqng><li class=""changelog-headsup"" b-sjunaijqng></li>
            <li b-sjunaijqng><a data-toggle=""collapse"" data-target=""#navbar-user-mobile"" class=""mobile-avatar-box"" b-sjunaijqng><img src=""https://www.gravatar.com/avatar/42244408b9891fd459ff321bf6bec578?s=80&amp;d=mm&amp;r=g"" class=""mobile-avatar"" alt b-sjunaijqng></a></li></ul></div>
    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "navbar-collapse collapse");
            __builder.AddAttribute(7, "id", "navbar-mobile");
            __builder.AddAttribute(8, "b-sjunaijqng");
            __builder.AddMarkupContent(9, @"<ul class=""nav navbar-nav"" b-sjunaijqng><li b-sjunaijqng><a class=""sidebar-control sidebar-main-toggle hidden-xs"" b-sjunaijqng><i class=""sicon-menu"" b-sjunaijqng></i></a></li></ul>
        <form class=""navbar-form navbar-left"" action=""https://s.salla.sa/search"" method=""get"" b-sjunaijqng></form>
        ");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "nav navbar-nav navbar-right");
            __builder.AddAttribute(12, "b-sjunaijqng");
            __builder.AddMarkupContent(13, "<li class=\"changelog-headsup\" b-sjunaijqng><a href=\"https://s.salla.sa/changelog\" target=\"_blank\" b-sjunaijqng> تحديثات المنصة</a></li>\r\n            ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "dropdown dropdown-user");
            __builder.AddAttribute(16, "b-sjunaijqng");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "class", "dropdown-toggle hidden-xs");
            __builder.AddAttribute(19, "data-toggle", "dropdown");
            __builder.AddAttribute(20, "aria-expanded", "false");
            __builder.AddAttribute(21, "b-sjunaijqng");
            __builder.AddMarkupContent(22, "<img src=\"https://www.gravatar.com/avatar/42244408b9891fd459ff321bf6bec578?s=80&amp;d=mm&amp;r=g\" alt b-sjunaijqng>\r\n                    ");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "b-sjunaijqng");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\adil\Desktop\Shop\Shop\Shared\NavMenu.razor"
                            authentication.User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    <i class=\"caret\" b-sjunaijqng></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, @"<ul class=""dropdown-menu dropdown-menu-right"" b-sjunaijqng><li b-sjunaijqng><a href=""https://s.salla.sa/profile"" b-sjunaijqng><i class=""sicon-user"" b-sjunaijqng></i> الملف الشخصي </a></li>
                    <li b-sjunaijqng><a href=""https://s.salla.sa/app/alerts"" b-sjunaijqng><i class=""sicon-notification"" b-sjunaijqng></i> التنبيهات</a></li>

                    <li class=""highlight"" b-sjunaijqng><a href=""https://s.salla.sa/changelog"" target=""_blank"" b-sjunaijqng><i class=""sicon-party-horn"" b-sjunaijqng></i> تحديثات المنصة </a></li>
                    <li class=""divider"" b-sjunaijqng></li>
                    <li b-sjunaijqng><a href=""identity/account/logout"" b-sjunaijqng><i class=""sicon-power"" b-sjunaijqng></i> تسجيل الخروج</a></li></ul>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, @"<div class=""navbar-collapse collapse my-navbar"" id=""navbar-user-mobile"" b-sjunaijqng><div class=""navbar-item"" b-sjunaijqng><a href=""https://s.salla.sa/profile"" b-sjunaijqng><i class=""sicon-user"" b-sjunaijqng></i> الملف الشخصي </a></div>
        <div class=""navbar-item"" b-sjunaijqng><a href=""https://s.salla.sa/app/alerts"" b-sjunaijqng><i class=""sicon-notification"" b-sjunaijqng></i> التنبيهات</a></div>

        <div class=""navbar-item highlight"" b-sjunaijqng><a href=""https://s.salla.sa/changelog"" target=""_blank"" b-sjunaijqng><i class=""sicon-party-horn"" b-sjunaijqng></i> تحديثات المنصة </a></div>
        <div class=""divider"" b-sjunaijqng></div>
        <div class=""navbar-item"" b-sjunaijqng><a href=""https://s.salla.sa/logout"" b-sjunaijqng><i class=""sicon-power"" b-sjunaijqng></i> تسجيل الخروج</a></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\adil\Desktop\Shop\Shop\Shared\NavMenu.razor"
      

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    public AuthenticationState authentication { get; set; }

    protected async override Task OnInitializedAsync()
    {
        authentication = await AuthenticationState;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
