using AutoMapper;
using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.Interface;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        private readonly FileUpload fileUpload;
        private readonly UserManager<ApplicationUser> userManager;
        public ProductRepository ProductRepository { get; private set; }
        public ImageRepository ImageRepository { get; private set; }
        public UserRepository UserRepository { get; set; }
        public CategoryRepository CategoryRepository { get; private set; }

        public OrderRepository OrderRepository { get; private set; }

        public TotalOrderRepository TotalOrderRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IMapper mapper, IJSRuntime jSRuntime ,FileUpload fileUpload , UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.fileUpload = fileUpload;
            this.userManager = userManager;
            ProductRepository = new ProductRepository(mapper,jSRuntime,context,fileUpload);
            ImageRepository = new ImageRepository(context, mapper, jSRuntime);
            CategoryRepository = new CategoryRepository(mapper, jSRuntime, context);
            UserRepository = new UserRepository(mapper, jSRuntime, context, fileUpload, userManager);
            OrderRepository = new OrderRepository(mapper, jSRuntime,context);
            TotalOrderRepository = new TotalOrderRepository(mapper, jSRuntime, context);
        }



        public int Complete()
        {
            try
            {
                return  context.SaveChanges();

            }
            catch (Exception e)
            {
                 jSRuntime.ToastrError(e.Message);
                return 0;
            }
        }

       
    }
}
