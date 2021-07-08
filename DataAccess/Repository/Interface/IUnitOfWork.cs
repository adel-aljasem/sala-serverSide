using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IUnitOfWork 
    {
        ProductRepository ProductRepository { get; }
        ImageRepository ImageRepository { get; }
        CategoryRepository CategoryRepository { get; }
        OrderRepository OrderRepository { get; }
        TotalOrderRepository TotalOrderRepository { get; }
        UserRepository UserRepository { get; }
        int Complete();
    }
}
