#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428b43ce3d7cb2cf1732e10441fa27574c5a1f22"
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
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar sidebar-main");
            __builder.AddAttribute(2, "data-simplersidebar", "closed");
            __builder.AddAttribute(3, "style", "position: fixed; top: 50px; bottom: 0px; width: 260px; z-index: 3000; right: -260px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar-content");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar-user sidebar-user--basic");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "media");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "media-left no-padding");
            __builder.AddAttribute(12, "id", "store_avatar");
            __builder.AddMarkupContent(13, "<div class=\"store-img-wrapper\"><img id=\"store_avatar_img\" class=\"store-img img-circle img-sm\" alt=\"test\" src=\"https://assets.salla.sa/cp/assets/images/placeholder.png\"></div>\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "store-name-plan");
            __builder.AddMarkupContent(16, "<h6 class=\"store-name-side font-regular\">\r\n\r\n                            test\r\n                        </h6>\r\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "store-link dropdown");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"
                                      nav.BaseUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "target", "_blank");
            __builder.AddAttribute(22, "class", "btn visit-store");
            __builder.AddMarkupContent(23, "\r\n                                زيارة المتجر\r\n                                <i class=\"sicon-keyboard_arrow_left\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.AddMarkupContent(25, "<button class=\"btn share dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\"><i class=\"sicon-share-alt\"></i></button>\r\n                            ");
            __builder.OpenElement(26, "ul");
            __builder.AddAttribute(27, "class", "dropdown-menu dropdown-menu-right");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "dropdown-link");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "javascript:void(0)");
            __builder.AddAttribute(32, "data-text", 
#nullable restore
#line 29 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"
                                                                             nav.BaseUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "id", "link_store_url");
            __builder.AddAttribute(34, "class", "copy-site-url");
            __builder.AddMarkupContent(35, "<i class=\"sicon-swap-stroke\"></i>\r\n                                        نسخ رابط المتجر\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.AddMarkupContent(37, "<li class=\"dropdown-link\"><a target=\"_blank\" data-sharer=\"whatsapp\" data-title data-url=\"https://salla.sa/aldmlhe\" href=\"#\"><i class=\"sicon-whatsapp\"></i>\r\n                                        واتساب\r\n                                    </a></li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "sidebar-category sidebar-category-visible");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "category-content no-padding");
            __builder.OpenElement(43, "ul");
            __builder.AddAttribute(44, "class", "navigation navigation-main navigation-accordion");
            __builder.AddMarkupContent(45, "<li class><a href=\"/admin\"><i class=\"sicon-home\"></i>\r\n                            <span> الرئيسية</span></a></li>\r\n                    ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "href", "/products");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "<i class=\"sicon-t-shirt\"></i>\r\n                            ");
                __builder2.AddMarkupContent(52, "<span> المنتجات</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.AddMarkupContent(54, "<li class><a href=\"/orders\"><i class=\"sicon-box\"></i>\r\n                            <span> الطلبات</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(55, "<li class><a href=\"/customers\"><i class=\"sicon-users\"></i>\r\n                            <span> العملاء</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(56, "<li class><a href><i class=\"sicon-chart-pie\"></i>\r\n                            <span> التقارير</span></a></li>\r\n                    ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "href", "/admin/feedback");
            __builder.AddMarkupContent(61, "<i class=\"sicon-chat-conversation-alt\"></i> ");
            __builder.AddMarkupContent(62, "<span>الأسئلة والتقييمات</span>");
#nullable restore
#line 85 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"
                             if (showNotifications)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "badge bg-danger");
            __builder.AddAttribute(65, "id", "feedback_badge");
            __builder.AddContent(66, 
#nullable restore
#line 87 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"
                                                                                   index

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.AddMarkupContent(68, "<li class><a href><i class=\"sicon-newspaper\"></i>\r\n                            <span> الصفحات التعريفية</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(69, "<li class=\"navigation-header\"><span>التسويق</span></li>\r\n                    ");
            __builder.AddMarkupContent(70, "<li class><a href><i class=\"sicon-ticket\"></i>\r\n                            <span>كوبونات التخفيض</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(71, "<li class><a href><i class=\"sicon-special-discount\"></i>\r\n                            <span>العروض الخاصة</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(72, "<li class><a href><i class=\"sicon-paper-plane-o\"></i>\r\n                            <span>الحملات التسويقية</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(73, "<li class><a href><i class=\"sicon-shopping\"></i>\r\n                            <span>السلات المتروكة</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(74, "<li class=\"navigation-header\"><span>الاعدادات</span></li>\r\n                    ");
            __builder.AddMarkupContent(75, "<li class><a href><i class=\"sicon-settings\"></i>\r\n                            <span>إعدادات المتجر</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(76, "<li class><a href><i class=\"sicon-window-layout\"></i>\r\n                            <span>تصميم المتجر</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(77, "<li class><a href><i class=\"sicon-iphone\"></i>\r\n                            <span>تصميم التطبيق</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(78, "<li class><a href><i class=\"sicon-wallet\"></i>\r\n                            <span>المحفظة والفواتير</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(79, "<li class><a href class=\"salla-store-link\"><i class=\"sicon-store\"></i>\r\n                            <span> متجر سلة</span></a></li>\r\n                    ");
            __builder.AddMarkupContent(80, "<li class=\"navigation-header hidden-xs\"><span>تطبيق التاجر</span></li>\r\n                    ");
            __builder.AddMarkupContent(81, "<p style=\"margin: 0 18px 0 5px; display: inline-block;\" class=\"align-center hidden-xs\"><a href=\"https://itunes.apple.com/sa/app/slt-ttbyq-altajr/id1148458340?mt=8\" target=\"_blank\" class=\"appstore\"></a></p>\r\n                    ");
            __builder.AddMarkupContent(82, "<p style=\"margin: 0; display: inline-block;\" class=\"align-center hidden-xs\"><a href=\"https://play.google.com/store/apps/details?id=com.emoney.sallacp\" target=\"_blank\" class=\"googleplay\"></a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "C:\Users\adil\Desktop\Shop\Shop\Shared\SideBar.razor"
      
    List<CommentModel> commentModels = new List<CommentModel>();
    int index;
    bool showNotifications = false;

    protected override void OnInitialized()
    {
        commentModels = unitOfwork.ProductRepository.GetAllComments();

        commentModels.ForEach(w => { if (!w.Reply) { index++; showNotifications = true; } });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork unitOfwork { get; set; }
    }
}
#pragma warning restore 1591
