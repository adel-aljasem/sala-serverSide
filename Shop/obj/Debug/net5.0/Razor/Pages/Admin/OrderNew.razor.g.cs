#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\OrderNew.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f09b9ec81fb17291573234b2d109e4e6c623609"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/order/new")]
    public partial class OrderNew : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content-wrapper content-padding");
            __builder.AddAttribute(2, "id", "content_box");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "res_sf");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "class", "navbar-form navbar-left");
            __builder.AddAttribute(7, "action", "https://s.salla.sa/search");
            __builder.AddAttribute(8, "method", "get");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "search-group");
            __builder.AddMarkupContent(11, "<input type=\"text\" id=\"searchbox\" name=\"keyword\" class=\"form-control search-input input-lg\" placeholder=\"ابحث برقم الطلب ، اسم العميل ، رقم الشحنة\" value>\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "btn-group bootstrap-select search-select hidden");
            __builder.AddMarkupContent(14, @"<button type=""button"" class=""btn dropdown-toggle btn-default"" data-toggle=""dropdown"" role=""button"" data-id=""search_input_type"" title=""الطلبات""><span class=""filter-option pull-left"">الطلبات</span>&nbsp;<span class=""bs-caret""><span class=""caret""></span></span></button>");
            __builder.AddMarkupContent(15, @"<div class=""dropdown-menu open"" role=""combobox""><ul class=""dropdown-menu inner"" role=""listbox"" aria-expanded=""false""><li data-original-index=""0"" class=""selected""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""true""><span class=""text"">الطلبات</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li><li data-original-index=""1""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""false""><span class=""text"">المنتجات</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li><li data-original-index=""2""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""false""><span class=""text"">العملاء</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li></ul></div>");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "search-select hidden");
            __builder.AddAttribute(18, "id", "search_input_type");
            __builder.AddAttribute(19, "name", "search_type");
            __builder.AddAttribute(20, "data-dropup-auto", "false");
            __builder.AddAttribute(21, "tabindex", "-98");
            __builder.AddAttribute(22, "style", "display: inline-block;");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "orders");
            __builder.AddMarkupContent(25, "الطلبات");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "products");
            __builder.AddMarkupContent(29, "المنتجات");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "customers");
            __builder.AddMarkupContent(33, "العملاء");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<div class=\"input-group-btn\"><button type=\"submit\" class=\"btn btn-tiffany btn-lg\"><i class=\"sicon-search\"></i></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "page-header page-header-xs");
            __builder.AddAttribute(39, "id", "page_header_box");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-xs-12");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "page-header-content");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "page-title breadcrumb-container mobile-webview-hide");
            __builder.OpenElement(48, "nav");
            __builder.AddAttribute(49, "class", "nav-breadcrumb");
            __builder.AddAttribute(50, "aria-label", "breadcrumb");
            __builder.OpenElement(51, "ol");
            __builder.AddAttribute(52, "class", "breadcrumb");
            __builder.OpenElement(53, "li");
            __builder.AddAttribute(54, "class", "breadcrumb-item home");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "href", 
