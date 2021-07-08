using DataAccess.Models;
using DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;

namespace Shop.Helper
{
    public class Extensions
    {
        IUnitOfWork unitOfwork;
        IJSRuntime js;
        NavigationManager nav;
        RealtimeService realtimeSerive;
        AuthenticationStateProvider auth;
        RealtimeServiceOnline realTimeOnline;


        OrderModel orderModel = new OrderModel();


        public Extensions(IUnitOfWork unitOfwork, IJSRuntime js, NavigationManager nav, RealtimeService realtimeSerive, AuthenticationStateProvider auth, RealtimeServiceOnline realTimeOnline)
        {
            this.unitOfwork = unitOfwork;
            this.js = js;
            this.nav = nav;
            this.realTimeOnline = realTimeOnline;
            this.auth = auth;
            this.realtimeSerive = realtimeSerive;
        }



        public void AddToCart(ProductModel productModel , OrderModel orderModel)
        {
            try
            {
                orderModel.IdUser = realtimeSerive.GetCurrentUser().Result;

                if (orderModel.IdUser != null)
                {
                    orderModel.IdProduct = productModel.ID;
                    orderModel.Date = DateTime.Now;
                    orderModel.Price = orderModel.Quantity * productModel.Price.Value;
                    unitOfwork.OrderRepository.Add(orderModel);
                    unitOfwork.Complete();
                    realtimeSerive.Price += orderModel.Price;
                    realtimeSerive.Quantity += orderModel.Quantity;
                    realTimeOnline.UpdateNotficationOnAdminGUI();
                    js.ToastrSuccess("تمت اضافة المنتج للسلة");
                }
                else
                {
                    nav.NavigateTo("/identity/account/login", true);
                    js.ToastrError("عذرا يجب تسجيل الدخول");
                }
            }
            catch (Exception e)
            {
                js.ToastrError(e.Message);
            }
        }
    }
}
