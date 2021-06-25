using AutoMapper;
using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository
    {
        public ApplicationDbContext Db { get; set; }
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        private readonly FileUpload fileUpload;
        public ProductRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db,FileUpload fileUpload)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;
            this.fileUpload = fileUpload;
        }


        public async Task<IEnumerable<ProductModel>> GetALL()
        {
            try
            {
                var Products = await Db.Product.Include(w => w.Images).Include(a => a.ProductDetails).ToListAsync();
                return mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(Products);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
                return null;
            }
        }


        public async Task AddRange(int id, IEnumerable<ProductModel> entities)
        {
            try
            {
                var theObject = mapper.Map<IEnumerable<ProductModel>, IEnumerable<Product>>(entities);

                await Db.Product.AddRangeAsync(theObject);
                
            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
            }

        }

        public async Task Add(ProductModel entity)
        {
            try
            {
                var theObject = mapper.Map<ProductModel, Product>(entity);
                await Db.Product.AddAsync(theObject);
                
            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);

            }

        }

        public async Task Update(int id, ProductModel productModel)
        {
            try
            {
                var productToUpdate = await Db.Product.FindAsync(id);
                var UpdatedProduct = mapper.Map(productModel, productToUpdate);
                Db.Product.Update(UpdatedProduct);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
            }
        }

        public async Task Remove(int id, ProductModel entity)
        {
            try
            {
                var foundProduct = await Db.Product.FindAsync(entity.ID);
                if (foundProduct != null)
                {
                    var allImages = await Db.Images.Where(w => w.ProductId == id).ToListAsync();
                    Db.Images.RemoveRange(allImages);
                    Db.Product.Remove(foundProduct);
                    
                    await Db.SaveChangesAsync();

                }
            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);

            }

        }








    }
}
