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
    public class CategoryRepository
    {
        public ApplicationDbContext Db { get; set; }
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;

        public CategoryRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;
        }

        public async Task<List<CategoryModel>> GetAll()
        {
            try
            {
                return mapper.Map<List<Category>, List<CategoryModel>>( Db.Category.ToList());

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
                return null;
            }
        }


        public async Task Add(CategoryModel categoryModel)
        {
            try
            {
                var category = mapper.Map<CategoryModel, Category>(categoryModel);
                await Db.Category.AddAsync(category);
            }
            catch (Exception e)
            { 
                await jSRuntime.ToastrError(e.Message);
            }
        }

    }
}
