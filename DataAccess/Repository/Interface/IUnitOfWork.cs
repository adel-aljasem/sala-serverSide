using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ProductRepository ProductRepository { get; }
        ImageRepository ImageRepository { get; }
        CategoryRepository CategoryRepository { get; }

        UserRepository UserRepository { get; }
        Task<int> Complete();
    }
}
