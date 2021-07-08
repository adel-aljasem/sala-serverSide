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
        private ApplicationDbContext Db { get; set; }
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        private readonly FileUpload fileUpload;
        public ProductRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db, FileUpload fileUpload)
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
                var Products = Db.Product.Include(w => w.Images).Include(a => a.ProductDetails).Include(z => z.Category).ToList();
                return mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(Products);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        public ProductModel GetById(int id)
        {
            try
            {
                var productFromDb = Db.Product.Include(w => w.ProductDetails).Include(z => z.Images).Include(a => a.Category).FirstOrDefault(a => a.ID == id);
                var product = mapper.Map<Product, ProductModel>(productFromDb);
                return product;

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
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

        public void Remove(int id, ProductModel entity)
        {
            try
            {
                var foundProduct =  Db.Product.Find(entity.ID);
                if (foundProduct != null)
                {
                    var allImages =  Db.Images.Where(w => w.ProductId == id).ToList();
                    Db.Images.RemoveRange(allImages);
                    Db.Product.Remove(foundProduct);


                }
            }
            catch (Exception e)
            {
                 jSRuntime.ToastrError(e.Message);

            }

        }


        public void AddComment(CommentModel commentModel)
        {
            try
            {
                var comment = mapper.Map<CommentModel, Comment>(commentModel);
                Db.Comment.Add(comment);
            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
            }
        }

        public void DeleteComment(int id)
        {
            try
            {
                var commentInDb = Db.Comment.Find(id);
                Db.Comment.Remove(commentInDb);

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
            }
        }

        public void DeleteAllCommentForUser(string userId)
        {
            try
            {
                var allTheComment = Db.Comment.Where(w => w.IdUser == userId).ToList();
                Db.RemoveRange(allTheComment);

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);

            }
        }

        public List<CommentModel> GetAllComments()
        {
            try
            {
                var allComments = Db.Comment.Include(w=>w.User).Include(w=>w.Product).ToList();
                return mapper.Map<List<Comment>, List<CommentModel>>(allComments);

            }
            catch (Exception e)
            {
                jSRuntime.ToastrError(e.Message);
                return null;
            }
        }





    }
}
