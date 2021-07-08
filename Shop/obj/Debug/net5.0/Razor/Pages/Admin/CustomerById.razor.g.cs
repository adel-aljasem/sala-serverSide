#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e17d528e3a4649d91e80fb5f4c03c8fca66c3bda"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Pages.Admin
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
#nullable restore
#line 22 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using WMBlazorSlickCarousel.WMBSC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Moyasar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Moyasar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\adil\Desktop\Shop\Shop\_Imports.razor"
using Moyasar.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers/{id}")]
    public partial class CustomerById : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content-wrapper content-padding");
            __builder.AddAttribute(2, "id", "content_box");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "page-header page-header-xs");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-xs-12");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "page-header-content");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "page-title breadcrumb-container mobile-webview-hide");
            __builder.OpenElement(15, "nav");
            __builder.AddAttribute(16, "class", "nav-breadcrumb");
            __builder.AddAttribute(17, "aria-label", "breadcrumb");
            __builder.OpenElement(18, "ol");
            __builder.AddAttribute(19, "class", "breadcrumb");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "breadcrumb-item home");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 25 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                  nav.BaseUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "<i class=\"sicon-home\"></i>\r\n                                            الرئيسية\r\n                                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                    ");
            __builder.AddMarkupContent(26, "<li class=\"breadcrumb-item \"><a href=\"/customers\">\r\n                                            العملاء\r\n                                        </a></li>\r\n                                    ");
            __builder.AddMarkupContent(27, "<li class=\"breadcrumb-item active\">adelaljasem</li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, @"<div class=""heading-elements heading-help mobile-webview-hide""><div class=""btn-group heading-btn""><button class=""btn bg-tiffany btn-icon btn-sm load_help_center_modal"" data-toggle=""dropdown""><i class=""sicon-life-ring""></i>
                                    <span>مساعدة ؟</span></button></div>
                            <div id=""help_center_div""></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-lg-12");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-12");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "panel panel-default");
            __builder.AddMarkupContent(41, @"<div class=""panel-heading""><h6 class=""panel-title title-thin""> العميل </h6>
                                <div class=""heading-elements""><div class=""btn-group""><button type=""button"" class=""btn btn-tiffany btn-xs dropdown-toggle"" data-toggle=""dropdown""><i class=""sicon-user""></i>&nbsp; خيارات العميل
                                        </button>
                                        <ul class=""dropdown-menu dropdown-menu-right""><li><a href=""#"" data-toggle=""modal"" data-target=""#modal_message_send"" class=""button_message_send""><i class=""sicon-chat-conversation""></i> ارسال رسالة
                                                </a></li>
                                            <li><a href=""#"" data-toggle=""modal"" data-target=""#modal_customer""><i class=""sicon-edit""></i> تعديل العميل
                                                </a></li>
                                            <li><a class=""unban-customer"" style=""display: none""><i class=""sicon-check""></i> إلغاء الحظر
                                                </a>
                                                <a class=""ban-customer""><i class=""sicon-block""></i> حظر العميل
                                                </a></li></ul></div></div></div>
                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "panel-body");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "media");
            __builder.AddMarkupContent(46, "<div class=\"media-left\"><a href=\"https://assets.salla.sa/cp/assets/images/avatar_male.png\"><img src=\"https://assets.salla.sa/cp/assets/images/avatar_male.png\" class=\"img-circle img-lg\" alt></a></div>\r\n                                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "media-body");
            __builder.OpenElement(49, "h6");
            __builder.AddAttribute(50, "class", "media-heading");
            __builder.AddContent(51, 
#nullable restore
#line 98 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                                   Customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "tel:" + (
#nullable restore
#line 99 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                      Customer.PhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "style", "direction: ltr; display: inline-block; text-align: right;");
            __builder.AddContent(56, 
#nullable restore
#line 100 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                             Customer.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\r\n                                            ");
            __builder.AddMarkupContent(58, "<span style=\"direction: rtl; display: inline-block; background: #5CD5C4; margin-left: 5px; color: #fff; padding: 2px 9px; border-radius: 99px; font-size: 12px;\"><i class=\"sicon-phone\" style=\"vertical-align: text-bottom; font-size: 13px;\"></i> اتصل</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                    ");
            __builder.AddMarkupContent(60, "<div class=\"media-right media-body-middle\"><p class=\"text-muted\">جدة, السعودية</p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, @"<div class=""row""><div class=""col-lg-12""><div class=""panel panel-flat""><div class=""panel-heading""><h6 class=""panel-title""><i class=""sicon-box""></i>&nbsp; الطلبات</h6>
                                <div class=""heading-elements""><ul class=""nav nav-pills nav-pills-toolbar text-right nav-pills-small hidden""><li class=""active""><a href> الكل</a></li>
                                        <li class><a href>بإنتظار المراجعة</a></li>
                                        <li class><a href> قيد التنفيذ </a></li></ul></div></div>
                            <div class=""no-more-tables""><table class=""table text-nowrap""><tbody><tr><td><span class=""text-muted""> لا توجد بيانات</span></td></tr></tbody></table></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n\r\n\r\n\r\n        ");
            __builder.AddMarkupContent(64, "<div class=\"footer text-muted\"><a href=\"https://s.salla.sa\" target=\"_blank\"> سلة</a> © 2021\r\n        </div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.OpenComponent<Shop.Pages.Admin.Modals.Modal_Customer>(66);
            __builder.AddAttribute(67, "ApplicationUser", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Data.ApplicationUser>(
#nullable restore
#line 159 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                         Customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "StateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 159 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                                                 UpdateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.OpenComponent<Shop.Pages.Admin.Modals.Modal_message_send>(70);
            __builder.AddAttribute(71, "ApplicationUser", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Data.ApplicationUser>(
#nullable restore
#line 160 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
                                                             Customer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 161 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\CustomerById.razor"
       

    [Parameter]
    public string Id { get; set; }

    public ApplicationUser Customer { get; set; } = new ApplicationUser();

    protected async override Task OnInitializedAsync()
    {

        await UpdateUser();

    }

    private async Task UpdateUser()
    {
        Customer = unitOfwork.UserRepository.GetUser(Id);

        if (Customer == null)
        {
            nav.NavigateTo("/");
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork unitOfwork { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
