#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Main\OrderNew.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3a2da878fd57edc65486380d27f83c8acdb37a"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Pages.Main
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
            __builder.AddMarkupContent(37, @"<div class=""page-header page-header-xs"" id=""page_header_box""><div class=""row""><div class=""col-xs-12""><div class=""page-header-content""><div class=""page-title breadcrumb-container mobile-webview-hide""><nav class=""nav-breadcrumb"" aria-label=""breadcrumb""><ol class=""breadcrumb""><li class=""breadcrumb-item home""><a href=""https://s.salla.sa/home""><i class=""sicon-home""></i>
                                        الرئيسية
                                    </a></li>
                                <li class=""breadcrumb-item ""><a href=""https://s.salla.sa/orders"">
                                        الطلبات
                                    </a></li>
                                <li class=""breadcrumb-item active"">انشاء طلب</li></ol></nav></div>
                    <div class=""heading-elements heading-help mobile-webview-hide""><div class=""btn-group heading-btn""><button class=""btn bg-tiffany btn-icon btn-sm load_help_center_modal"" data-toggle=""dropdown""><i class=""sicon-life-ring""></i>
                                <span>مساعدة ؟</span></button></div>
                        <div id=""help_center_div""></div></div></div></div></div></div>


    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "content ");
            __builder.AddMarkupContent(40, "<div id=\"progress-report-modal\" class=\"modal modal-backup fade in col-sm-6 col-sm-offset-3\" tabindex=\"-1\" style=\"direction: ltr;\"></div>\r\n        \r\n       \r\n        ");
            __builder.AddMarkupContent(41, "<div class=\"row\"><div class=\"col-lg-12\"><div class=\"panel panel-flat order-info-panel\"><div class=\"panel-body\"><div class=\"col-md-4 col-xs-12\"><div><span class=\"order-top-line\"><i class=\"sicon-hashtag\"></i> تعديل الطلب رقم\r\n                                </span>\r\n                                <div class=\"order-second-line\"><div class=\"rec-line-wrapper\"><div class=\"rec-order-no\">\r\n                                            17541644\r\n                                        </div></div></div></div></div>\r\n                        <div class=\"col-md-4 col-xs-12\"><div class=\"text-center\"><span class=\"order-top-line\"><i class=\"sicon-calendar-alt\"></i> تاريخ الطلب\r\n                                </span>\r\n                                <div class=\"order-second-line\"><div class=\"rec-line-wrapper\"><div class=\"rec-order-date\">\r\n                                            الجمعة 18 يونيو 2021 | 09:02 PM\r\n                                        </div></div></div></div></div>\r\n                        <div class=\"col-md-4 col-xs-12\"><div class=\"text-right\"><span class=\"order-top-line\"><i class=\"sicon-flag-wave\"></i> حالة الطلب</span>\r\n                                <div class=\"order-second-line text-right\"><div class=\"rec-order-status\">\r\n                                        جديد\r\n                                    </div></div></div></div></div>\r\n                    <div class=\"panel-footer\" style=\"border-top: none; padding: 15px 15px 10px;\"><div id=\"order_tags\" class=\"form-group rec-tags mb-0\"><ul id=\"tags_list\" class=\"rec-list rec-list--horizontal rec-list--tags rec-list--tags--icon-less mt-0\"><li class=\"title\">الوسوم:</li>\r\n                                <li class=\"input-wrapper\"><div class=\"input-group\" title=\"وسم الطلب\"><input type=\"hidden\" value=\"1370702255\" class=\"order_id\">\r\n                                        <input type=\"text\" name=\"sku\" class=\"form-control tag-field\" placeholder=\"اضافة وسم\" value>\r\n                                        <button type=\"button\" class=\"btn btn-tiffany btn-add-tag\" title=\"إضافة الوسم\"><i class=\"sicon-add\"></i></button></div></li></ul></div></div></div>\r\n\r\n                <div class=\"order-panels\"><div id=\"customer_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\">العميل</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"customer\" onclick=\"showBlock(\'customer\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-user\"></i></div></div></div>\r\n                        <style>\r\n                            [data-show-card] {\r\n                                cursor: pointer;\r\n                            }\r\n\r\n                            .unactive-small {\r\n                                color: #5dd5c4;\r\n                                border-bottom: 1px solid #5dd5c4;\r\n                                line-height: 1.5;\r\n                            }\r\n                        </style></div>\r\n                    <div id=\"shipping_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\"> الشحن</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"shipping\" onclick=\"showBlock(\'shipping\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-shipping\"></i></div></div></div></div>\r\n                    <div id=\"payment_block\" class=\"panel panel-default order-panel rec-order-panel\"><div class=\"panel-heading\"><h6 class=\"panel-title title-thin\">الدفع</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany btn-xs edit_block\" data-block-type=\"payment\" onclick=\"showBlock(\'payment\')\"><i class=\"sicon-pencil\"></i> تعديل</a></div></div>\r\n                        <div class=\"panel-body\"><div class=\"media\"><div class=\"empty-box small-box\"><div class=\"empty-icon\"><i class=\"sicon-banknote-dollar\"></i></div></div></div></div></div></div>\r\n                <div id=\"products_block\"><div class=\"panel panel-white\"><div class=\"panel-heading\"><h6 class=\"panel-title\"><i class=\"sicon-t-shirt\"></i>&nbsp; المنتجات</h6>\r\n                            <div class=\"heading-elements\"><a class=\"btn btn-tiffany edit_block\" data-block-type=\"products\" onclick=\"showBlock(\'products\')\"><i class=\"sicon-add\"></i> اضافة منتج</a></div></div>\r\n                        <div class=\"no-more-tables\"><table class=\"table\"><thead><tr class=\"active hidden-xs\"><th>المنتج</th>\r\n                                        <th class=\"text-right\"> الوزن </th>\r\n                                        <th class=\"text-right\"> الكمية </th>\r\n                                        <th class=\"text-right\"> السعر</th>\r\n                                        <th class=\"text-right\"> المجموع</th></tr></thead>\r\n                                <tbody style=\"border-top: none !important;\"><tr class=\"table-row\"><td class=\"hidden-xs\"> مجموع السلة </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\" مجموع السلة \">\r\n                                            ٠ ر.س\r\n                                        </td></tr>\r\n                                    <tr class=\"table-row\"><td class=\"hidden-xs\"> تكلفة الشحن</td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"الشحن\"><h6 class=\"text-semibold\">\r\n                                                + ٠ ر.س\r\n                                            </h6></td></tr>\r\n                                    <tr class=\"table-row\"><td class=\"hidden-xs\">\r\n                                            كوبونات التخفيض\r\n                                        </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"كوبونات التخفيض\"><h6 class=\"text-semibold\"><a id=\"coupon_code_exist\" data-type=\"select\" data-value=\"0\" data-source=\"https://s.salla.sa/coupons/coupon_list/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" data-title=\"اختر الكوبون\" class=\"editable editable-click coupon_code\" data-original-title title>إضافة كوبون</a></h6></td></tr>\r\n                                    <tr class=\"active table-row\"><td class=\"hidden-xs\"> إجمالي الطلب </td>\r\n                                        <td colspan=\"4\" class=\"text-right td-cod\" data-title=\"إجمالي الطلب\"><h6 class=\"text-semibold\"><span id=\"total_span\"> ٠ ر.س</span></h6></td></tr></tbody></table></div>\r\n                        <div id=\"item_quantity_div\"></div></div></div>\r\n                <div class=\"row\" style=\"margin-top: 70px\"><div class=\"col-xs-12\"><button type=\"button\" action=\"https://s.salla.sa/order/activate/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" class=\"btn btn-tiffany btn-full btn-rounded btn-xlg mb-30 activate_order\"><i class=\"sicon-check\"></i> إنشاء الطلب\r\n                        </button></div></div>\r\n                <div class=\"row\"><div class=\"col-xs-6 sub-btns text-right\"><button type=\"button\" action=\"https://s.salla.sa/order/draft/zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" class=\"btn btn-default btn-rounded btn-xlg mb-20 activate_order\"><i class=\"sicon-folder-open\"></i> حفظ كمسودة\r\n                        </button></div>\r\n                    <div class=\"col-xs-6 main-btn\"><button id=\"remove_order\" class=\"btn btn-danger btn-rounded btn-xlg mb-20 confirmation\"><i class=\"sicon-cancel\"></i>حذف الطلب\r\n                        </button></div></div></div></div>\r\n        <div id=\"modal_block_div\"></div>\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "id", "modal_order_status_method");
            __builder.AddAttribute(44, "class", "modal fade modal-backup");
            __builder.AddAttribute(45, "style", "direction: ltr;");
            __builder.OpenElement(46, "form");
            __builder.AddAttribute(47, "method", "post");
            __builder.AddAttribute(48, "id", "order_status_form");
            __builder.AddMarkupContent(49, "<input type=\"hidden\" name=\"_token\" value=\"6Kn1DBQxyPe7HnqeFus6lyPYSJcDmj424UOo5Vh7\">\r\n                <input type=\"hidden\" value=\"zBxNrKbp5Lw0M7vb2YyWP9Q6kXlGRn3g\" name=\"order_id\" id=\"order_id\">\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-dialog");
            __builder.AddAttribute(52, "style", "direction: rtl;");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-content no-padding");
            __builder.AddAttribute(55, "style", "padding-bottom: 15px;");
            __builder.AddMarkupContent(56, "<div class=\"modal-header bg-info\"><button type=\"button\" class=\"close\" data-dismiss=\"modal\">×</button>\r\n                            <h6 class=\"modal-title\"> حالة الطلب <span>#17541644</span></h6></div>\r\n                        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-body");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "id", "order_status_body");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-xs-12");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group mb-10");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "input-group");
            __builder.AddMarkupContent(69, "<span class=\"input-group-addon\"><i class=\"sicon-chat-conversation-alt\"></i></span>\r\n                                                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "btn-group bootstrap-select input-group-btn");
            __builder.AddMarkupContent(72, @"<button type=""button"" class=""btn dropdown-toggle btn-default"" data-toggle=""dropdown"" role=""button"" data-id=""order_status"" title=""بإنتظار الدفع""><span class=""filter-option pull-left"">بإنتظار الدفع</span>&nbsp;<span class=""bs-caret""><span class=""caret""></span></span></button>");
            __builder.AddMarkupContent(73, "<div class=\"dropdown-menu open\" role=\"combobox\"><ul class=\"dropdown-menu inner\" role=\"listbox\" aria-expanded=\"false\"><li data-original-index=\"0\" class=\"selected\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"true\"><span class=\"text\">بإنتظار الدفع</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"1\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">بإنتظار المراجعة</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"2\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">قيد التنفيذ</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"3\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم التنفيذ</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"4\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">جاري التوصيل</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"5\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم التوصيل</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"6\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">تم الشحن</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"7\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">ملغي</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li><li data-original-index=\"8\"><a tabindex=\"0\" class data-tokens=\"null\" role=\"option\" aria-disabled=\"false\" aria-selected=\"false\"><span class=\"text\">مسترجع</span><span class=\"glyphicon glyphicon-ok check-mark\"></span></a></li></ul></div>");
            __builder.OpenElement(74, "select");
            __builder.AddAttribute(75, "class", "bootstrap-select");
            __builder.AddAttribute(76, "id", "order_status");
            __builder.AddAttribute(77, "name", "order_status");
            __builder.AddAttribute(78, "style", "width: 100%");
            __builder.AddAttribute(79, "tabindex", "-98");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "1473353380");
            __builder.AddAttribute(82, "data-original-status", "1473353380");
            __builder.AddAttribute(83, "data-is-shippable", "0");
            __builder.AddMarkupContent(84, "بإنتظار الدفع");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                                        ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "566146469");
            __builder.AddAttribute(88, "data-original-status", "566146469");
            __builder.AddAttribute(89, "data-is-shippable", "0");
            __builder.AddMarkupContent(90, "بإنتظار المراجعة");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                                        ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "1939592358");
            __builder.AddAttribute(94, "data-original-status", "1939592358");
            __builder.AddAttribute(95, "data-is-shippable", "0");
            __builder.AddMarkupContent(96, "قيد التنفيذ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                                        ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "1298199463");
            __builder.AddAttribute(100, "data-original-status", "1298199463");
            __builder.AddAttribute(101, "data-is-shippable", "1");
            __builder.AddMarkupContent(102, "تم التنفيذ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                                        ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "349994915");
            __builder.AddAttribute(106, "data-original-status", "349994915");
            __builder.AddAttribute(107, "data-is-shippable", "0");
            __builder.AddMarkupContent(108, "جاري التوصيل");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                                        ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "1723506348");
            __builder.AddAttribute(112, "data-original-status", "1723506348");
            __builder.AddAttribute(113, "data-is-shippable", "0");
            __builder.AddMarkupContent(114, "تم التوصيل");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                                        ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", "814202285");
            __builder.AddAttribute(118, "data-original-status", "814202285");
            __builder.AddAttribute(119, "data-is-shippable", "0");
            __builder.AddMarkupContent(120, "تم الشحن");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                                        ");
            __builder.OpenElement(122, "option");
            __builder.AddAttribute(123, "value", "525144736");
            __builder.AddAttribute(124, "data-original-status", "525144736");
            __builder.AddAttribute(125, "data-is-shippable", "0");
            __builder.AddMarkupContent(126, "ملغي");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                                                        ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "989286562");
            __builder.AddAttribute(130, "data-original-status", "989286562");
            __builder.AddAttribute(131, "data-is-shippable", "0");
            __builder.AddMarkupContent(132, "مسترجع");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                                ");
            __builder.AddMarkupContent(134, "<div class=\"row\"><div class=\"col-xs-12\"><div class=\"form-group mb-0\"><textarea id=\"status_note\" name=\"note\" placeholder=\" ملاحظات إضافية للعميل..\" maxlength=\"70\"></textarea></div></div></div>\r\n                                ");
            __builder.AddMarkupContent(135, "<div class=\"hidden\"><div id=\"companies_options\" data-company-id></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.AddMarkupContent(137, @"<div class=""modal-footer""><button type=""button"" id=""update_status"" class=""btn btn-info btn-save"" name=""update_button""> تعديل حالة الطلب</button>
                            <button class=""btn btn-info btn-close"" data-dismiss=""modal"">
                                إغلاق
                            </button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(139, "<div class=\"footer text-muted\"><a href=\"https://s.salla.sa\" target=\"_blank\"> سلة</a> © 2021\r\n    </div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
