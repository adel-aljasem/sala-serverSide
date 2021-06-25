using AutoMapper;
using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.Interface;
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
    public class ImageRepository
    {
        private readonly IMapper mapper;
        public ApplicationDbContext Db { get; set; }
        private readonly IJSRuntime jSRuntime;

        public ImageRepository(ApplicationDbContext Db, IMapper mapper, IJSRuntime jSRuntime)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;

        }

        public async Task AddRange(int id, List<ImageModel> entities)
        {
            try
            {
                var imageModel = entities.FirstOrDefault(a => a.ProductId == id);
                var li = Db.Images.Where(w => w.ProductId == imageModel.ProductId);
                await Db.Images.AddRangeAsync(mapper.Map(entities, li.ToList()));
            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
            }
        }

        public async Task Remove(int id)
        {
            try
            {
                var ImageToDelete = await Db.Images.FindAsync(id);
                Db.Remove(ImageToDelete);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
            }
        }

    }
}
