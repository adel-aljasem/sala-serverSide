#pragma checksum "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6edc44905a47004d3b8affc409fc981435f384"
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
    public partial class AddPictureModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "modal_product_photos");
            __builder.AddAttribute(2, "class", "modal fade in");
            __builder.AddAttribute(3, "style", "display: none; padding-right: 17px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-header bg-info");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                  OnChangePhoto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "close");
            __builder.AddAttribute(14, "data-dismiss", "modal");
            __builder.AddMarkupContent(15, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<h6 class=\"modal-title\">صور وفيديوهات المنتج</h6>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "id", "product-images-tab");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "dropArea" + " " + (
#nullable restore
#line 18 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                          dropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n                        اسحب الصورة وافلتها هنا او تصفح من جهازك\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(26);
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                              uploading

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                                                   HandleImageUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                                                                                    HandleDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ondragleave", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                                                                                                                   HandleDragLeave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddMarkupContent(33, @"<div class=""form-group add-product-link""><div class=""rec-list rec-list--horizontal""><div class=""rec-list rec-list--horizontal""><span class=""input-group-addon""><i class=""sicon-media-player""></i></span>
                                <input type=""text"" placeholder=""أضف رابط فيديو من اليوتيوب"" class=""form-control""></div>
                            <button class=""btn btn-tiffany btn-add-link"" disabled>اضافة</button></div></div>
                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "id", "product_images");
            __builder.AddAttribute(36, "class", "rec-uploaded-images");
#nullable restore
#line 35 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                         if (productModel?.ID == ID)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                             foreach (var image in productModel.Images.Skip(1))
                            {
                                


#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "_slim");
            __builder.AddMarkupContent(39, "<div class=\"img-handle\"><i class=\"fa fa-arrows-alt\"></i></div>\r\n                                    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "slim-area");
            __builder.AddMarkupContent(42, @"<div class=""product-photo-seo""><i class=""alt"">Alt</i>
                                            <input type=""text"" name=""alt"" class=""form-control alts seo-tags"" maxlength=""70"" value placeholder=""نص توضيحي لمحركات البحث""></div>

                                        
                                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "slim-result");
            __builder.AddAttribute(45, "data-mode", "preview");
            __builder.AddAttribute(46, "data-aspect-ratio", "0.223");
            __builder.AddAttribute(47, "data-center", "0.5,0.543");
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "class", "in");
            __builder.AddAttribute(50, "style", "opacity: 1; z-index: 1; position:relative");
            __builder.AddAttribute(51, "src", 
#nullable restore
#line 51 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                                                                                                    image.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "product-photo-meta");
            __builder.AddMarkupContent(55, @"<label class=""radio-inline""><div class=""choice""><span><input type=""radio"" class=""styled product_image_main"" name=""image_main""></span></div> الصورة الأساسية
                                        </label>
                                        <i data-tippy-content=""Tooltip"" class=""sicon-crop crop-product-photo""></i>
                                        ");
            __builder.OpenElement(56, "i");
            __builder.AddAttribute(57, "class", "sicon-trash-2 action-icon remove-product-photo");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                                                                                            () => HandleImageDelete(image.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                             

                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    <div style=\"clear: both\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-footer");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
                                   OnChangePhoto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn bg-grey-400 pull-right");
            __builder.AddAttribute(67, "data-dismiss", "modal");
            __builder.AddMarkupContent(68, "<i class=\"sicon-cancel\"></i> إغلاق");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\adil\Desktop\Shop\Shop\Pages\Modals\AddPictureModal.razor"
      
    [Parameter]
    public int ID { get; set; }
    [Parameter]
    public ProductModel productModel { get; set; }
    [Parameter]
    public EventCallback OnChangePhoto { get; set; }


    int q;

    private string dropClass = "";
    bool uploading = false;


    void HandleDragEnter()
    {
        dropClass = "dropAreaDrug";
    }

    void HandleDragLeave()
    {
        dropClass = string.Empty;
    }



    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        try
        {
            uploading = true;
           

            if (e.FileCount > 0)
            {

                foreach (var file in e.GetMultipleFiles(30))
                {
                    FileInfo fileInfo = new FileInfo(file.Name);
                    string imageUrl = await FileUpload.UploadFile(file);
                    productModel.Images.Add(new ImageModel { ImageUrl = imageUrl, ProductId = productModel.ID });

                }


                if (productModel.Images.Count >= 1)
                {

                    await UnitOfWork.ProductRepository.Update(productModel.ID, productModel);
                    await UnitOfWork.Complete();

                   
                }
            }

            uploading = false;
        }
        catch (Exception ex)
        {
            string error = ex.Message;
        }

    }

    private async Task HandleImageDelete(int id)
    {
        var ImageToRemove = productModel.Images.FirstOrDefault(w => w.ID == id);
        productModel.Images.Remove(ImageToRemove);
        await UnitOfWork.ImageRepository.Remove(ImageToRemove.ID);
        var imageName = ImageToRemove.ImageUrl.Replace($"{nav.BaseUri}Images/","");
        fileUpload.DeleteFile(imageName);
        await UnitOfWork.Complete();
    }

  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitOfWork UnitOfWork { get; set; }
    }
}
#pragma warning restore 1591
