using AutoMapper;
using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<ProductModel, Product>().ForMember(d=>d.Category,opt=> opt.MapFrom(src=>src.CategoryModel)).ForMember(d => d.ProductDetails, opt => opt.MapFrom(src => src.ProductModelDetails)).ReverseMap();
            CreateMap<ImageModel, Image>().ReverseMap();
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<ProductDetailsModel, ProductDetails>().ReverseMap();
            CreateMap<OrderModel, Order>().ForMember(w=>w.Product,a=>a.MapFrom(s=>s.ProductModel)).ForMember(w => w.User, opt => opt.MapFrom(a => a.User)).ReverseMap();
            CreateMap<TotalOrderModel, TotalOrder>().ForMember(w => w.Orders, a => a.MapFrom(s => s.OrdersModel)).ForMember(w=>w.User,opt=>opt.MapFrom(a=>a.User)).ReverseMap();
            CreateMap<CommentModel, Comment>().ForMember(w => w.Product, a => a.MapFrom(s => s.ProductModel)).ForMember(w=>w.User,a=>a.MapFrom(s=>s.User)).ReverseMap();

        }
    }
}
