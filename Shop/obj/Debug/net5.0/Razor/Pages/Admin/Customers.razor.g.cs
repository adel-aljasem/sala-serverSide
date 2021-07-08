#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22fdf8b51b721e51c901069029dc81514e619282"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(11, "<input type=\"text\" id=\"searchbox\" name=\"keyword\" class=\"form-control search-input input-lg\" placeholder=\"ابحث بإسم العميل ، رقم الجوال\" value>\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "btn-group bootstrap-select search-select hidden");
            __builder.AddMarkupContent(14, @"<button type=""button"" class=""btn dropdown-toggle btn-default"" data-toggle=""dropdown"" role=""button"" data-id=""search_input_type"" title=""العملاء""><span class=""filter-option pull-left"">العملاء</span>&nbsp;<span class=""bs-caret""><span class=""caret""></span></span></button>");
            __builder.AddMarkupContent(15, @"<div class=""dropdown-menu open"" role=""combobox""><ul class=""dropdown-menu inner"" role=""listbox"" aria-expanded=""false""><li data-original-index=""0""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""false""><span class=""text"">الطلبات</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li><li data-original-index=""1""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""false""><span class=""text"">المنتجات</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li><li data-original-index=""2"" class=""selected""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""true""><span class=""text"">العملاء</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li></ul></div>");
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
            __builder.AddAttribute(33, "selected");
            __builder.AddMarkupContent(34, "العملاء");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<div class=\"input-group-btn\"><button type=\"submit\" class=\"btn btn-tiffany btn-lg\"><i class=\"sicon-search\"></i></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "page-header page-header-xs");
            __builder.AddAttribute(40, "id", "page_header_box");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-xs-12");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "page-header-content");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "page-title breadcrumb-container mobile-webview-hide");
            __builder.OpenElement(49, "nav");
            __builder.AddAttribute(50, "class", "nav-breadcrumb");
            __builder.AddAttribute(51, "aria-label", "breadcrumb");
            __builder.OpenElement(52, "ol");
            __builder.AddAttribute(53, "class", "breadcrumb");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "breadcrumb-item home");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "href", 
