#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fec4758f5cd0ef745aa5ea33a1ee1b1eb4754e"
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
    public partial class Modal_Customer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "modal_customer");
            __builder.AddAttribute(2, "class", "modal fade");
            __builder.AddAttribute(3, "style", "direction: ltr; display: none;");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "class", "ajax");
            __builder.AddMarkupContent(6, "<input type=\"hidden\">\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "style", "direction: rtl;");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header bg-info");
            __builder.AddMarkupContent(14, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\">×</button>\r\n                    ");
            __builder.OpenElement(15, "h6");
            __builder.AddAttribute(16, "class", "modal-title");
            __builder.AddMarkupContent(17, "تعديل معلومات المستخدم ( ");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor"
                                                                      User.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " )");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-body");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddAttribute(25, "id", "first_name_div");
            __builder.AddMarkupContent(26, "<label>الاسم الأول</label>\r\n                        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "class", "form-control right-border");
            __builder.AddAttribute(30, "placeholder", "الاسم الأول");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor"
                                            ApplicationUser.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ApplicationUser.Name = __value, ApplicationUser.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.AddMarkupContent(34, "<span class=\"error help-block\" style=\"display:none;\"> حقل الإسم الأول مطلوب </span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "<label>البريد الالكتروني</label>\r\n                        ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control right-border");
            __builder.AddAttribute(42, "placeholder", "البريد الالكتروني");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor"
                                            ApplicationUser.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ApplicationUser.Email = __value, ApplicationUser.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-footer");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor"
                                                    ()=>UpdateForm()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "class", "btn btn-primary btn-save");
            __builder.AddMarkupContent(52, "\r\n                        حفظ\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\adil\Desktop\Shop\Shop\Pages\Admin\Modals\Modal_Customer.razor"
      


    public UserModel User { get; set; } = new UserModel();
    [Parameter]
    public EventCallback StateChanged { get; set; }
    [Parameter]
    public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
    protected async override Task OnInitializedAsync()
    {
        try
        {

            User.Name = ApplicationUser.Name;
            User.Email = ApplicationUser.Email;


        }
        catch (Exception e)
        {

        }

    }



    private async Task UpdateForm()
    {
        try
        {
             UnitOfwork.UserRepository.Update(ApplicationUser.Id);
            await jsRuntime.ToastrSuccess("تمت العملية بنجاح");
            await StateChanged.InvokeAsync();
            await jsRuntime.InvokeVoidAsync("modalState", "#modal_customer", "hide");
        }
        catch (Exception e)
        {
            await jsRuntime.ToastrError(e.Message);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork UnitOfwork { get; set; }
    }
}
#pragma warning restore 1591