#nullable restore
#line 33 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\OrderNew.razor"
                                              nav.BaseUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "<i class=\"sicon-home\"></i>\r\n                                        الرئيسية\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.AddMarkupContent(59, "<li class=\"breadcrumb-item \"><a href=\"/orders\">\r\n                                        الطلبات\r\n                                    </a></li>\r\n                                ");
            __builder.AddMarkupContent(60, "<li class=\"breadcrumb-item active\">انشاء طلب</li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddMarkupContent(62, @"<div class=""heading-elements heading-help mobile-webview-hide""><div class=""btn-group heading-btn""><button class=""btn bg-tiffany btn-icon btn-sm load_help_center_modal"" data-toggle=""dropdown""><i class=""sicon-life-ring""></i>
                                <span>مساعدة ؟</span></button></div>
                        <div id=""help_center_div""></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "content ");
            __builder.AddMarkupContent(66, "<div id=\"progress-report-modal\" class=\"modal modal-backup fade in col-sm-6 col-sm-offset-3\" tabindex=\"-1\" style=\"direction: ltr;\"></div>\r\n\r\n\r\n        ");
            __builder.AddMarkupContent(67, "<div class=\"row\"><div class=\"col-lg-12\"><div class=\"panel panel-flat order-info-panel\"><div class=\"panel-body\"><div class=\"col-md-4 col-xs-12\"><div><span class=\"order-top-line\"><i class=\"sicon-hashtag\"></i> تعديل الطلب رقم\r\n                                </span>\r\n                                <div class=\"order-second-line\"><div class=\"rec-line-wrapper\"><div class=\"rec-order-no\">\r\n                                            17541644\r\n                                        </div></div></div></div></div>\r\n                        <div class=\"col-md-4 col-xs-12\"><div class=\"text-center\"><span class=\"order-top-line\"><i class=\"sicon-calendar-alt\"></i> تاريخ الطلب\r\n                                </span>\r\n                                <div class=\"order-second-line\"><div class=\"rec-line-wrapper\"><div class=\"rec-order-date\">\r\n                                            الجمعة 18 يونيو 2021 | 09:02 PM\r\n                                        </div></div></div></div></div>\r\n                        <div class=\"col-md-4 col-xs-12\"><div class=\"text-right\"><span class=\"order-top-line\"><i class=\"sicon-flag-wave\"></i> حالة الطلب</span>\r\n                                <div class=\"order-second-line text-right\"><div class=\"rec-order-status\">\r\n                                        جديد\r\n                                    </div></div></div></div></div>\r\n                    <div class=\"panel-footer\" style=\"border-top: none; padding: 15px 15px 10px;\"><div id=\"order_tags\" class=\"form-group rec-tags mb-0\"><ul id=\"tags_list\" class=\"rec-list rec-list--horizontal rec-list--tags rec-list--tags--icon-less mt-0\"><li class=\"title\">الوسوم:</li>\r\n                                <li class=\"input-wrapper\"><div class=\"input-group\" title=\"وسم الطلب\"><input type=\"hidden\" value=\"1370702255\" class=\"order_id\">\r\n                                        <input type=\"text\" name=\"sku\" class=\"form-control tag-field\" placeholder=\"اضافة وسم\" value>\r\n                                        <button type=\"button\" class=\"btn btn-tiffany btn-add-tag\" title=\"إضافة الوسم\"><i class=\"sicon-add\"></i></button></div></li></ul></div></div></div>\r\n\r\n                <div class=\"order-panels\"><div id=\"customer_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\">العميل</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"customer\" onclick=\"showBlock(\'customer\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-user\"></i></div></div></div>\r\n                        <style>\r\n                            [data-show-card] {\r\n                                cursor: pointer;\r\n                            }\r\n\r\n                            .unactive-small {\r\n                                color: #5dd5c4;\r\n                                border-bottom: 1px solid #5dd5c4;\r\n                                line-height: 1.5;\r\n                            }\r\n                        </style></div>\r\n                    <div id=\"shipping_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\"> الشحن</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"shipping\" onclick=\"showBlock(\'shipping\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-shipping\"></i></div></div></div></div>\r\n                    <div id=\"payment_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\">الدفع</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"payment\" onclick=\"showBlock(\'payment\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"media\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-banknote-dollar\"></i></div></div></div></div></div></div>\r\n                <div id=\"products_block\"><div class=\"panel panel-white\"><div class=\"panel-heading\"><h6 class=\"panel-title\"><i class=\"sicon-t-shirt\"></i>&nbsp; المنتجات</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany edit_block\" data-block-type=\"products\" onclick=\"showBlock(\'products\')\"><i class=\"sicon-add\"></i> اضافة منتج</a></div></div>\r\n                        <div class=\"no-more-tables\"><table class=\"table\"><thead><tr class=\"active hidden-xs\"><th>المنتج</th>\r\n                                        <th class=\"text-right\"> الوزن </th>\r\n                                        <th class=\"text-right\"> الكمية </th>\r\n                                        <th class=\"text-right\"> السعر</th>\r\n                                        <th class=\"text-right\"> المجموع</th></tr></thead>\r\n                                <tbody style=\"border-top: none !important;\"><tr class=\"table-row\"><td class=\"hidden-xs\"> مجموع السلة </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\" مجموع السلة \">\r\n                                            ٠ ر.س\r\n                                        </td></tr>\r\n                                    <tr class=\"table-row\"><td class=\"hidden-xs\"> تكلفة الشحن</td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"الشحن\"><h6 class=\"text-semibold\">\r\n                                                + ٠ ر.س\r\n                                            </h6></td></tr>\r\n                                    <tr class=\"table-row\"><td class=\"hidden-xs\">\r\n                                            كوبونات التخفيض\r\n                                        </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"كوبونات التخفيض\"><h6 class=\"text-semibold\"><a id=\"coupon_code_exist\" data-type=\"select\" data-value=\"0\" data-source=\"https://s.salla.sa/coupons/coupon_list/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" data-title=\"اختر الكوبون\" class=\"editable editable-click coupon_code\" data-original-title title>إضافة كوبون</a></h6></td></tr>\r\n                                    <tr class=\"active table-row\"><td class=\"hidden-xs\"> إجمالي الطلب </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"إجمالي الطلب\"><h6 class=\"text-semibold\"><span id=\"total_span\"> ٠ ر.س</span></h6></td></tr></tbody></table></div>\r\n                        <div id=\"item_quantity_div\"></div></div></div>\r\n                <div class=\"row\" style=\"margin-top: 70px\"><div class=\"col-xs-12\"><button type=\"button\" action=\"https://s.salla.sa/order/activate/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" class=\"btn btn-tiffany btn-full btn-rounded btn-xlg mb-30 activate_order\"><i class=\"sicon-check\"></i> إنشاء الطلب\r\n                        </button></div></div>\r\n                <div class=\"row\"><div class=\"col-xs-6 sub-btns text-right\"><button type=\"button\" action=\"https://s.salla.sa/order/draft/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" class=\"btn btn-default btn-rounded btn-xlg mb-20 activate_order\"><i class=\"sicon-folder-open\"></i> حفظ كمسودة\r\n                        </button></div>\r\n                    <div class=\"col-xs-6 main-btn\"><button id=\"remove_order\" class=\"btn btn-danger btn-rounded btn-xlg mb-20 confirmation\"><i class=\"sicon-cancel\"></i>حذف الطلب\r\n                        </button></div></div></div></div>\r\n        <div id=\"modal_block_div\"></div>\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "id", "modal_order_status_method");
            __builder.AddAttribute(70, "class", "modal fade modal-backup");
            __builder.AddAttribute(71, "style", "direction: ltr;");
            __builder.OpenElement(72, "form");
            __builder.AddAttribute(73, "method", "post");
            __builder.AddAttribute(74, "id", "order_status_form");
            __builder.AddMarkupContent(75, "<input type=\"hidden\" name=\"_token\" value=\"6Kn1DBQxyPe7HnqeFus6lyPYSJcDmj424UOo5Vh7\">\r\n                <input type=\"hidden\" value=\"zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" name=\"order_id\" id=\"order_id\">\r\n                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-dialog");
            __builder.AddAttribute(78, "style", "direction: rtl;");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-content no-padding");
            __builder.AddAttribute(81, "style", "padding-bottom: 15px;");
            __builder.AddMarkupContent(82, "<div class=\"modal-header bg-info\"><button type=\"button\" class=\"close\" data-dismiss=\"modal\">×</button>\r\n                            <h6 class=\"modal-title\"> حالة الطلب <span>#17541644</span></h6></div>\r\n                        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "modal-body");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "id", "order_status_body");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-xs-12");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "form-group mb-10");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "input-group");
            __builder.AddMarkupContent(95, "<span class=\"input-group-addon\"><i class=\"sicon-chat-conversation-alt\"></i></span>\r\n                                                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "btn-group bootstrap-select input-group-btn");
            __builder.AddMarkupContent(98, @"<button type=""button"" class=""btn dropdown-toggle btn-default"" data-toggle=""dropdown"" role=""button"" data-id=""order_status"" title=""بإنتظار الدفع""><span class=""filter-option pull-left"">بإنتظار الدفع</span>&nbsp;<span class=""bs-caret""><span class=""caret""></span></span></button>");
            __builder.AddMarkupContent(99, "<div class=\"dropdown-menu open\" role=\"combobox\"><ul class=\"dropdown-menu inner\" role=\"listbox\" aria-expanded=\"false\"><li data-original-index=\"0\" class=\"selected\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"true\"><span class=\"text\">بإنتظار الدفع</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"1\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">بإنتظار المراجعة</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"2\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">قيد التنفيذ</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"3\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم التنفيذ</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"4\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">جاري التوصيل</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"5\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم التوصيل</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"6\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم الشحن</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"7\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">ملغي</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"8\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">مسترجع</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li></ul></div>");
            __builder.OpenElement(100, "select");
            __builder.AddAttribute(101, "class", "bootstrap-select");
            __builder.AddAttribute(102, "id", "order_status");
            __builder.AddAttribute(103, "name", "order_status");
            __builder.AddAttribute(104, "style", "width: 100%");
            __builder.AddAttribute(105, "tabindex", "-98");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "1473353380");
            __builder.AddAttribute(108, "data-original-status", "1473353380");
            __builder.AddAttribute(109, "data-is-shippable", "0");
            __builder.AddMarkupContent(110, "بإنتظار الدفع");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                                        ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "566146469");
            __builder.AddAttribute(114, "data-original-status", "566146469");
            __builder.AddAttribute(115, "data-is-shippable", "0");
            __builder.AddMarkupContent(116, "بإنتظار المراجعة");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                                        ");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", "1939592358");
            __builder.AddAttribute(120, "data-original-status", "1939592358");
            __builder.AddAttribute(121, "data-is-shippable", "0");
            __builder.AddMarkupContent(122, "قيد التنفيذ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                                                        ");
            __builder.OpenElement(124, "option");
            __builder.AddAttribute(125, "value", "1298199463");
            __builder.AddAttribute(126, "data-original-status", "1298199463");
            __builder.AddAttribute(127, "data-is-shippable", "1");
            __builder.AddMarkupContent(128, "تم التنفيذ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                                        ");
            __builder.OpenElement(130, "option");
            __builder.AddAttribute(131, "value", "349994915");
            __builder.AddAttribute(132, "data-original-status", "349994915");
            __builder.AddAttribute(133, "data-is-shippable", "0");
            __builder.AddMarkupContent(134, "جاري التوصيل");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                                        ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "1723506348");
            __builder.AddAttribute(138, "data-original-status", "1723506348");
            __builder.AddAttribute(139, "data-is-shippable", "0");
            __builder.AddMarkupContent(140, "تم التوصيل");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                                                        ");
            __builder.OpenElement(142, "option");
            __builder.AddAttribute(143, "value", "814202285");
            __builder.AddAttribute(144, "data-original-status", "814202285");
            __builder.AddAttribute(145, "data-is-shippable", "0");
            __builder.AddMarkupContent(146, "تم الشحن");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                                                        ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "525144736");
            __builder.AddAttribute(150, "data-original-status", "525144736");
            __builder.AddAttribute(151, "data-is-shippable", "0");
            __builder.AddMarkupContent(152, "ملغي");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                                                        ");
            __builder.OpenElement(154, "option");
            __builder.AddAttribute(155, "value", "989286562");
            __builder.AddAttribute(156, "data-original-status", "989286562");
            __builder.AddAttribute(157, "data-is-shippable", "0");
            __builder.AddMarkupContent(158, "مسترجع");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                                ");
            __builder.AddMarkupContent(160, "<div class=\"row\"><div class=\"col-xs-12\"><div class=\"form-group mb-0\"><textarea id=\"status_note\" name=\"note\" placeholder=\" ملاحظات إضافية للعميل..\" maxlength=\"70\"></textarea></div></div></div>\r\n                                ");
            __builder.AddMarkupContent(161, "<div class=\"hidden\"><div id=\"companies_options\" data-company-id></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.AddMarkupContent(163, @"<div class=""modal-footer""><button type=""button"" id=""update_status"" class=""btn btn-info btn-save"" name=""update_button""> تعديل حالة الطلب</button>
                            <button class=""btn btn-info btn-close"" data-dismiss=""modal"">
                                إغلاق
                            </button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(165, "<div class=\"footer text-muted\"><a href=\"https://s.salla.sa\" target=\"_blank\"> سلة</a> © 2021\r\n    </div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591