#nullable restore
#line 35 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
                                              Nav.BaseUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(58, "<i class=\"sicon-home\"></i>\r\n                                        الرئيسية\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                ");
            __builder.AddMarkupContent(60, "<li class=\"breadcrumb-item active\">العملاء</li>");
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
            __builder.AddMarkupContent(66, "<div id=\"progress-report-modal\" class=\"modal modal-backup fade in col-sm-6 col-sm-offset-3\" tabindex=\"-1\" style=\"direction: ltr;\"></div>\r\n\r\n        ");
            __builder.AddMarkupContent(67, @"<div class=""row customers-row""><div class=""col-lg-12""><h6 class=""panel-title""><i class=""sicon-group""></i>&nbsp; مجموعات العملاء &nbsp;
                    <span class=""text-muted text-size-small"">(1 مجموعات) </span></h6>
                <div class=""store-setup-row mt-20 mb-50 clients-gp""><div><div class=""store-setup-item""><i class=""sicon-group""></i>
                            <div><a href data-id=""-1"" class=""ajax no-errors store-setup-title"" data-type=""get"" data-nonconfirm=""true"">
                                    جميع العملاء
                                </a>
                                <small class=""store-setup-desc hidden-xs display-block"">
                                    عميل واحد
                                </small></div></div></div>
                    <div class=""store-setup-item""><i class=""sicon-add""></i>
                        <div><a href class=""ajax no-errors store-setup-title"" data-type=""post"" data-nonconfirm=""true"">
                                مجموعة جديدة
                            </a>
                            <small class=""store-setup-desc hidden-xs display-block"">
                                &nbsp;
                            </small></div></div></div>
                <div id=""group_form_div""></div></div></div>
        ");
            __builder.AddMarkupContent(68, @"<div class=""row btns-row btns-row--sm""><div class=""col-sm-7 sub-btns""><ul class=""nav nav-lg""><li><a id=""rec_filter_toggle""><i class=""sicon-filter""></i> تصفية</a></li>
                    <li class=""dropdown""><a class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""sicon-toolbox""></i>
                            خدمات
                        </a>
                        <ul class=""dropdown-menu dropdown-menu-right""><li><a href class=""dropdown-link""><i class=""sicon-archive-upload""></i>
                                    استيراد العملاء
                                </a></li></ul></li></ul></div>
            <div class=""col-sm-5 main-btn""><button type=""button"" id=""modal_create_customer_button"" class=""btn btn-tiffany btn-rounded btn-xlg""><i class=""sicon-add""></i> عميل جديد</button></div></div>
        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row customers-row");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-lg-12");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "panel panel-flat");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "panel-heading");
            __builder.OpenElement(77, "h6");
            __builder.AddAttribute(78, "class", "panel-title");
            __builder.AddMarkupContent(79, "<div class=\"checker\" id=\"uniform-checkbox_all_customers\"><span><input type=\"checkbox\" class=\"styled\" id=\"checkbox_all_customers\"></span></div>\r\n                            <i class=\"sicon-users\"></i>&nbsp; العملاء\r\n                            &nbsp;");
            __builder.OpenElement(80, "span");
            __builder.AddAttribute(81, "class", "text-muted text-size-small");
            __builder.AddMarkupContent(82, "\r\n                                (");
            __builder.AddContent(83, 
#nullable restore
#line 133 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
                                  Users.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(84, "\r\n                                عميل)\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.AddMarkupContent(86, @"<div class=""heading-elements""><div class=""btn-group heading-btn""><button type=""button"" class=""btn btn-tiffany btn-xs dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""sicon-magic-wand flip-x""></i> تحرير سريع
                                </button>
                                <ul class=""dropdown-menu dropdown-menu-right""></ul></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "no-more-tables table-with-links");
            __builder.AddMarkupContent(90, "<div class=\"render\" style=\"text-align:center;display: none\"></div>");
#nullable restore
#line 151 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
                         foreach (var customer in Users)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "table text-nowrap");
            __builder.OpenElement(93, "tbody");
            __builder.AddAttribute(94, "id", "table_list_customer");
            __builder.AddAttribute(95, "class", "infinite-scroll");
            __builder.OpenElement(96, "tr");
            __builder.AddAttribute(97, "class", "table-row customer-row");
            __builder.OpenElement(98, "td");
            __builder.AddAttribute(99, "class", "order-customer customer-td");
            __builder.AddMarkupContent(100, @"<div class=""media-left media-middle""><div class=""checkbox-area""><div class=""checker""><span><input type=""checkbox"" data-customer-name=""adelaljasem"" class=""styled checkbox_order selected_customers"" value=""6617879"" data-name=""adel aljasem""></span></div></div>
                                                <a href=""#""><img src=""https://assets.salla.sa/cp/assets/images/avatar_male.png"" class=""img-circle"" alt></a></div>
                                            ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "media-left media-body-middle");
            __builder.OpenElement(103, "div");
            __builder.OpenElement(104, "a");
            __builder.AddAttribute(105, "href", "#");
            __builder.AddContent(106, 
#nullable restore
#line 166 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
                                                         customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 175 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.AddMarkupContent(108, "<div class=\"page-load-status\" style=\"display: none\"><div class=\"infinite-scroll-request\"><div class=\"loader\"></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        <div id=\"group_bulk_form_div\"></div>\r\n        <div id=\"customer_form_div\"></div>\r\n\r\n        ");
            __builder.OpenElement(110, "form");
            __builder.AddAttribute(111, "method", "GET");
            __builder.AddAttribute(112, "id", "filters_form");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "rec-filter-wrapper");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "rec-filter-cont");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "rec-filters");
            __builder.AddMarkupContent(119, "<h1 class=\"title title--small\"><i class=\"sicon-filter\"></i>\r\n                            فرز العملاء حسب\r\n                            <button id=\"filter_close\" class=\"btn btn--circular\"></button></h1>\r\n                        ");
            __builder.AddMarkupContent(120, @"<div class=""rec-filter__section""><div id=""filter_text"" class=""collapse filter-content collapse in"" aria-expanded=""true""><ul class=""rec-list rec-list--vertical""><li><div class=""form-group""><div class=""form-group"">
                                                طلبات جديدة
                                                <label>الإسم او رقم الجوال يحتوي على</label>
                                                <div class=""input-group""><span class=""input-group-addon input-group-addon-small""><i class=""sicon-user""></i></span>
                                                    <input class=""form-control"" id=""search_keyword"" name=""keyword"" value placeholder=""ابحث عن ما تريد""></div></div></div></li></ul></div></div>
                        ");
            __builder.AddMarkupContent(121, @"<div class=""rec-filter__section""><button type=""button"" data-toggle=""collapse"" data-target=""#filter_gender"" class=""btn filter-head"" aria-expanded=""true""><span><i class=""sicon-user""></i>
                                    الجنس
                                </span></button>
                            <div id=""filter_gender"" class=""collapse filter-content collapse in"" aria-expanded=""true""><ul class=""rec-list rec-list--vertical""><li><div class=""rec-checkbox rec-checkbox--default light""><input type=""radio"" name=""gender"" value id=""gender_all"" checked>
                                            <label for=""gender_all""><span>الكل</span></label></div></li>
                                    <li><div class=""rec-checkbox rec-checkbox--default light""><input type=""radio"" name=""gender"" value=""male"" id=""gender_male"">
                                            <label for=""gender_male""><span>الذكور</span></label></div></li>
                                    <li><div class=""rec-checkbox rec-checkbox--default light""><input type=""radio"" name=""gender"" value=""female"" id=""gender_female"">
                                            <label for=""gender_female""><span>الإناث</span></label></div></li></ul></div></div>
                        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "rec-filter__section");
            __builder.AddMarkupContent(124, @"<button type=""button"" data-toggle=""collapse"" data-target=""#filter_address"" class=""btn filter-head"" aria-expanded=""true""><span><i class=""sicon-location""></i>
                                    العنوان
                                </span></button>
                            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "id", "filter_address");
            __builder.AddAttribute(127, "class", "collapse filter-content collapse in");
            __builder.AddAttribute(128, "aria-expanded", "true");
            __builder.OpenElement(129, "ul");
            __builder.AddAttribute(130, "class", "rec-list rec-list--vertical");
            __builder.OpenElement(131, "li");
            __builder.AddAttribute(132, "id", "city_filter_container");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "form-group");
            __builder.AddMarkupContent(135, "<label>المدينة</label>\r\n                                            ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "input-group");
            __builder.AddMarkupContent(138, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-flag-wave\"></i></span>\r\n                                                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "btn-group bootstrap-select input-group-btn");
            __builder.AddMarkupContent(141, @"<button type=""button"" class=""btn dropdown-toggle bs-placeholder btn-default"" data-toggle=""dropdown"" role=""button"" data-id=""city_filter"" title=""كل المدن""><span class=""filter-option pull-left"">كل المدن</span>&nbsp;<span class=""bs-caret""><span class=""caret""></span></span></button>");
            __builder.AddMarkupContent(142, @"<div class=""dropdown-menu open"" role=""combobox""><ul class=""dropdown-menu inner"" role=""listbox"" aria-expanded=""false""><li data-original-index=""0"" class=""selected""><a tabindex=""0"" class data-tokens=""null"" role=""option"" aria-disabled=""false"" aria-selected=""true""><span class=""text"">كل المدن</span><span class=""glyphicon glyphicon-ok check-mark""></span></a></li></ul></div>");
            __builder.OpenElement(143, "select");
            __builder.AddAttribute(144, "class", "selectpicker bootstrap-select");
            __builder.AddAttribute(145, "name", "city");
            __builder.AddAttribute(146, "id", "city_filter");
            __builder.AddAttribute(147, "tabindex", "-98");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value");
            __builder.AddMarkupContent(150, "كل المدن");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.AddMarkupContent(152, @"<div class=""rec-filter__section""><button type=""button"" data-toggle=""collapse"" data-target=""#filter_groups"" class=""btn filter-head"" aria-expanded=""true""><span><i class=""sicon-users""></i>
                                    المجموعات
                                </span></button>
                            <div id=""filter_groups"" class=""collapse filter-content collapse in"" aria-expanded=""true""><ul class=""rec-list rec-list--vertical""><li><div class=""alert alert-warning text-center"">
                                            لا يوجد مجموعات في متجرك حاليا
                                        </div></li></ul></div></div>
                        ");
            __builder.AddMarkupContent(153, "<div class=\"rec-filter__section\"><button type=\"button\" data-toggle=\"collapse\" data-target=\"#filter_dates\" class=\"btn filter-head\" aria-expanded=\"true\"><span><i class=\"sicon-align-right\"></i>\r\n                                    تاريخ فتح حساب\r\n                                </span></button>\r\n                            <div id=\"filter_dates\" class=\"collapse filter-content collapse in\" aria-expanded=\"true\"><ul class=\"rec-list rec-list--vertical\"><li><div class=\"form-group\"><div class=\"ui filter calendar filter_range_start\" style=\"max-height:35px\"><div class=\"input-group\"><div class=\"ui popup calendar\"><table class=\"ui celled center aligned unstackable table day\"><thead><tr><th colspan=\"7\"><span class=\"link\">June 2021</span><span class=\"prev link\"><i class=\"sicon-keyboard_arrow_left\"></i></span><span class=\"next link\"><i class=\"sicon-keyboard_arrow_right\"></i></span></th></tr><tr><th>S</th><th>M</th><th>T</th><th>W</th><th>T</th><th>F</th><th>S</th></tr></thead><tbody><tr><td class=\"link adjacent disabled\">30</td><td class=\"link adjacent disabled\">31</td><td class=\"link\">1</td><td class=\"link\">2</td><td class=\"link\">3</td><td class=\"link\">4</td><td class=\"link\">5</td></tr><tr><td class=\"link\">6</td><td class=\"link\">7</td><td class=\"link\">8</td><td class=\"link\">9</td><td class=\"link\">10</td><td class=\"link\">11</td><td class=\"link\">12</td></tr><tr><td class=\"link\">13</td><td class=\"link\">14</td><td class=\"link\">15</td><td class=\"link\">16</td><td class=\"link\">17</td><td class=\"link today focus\">18</td><td class=\"link\">19</td></tr><tr><td class=\"link\">20</td><td class=\"link\">21</td><td class=\"link\">22</td><td class=\"link\">23</td><td class=\"link\">24</td><td class=\"link\">25</td><td class=\"link\">26</td></tr><tr><td class=\"link\">27</td><td class=\"link\">28</td><td class=\"link\">29</td><td class=\"link\">30</td><td class=\"link adjacent disabled\">1</td><td class=\"link adjacent disabled\">2</td><td class=\"link adjacent disabled\">3</td></tr><tr><td class=\"link adjacent disabled\">4</td><td class=\"link adjacent disabled\">5</td><td class=\"link adjacent disabled\">6</td><td class=\"link adjacent disabled\">7</td><td class=\"link adjacent disabled\">8</td><td class=\"link adjacent disabled\">9</td><td class=\"link adjacent disabled\">10</td></tr></tbody></table></div>\r\n                                                    <span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-calendar-alt\"></i></span>\r\n                                                    <input type=\"text\" class=\"form-control created_dates\" placeholder=\"من\" name=\"created_after\" value autocomplete=\"off\"></div>\r\n                                                <span class=\"clear-date-btn clear-date-after-btn\" style=\"display:none;position: relative;top: -27px;right: 90%;z-index: 2;color: #f6695e;cursor: pointer;\" onclick=\"resetCreatedDate(\'created_after\')\"><i class=\"sicon-trash\"></i></span></div></div></li>\r\n                                    <li><div class=\"form-group\"><div class=\"ui filter calendar filter_range_end\" style=\"max-height:35px\"><div class=\"input-group\"><div class=\"ui popup calendar\"><table class=\"ui celled center aligned unstackable table day\"><thead><tr><th colspan=\"7\"><span class=\"link\">June 2021</span><span class=\"prev link\"><i class=\"sicon-keyboard_arrow_left\"></i></span><span class=\"next link\"><i class=\"sicon-keyboard_arrow_right\"></i></span></th></tr><tr><th>S</th><th>M</th><th>T</th><th>W</th><th>T</th><th>F</th><th>S</th></tr></thead><tbody><tr><td class=\"link adjacent disabled\">30</td><td class=\"link adjacent disabled\">31</td><td class=\"link\">1</td><td class=\"link\">2</td><td class=\"link\">3</td><td class=\"link\">4</td><td class=\"link\">5</td></tr><tr><td class=\"link\">6</td><td class=\"link\">7</td><td class=\"link\">8</td><td class=\"link\">9</td><td class=\"link\">10</td><td class=\"link\">11</td><td class=\"link\">12</td></tr><tr><td class=\"link\">13</td><td class=\"link\">14</td><td class=\"link\">15</td><td class=\"link\">16</td><td class=\"link\">17</td><td class=\"link today focus\">18</td><td class=\"link\">19</td></tr><tr><td class=\"link\">20</td><td class=\"link\">21</td><td class=\"link\">22</td><td class=\"link\">23</td><td class=\"link\">24</td><td class=\"link\">25</td><td class=\"link\">26</td></tr><tr><td class=\"link\">27</td><td class=\"link\">28</td><td class=\"link\">29</td><td class=\"link\">30</td><td class=\"link adjacent disabled\">1</td><td class=\"link adjacent disabled\">2</td><td class=\"link adjacent disabled\">3</td></tr><tr><td class=\"link adjacent disabled\">4</td><td class=\"link adjacent disabled\">5</td><td class=\"link adjacent disabled\">6</td><td class=\"link adjacent disabled\">7</td><td class=\"link adjacent disabled\">8</td><td class=\"link adjacent disabled\">9</td><td class=\"link adjacent disabled\">10</td></tr></tbody></table></div>\r\n                                                    <span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-calendar-alt\"></i></span>\r\n                                                    <input type=\"text\" class=\"form-control created_dates\" placeholder=\"إلى\" name=\"created_before\" value autocomplete=\"off\"></div>\r\n                                                <span class=\"clear-date-btn clear-date-before-btn\" style=\"display:none;position: relative;top: -27px;right: 90%;z-index: 2;color: #f6695e;cursor: pointer;\" onclick=\"resetCreatedDate(\'created_before\')\"><i class=\"sicon-trash\"></i></span></div></div></li></ul></div></div>\r\n                        ");
            __builder.AddMarkupContent(154, "<div class=\"rec-filter__submit\"><button type=\"submit\" class=\"btn btn-tiffany btn-rounded btn-filter-submit\">عرض النتائج</button>\r\n                            <button type=\"reset\" class=\"btn btn-outline-dark btn-filter-reset\">إعادة تعيين</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 344 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Customers.razor"
      

    public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        Users = await unitOfwork.UserRepository.GetAll();
        StateHasChanged();

    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork unitOfwork { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
