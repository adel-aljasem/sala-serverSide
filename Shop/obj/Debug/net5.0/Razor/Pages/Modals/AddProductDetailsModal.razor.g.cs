#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af1cbb103356486df45dac676eb125b63a0c2a36"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Pages.Modals
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
    public partial class AddProductDetailsModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "modal_product_options");
            __builder.AddAttribute(2, "class", "modal fade modal-backup");
            __builder.AddAttribute(3, "style", "display: none;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.AddMarkupContent(8, "<div class=\"modal-header bg-info\"><button type=\"button\" class=\"close\" data-dismiss=\"modal\">×</button>\r\n                <h6 class=\"modal-title\">بيانات المنتج (dasd)</h6></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-body");
            __builder.AddMarkupContent(11, @"<ul class=""nav nav-tabs nav-tabs-solid nav-tabs-component nav-justified product-control-nav mb-15""><li class=""active""><a href=""#product-desc-tab"" data-toggle=""tab"" aria-expanded=""false""><i class=""sicon-content position-left""></i>بيانات المنتج</a></li></ul>
                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "tab-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tab-pane active");
            __builder.AddAttribute(16, "id", "product-desc-tab");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row product-data-row product");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-xs-12");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "<label>يتطلب شحن / توصيل ؟</label>\r\n                                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "input-group");
            __builder.AddMarkupContent(26, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-shipping\"></i></span>\r\n\r\n                                        ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "bootstrap-select");
            __builder.AddAttribute(29, "id", "require_shipping");
            __builder.AddAttribute(30, "name", "require_shipping");
            __builder.AddAttribute(31, "style", "width: 100%");
            __builder.AddAttribute(32, "tabindex", "-98");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                       ShimpmentString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShimpmentString = __value, ShimpmentString));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "False");
            __builder.AddMarkupContent(37, "\r\n                                                لا يتطلب\r\n                                                شحن\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n                                            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "True");
            __builder.AddMarkupContent(41, "\r\n                                                نعم، يتطلب\r\n                                                شحن\r\n                                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row product-data-row");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-xs-12");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group");
            __builder.AddMarkupContent(49, "<label>وزن المنتج</label>\r\n                                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "input-group");
            __builder.AddMarkupContent(52, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-luggage-cart\"></i></span>\r\n                                        ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "id", "product_weight");
            __builder.AddAttribute(56, "name", "weight");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "placeholder", "وزن المنتج");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                                        ProductModel.ProductModelDetails.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductModel.ProductModelDetails.Weight = __value, ProductModel.ProductModelDetails.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                        ");
            __builder.AddMarkupContent(62, "<span class=\"input-group-addon\">KG</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "row product-data-row");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-xs-12");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group");
            __builder.AddMarkupContent(70, "<label>رمز التخزين</label>\r\n                                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "input-group");
            __builder.AddAttribute(73, "title", "رمز التخزين SKU");
            __builder.AddMarkupContent(74, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-lock\"></i></span>\r\n                                        ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "placeholder", "رمز التخزين SKU");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                                        ProductModel.ProductModelDetails.SKU

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductModel.ProductModelDetails.SKU = __value, ProductModel.ProductModelDetails.SKU));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row product-data-row");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col-xs-12");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "<label>سعر التكلفة</label>\r\n                                    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "input-group");
            __builder.AddAttribute(91, "title", "سعر التكلفة");
            __builder.AddMarkupContent(92, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-lock\"></i></span>\r\n                                        ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "class", "form-control cost_price _parseArabicNumbers");
            __builder.AddAttribute(96, "placeholder", "سعر التكلفة");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                                        ProductModel.ProductModelDetails.CostPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductModel.ProductModelDetails.CostPrice = __value, ProductModel.ProductModelDetails.CostPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.AddMarkupContent(100, "<div class=\"hidden row\"><div class=\"col-xs-12\"><div class=\"form-group\"><input type=\"number\" class=\"form-control full-bordered\" id=\"current_product_price\" readonly value=\"321.00\"></div></div></div>\r\n                        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "row product-data-row");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-xs-6");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "form-group");
            __builder.AddMarkupContent(107, "<label>السعر المخفض</label>\r\n                                    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "input-group");
            __builder.AddAttribute(110, "title", "السعر المخفض");
            __builder.AddMarkupContent(111, "<span class=\"input-group-addon input-group-addon-small\"><i class=\"sicon-special-discount\"></i></span>\r\n                                        ");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "type", "text");
            __builder.AddAttribute(114, "class", "form-control product_sale_price _parseArabicNumbers");
            __builder.AddAttribute(115, "placeholder", "السعر المخفض");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                                        ProductModel.ProductModelDetails.DiscoutPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductModel.ProductModelDetails.DiscoutPrice = __value, ProductModel.ProductModelDetails.DiscoutPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n                        ");
            __builder.AddMarkupContent(119, @"<div class=""ql-toolbar ql-snow""><input type=""text"" style=""display: none;"" class=""quill_text_color_picker""><div class=""sp-replacer sp-light quill_text_color_picker_selector"" style=""display: none;""><div class=""sp-preview""><div class=""sp-preview-inner"" style=""background-color: rgb(0, 0, 0);""></div></div><div class=""sp-dd"">▼</div></div><input type=""text"" style=""display: none;"" class=""quill_text_background_color_picker"">
                            <div class=""sp-replacer sp-light quill_text_background_color_picker_selector"" style=""display: none;""><div class=""sp-preview""><div class=""sp-preview-inner"" style=""background-color: rgb(0, 0, 0);""></div></div>
                                <div class=""sp-dd"">▼</div></div></div>
                        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "id", "product_description");
            __builder.AddAttribute(122, "class", "ql-container ql-snow");
            __builder.OpenComponent<Blazored.TextEditor.BlazoredTextEditor>(123);
            __builder.AddAttribute(124, "Placeholder", "وصف المنتج");
            __builder.AddAttribute(125, "ToolbarContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(126, "select");
                __builder2.AddAttribute(127, "class", "ql-header");
                __builder2.OpenElement(128, "option");
                __builder2.AddAttribute(129, "selected");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                        ");
                __builder2.OpenElement(131, "option");
                __builder2.AddAttribute(132, "value", "1");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                        ");
                __builder2.OpenElement(134, "option");
                __builder2.AddAttribute(135, "value", "2");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                                        ");
                __builder2.OpenElement(137, "option");
                __builder2.AddAttribute(138, "value", "3");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                                        ");
                __builder2.OpenElement(140, "option");
                __builder2.AddAttribute(141, "value", "4");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                                        ");
                __builder2.OpenElement(143, "option");
                __builder2.AddAttribute(144, "value", "5");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                                    ");
                __builder2.AddMarkupContent(146, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                        <button class=""ql-italic""></button>
                                        <button class=""ql-underline""></button>
                                        <button class=""ql-strike""></button></span>
                                    ");
                __builder2.AddMarkupContent(147, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                        <select class=\"ql-background\"></select></span>\r\n                                    ");
                __builder2.AddMarkupContent(148, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                        <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                                    ");
                __builder2.AddMarkupContent(149, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
            }
            ));
            __builder.AddComponentReferenceCapture(150, (__value) => {
#nullable restore
#line 111 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                       QuillHtml = (Blazored.TextEditor.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.AddMarkupContent(152, @"<div class=""form-group mt-20 mb-0""><h6 class=""mt-0 mb-10"">
                                تحسينات SEO
                                <span class=""label label-primary label-rounded plan-team-background"">سلة برو</span></h6>
                            <div class=""row""><div class=""col-xs-12""><div class=""row""><div class=""col-md-12""><div class=""form-group""><label>عنوان صفحة المنتج (Page Title)</label>
                                                <div class=""input-group"" title=""عنوان صفحة المنتج (Page Title)""><span class=""input-group-addon input-group-addon-small""><i class=""sicon-type-square""></i></span>
                                                    <input type=""text"" id=""metadata_title"" name=""metadata_title"" maxlength=""70"" class=""form-control"" disabled placeholder=""عنوان صفحة المنتج (Page Title)"" value></div></div></div>
                                        <div class=""col-md-12 mt-20""><div class=""form-group""><label>وصف صفحة المنتج (Page Description)</label>
                                                <div class=""input-group"" title=""وصف صفحة المنتج (Page Description)""><span class=""input-group-addon input-group-addon-small""><i class=""sicon-content""></i></span>
<textarea name=""metadata_description"" class=""form-control"" id=""metadata_description"" maxlength=""150"" cols=""30"" rows=""2"" disabled placeholder=""وصف صفحة المنتج (Page Description)
                            ""></textarea></div></div></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                    <div class=\"tab-pane\" id=\"product-options-tab\" data-type=\"product\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "modal-footer");
            __builder.OpenElement(157, "button");
            __builder.AddAttribute(158, "type", "button");
            __builder.AddAttribute(159, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 180 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
                                                Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(160, "id", "save_product_options");
            __builder.AddAttribute(161, "class", "btn btn-tiffany btn-info btn-save");
            __builder.AddMarkupContent(162, "حفظ بيانات المنتج");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                ");
            __builder.AddMarkupContent(164, "<button type=\"button\" id=\"save_group_product\" class=\"btn btn-tiffany btn-info btn-save\" style=\"display: none\">حفظ مجموعة المنتجات</button>\r\n                ");
            __builder.AddMarkupContent(165, "<button class=\"btn btn-info btn-close\" data-dismiss=\"modal\">إلغاء</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 191 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddProductDetailsModal.razor"
      
    [Parameter]
    public ProductModel ProductModel { get; set; } = new ProductModel();
    [Parameter]
    public int Id { get; set; }
    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();
    public string ShimpmentString { get; set; }

    private async Task Save()
    {
        try
        {
            ProductModel.ProductModelDetails.Details = await QuillHtml.GetHTML();
            switch (ShimpmentString)
            {
                case "True":
                    ProductModel.ProductModelDetails.Shipment = true;
                    break;
                case "False":
                    ProductModel.ProductModelDetails.Shipment = false;
                    break;
            }
            await unitOfwork.ProductRepository.Update(ProductModel.ID, ProductModel);
            await unitOfwork.Complete();
            await jsRunTime.ToastrSuccess("تمت العملية بنجاح");
            await jsRunTime.InvokeVoidAsync("modalState", "#modal_product_options", "hide");

        }
        catch (Exception e)
        {
            await jsRunTime.ToastrError(e.Message);
        }
    }


    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        string? productDetails = ProductModel.ProductModelDetails.Details;
        if (productDetails != null)
        {
            QuillHtml.LoadHTMLContent(productDetails);

        }
        else
        {
            QuillHtml.LoadHTMLContent("");
        }



    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork unitOfwork { get; set; }
    }
}
#pragma warning restore 1591
