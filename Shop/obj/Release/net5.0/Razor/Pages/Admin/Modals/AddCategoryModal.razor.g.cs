#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f58b1d8dbb293765e66d7a83e0ed6873a2713e7"
// <auto-generated/>
#pragma warning disable 1591
namespace Shop.Pages.Admin.Modals
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
    public partial class AddCategoryModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "new_category");
            __builder.AddAttribute(2, "class", "modal fade modal-backup in");
            __builder.AddAttribute(3, "style", "display: none; padding-right: 17px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog");
            __builder.AddAttribute(6, "style", "direction: rtl;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor"
                         CategoryModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor"
                                                       AddCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "modal-content");
                __builder2.AddMarkupContent(15, "<div class=\"modal-header bg-info\">\r\n                    اضافة تصنيف جديد\r\n                    <button data-dismiss=\"modal\" type=\"button\" class=\"close\">×</button></div>\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "modal-body");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label>اسم التصنيف</label>\r\n                        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "input-group");
                __builder2.AddMarkupContent(23, "<span class=\"input-group-addon\"><i class=\"sicon-format-text\"></i></span>\r\n                            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "placeholder", "ادخل اسم التصنيف");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor"
                                                CategoryModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CategoryModel.Name = __value, CategoryModel.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "p");
                __builder2.AddAttribute(32, "style", "color:red");
                __Blazor.Shop.Pages.Admin.Modals.AddCategoryModal.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 21 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor"
                                                                         ()=>CategoryModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        <span class=\"help-block cs\" style=\"display: none;\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.AddMarkupContent(37, @"<div class=""rec-checkbox rec-checkbox--default rec-checkbox--large rec-checkbox--primary-bg""><input type=""checkbox"" name=""add_to_main"" id=""add_to_main"">
                        <label for=""add_to_main"">اضافة الى تصنيف رئيسي</label></div>
                    ");
                __builder2.AddMarkupContent(38, @"<div class=""form-group mb-0 mt-10 categories"" style=""display: none;""><div class=""vue-treeselect--custom vue-treeselect--without-effect vue-treeselect--full vue-treeselect vue-treeselect--single vue-treeselect--open-below"" is-default-expanded=""true""><div class=""vue-treeselect__control""><div class=""vue-treeselect__value-container""><div class=""vue-treeselect__placeholder vue-treeselect-helper-zoom-effect-off"">تحديد التصنيف الرئيسي</div>
                                    <div tabindex=""0"" class=""vue-treeselect__input-container""></div></div>
                                <div class=""vue-treeselect__control-arrow-container""><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 292.362 292.362"" class=""vue-treeselect__control-arrow""><path d=""M286.935 69.377c-3.614-3.617-7.898-5.424-12.848-5.424H18.274c-4.952 0-9.233 1.807-12.85 5.424C1.807 72.998 0 77.279 0 82.228c0 4.948 1.807 9.229 5.424 12.847l127.907 127.907c3.621 3.617 7.902 5.428 12.85 5.428s9.233-1.811 12.847-5.428L286.935 95.074c3.613-3.617 5.427-7.898 5.427-12.847 0-4.948-1.814-9.229-5.427-12.85z""></path></svg></div></div>
                            <div class=""vue-treeselect__menu-container"" style=""z-index: 999;""></div></div>
                        <span class=""help-block cs"" style=""display: none;""></span></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.AddMarkupContent(40, "<div class=\"modal-footer no-icons\"><button type=\"submit\" class=\"btn btn-info btn-save\">اضافة التصنيف</button>\r\n                    <button data-dismiss=\"modal\" class=\"btn btn-info btn-close\">إلغاء</button></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\AddCategoryModal.razor"
      
    public CategoryModel CategoryModel { get; set; } = new CategoryModel();

    private async Task AddCategory()
    {
        if (CategoryModel.Name != null)
        {
            

            UnitofWork.CategoryRepository.Add(CategoryModel);
            UnitofWork.Complete();
            await JSRuntime.InvokeVoidAsync("modalState", "#new_category", "hide");
            await JSRuntime.SweetAlertSuccess("تمت اضافة الصنف");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper Imapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork UnitofWork { get; set; }
    }
}
namespace __Blazor.Shop.Pages.Admin.Modals.AddCategoryModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
