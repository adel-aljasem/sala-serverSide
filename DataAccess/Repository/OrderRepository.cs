using AutoMapper;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace DataAccess.Repository
{
    public class OrderRepository
    {
        private ApplicationDbContext Db { get; set; }
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        public OrderRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;
        }

        public List<OrderModel> GetAll(string userId)
        {
            try
            {
                var Orders = Db.Order.Include(w => w.Product).Where(w => w.IdUser == userId).ToList();
                return mapper.Map<List<Order>, List<OrderModel>>(Orders);

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        public List<OrderModel> GetAll()
        {
            try
            {
                var Orders = Db.Order.Include(w => w.Product).Include(w => w.User).ToList();
                return mapper.Map<List<Order>, List<OrderModel>>(Orders);

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        public void Update(OrderModel orderModel)
        {
            var foundObject = Db.Order.Find(orderModel.Id);
            var objectToUpdate = mapper.Map(orderModel, foundObject);
            Db.Order.Update(objectToUpdate);
        }
        public OrderModel GetById(int id, string userId)
        {
            try
            {
                var order = Db.Order.Find(id);
                if (order.IdUser == userId)
                {
                    return mapper.Map<Order, OrderModel>(order);

                }
                return null;

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;

            }
        }

        public bool Add(OrderModel orderModel)
        {
            try
            {
                var order = mapper.Map<OrderModel, Order>(orderModel);
                Db.Order.Add(order);
                return true;

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return false;

            }

        }

        public bool Remove(int id)
        {
            try
            {
                var FindOrder = Db.Order.Find(id);
                Db.Order.Remove(FindOrder);
                return true;
            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return false;

            }
        }

        public void RemoveAll(string idUser)
        {
            try
            {
                Db.Order.Where(w => w.IdUser == idUser).ToList();
            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
            }
        }



    }
}
