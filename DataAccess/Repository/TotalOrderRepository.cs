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
    public class TotalOrderRepository
    {
        private ApplicationDbContext Db { get; set; }
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        public TotalOrderRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;
        }

        public IEnumerable<TotalOrderModel> GetAll(string idUser)
        {
            try
            {
                var TotalOrders = Db.TotalOrder.Where(w => w.IdUser == idUser).Include(a => a.Orders).ToList();
                return mapper.Map<IEnumerable<TotalOrder>, IEnumerable<TotalOrderModel>>(TotalOrders);
            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        public TotalOrder Add(TotalOrderModel totalOrderModel)
        {
            try
            {
                var totalOrder = mapper.Map<TotalOrderModel, TotalOrder>(totalOrderModel);
                Db.Add(totalOrder);
                return totalOrder;
                
            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;
            }
        }



    }
}
