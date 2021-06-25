using AutoMapper;
using Common;
using DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository
    {

        private ApplicationDbContext Db { get; set; }
        private readonly UserManager<ApplicationUser> UserManager;
        private readonly IMapper mapper;
        private readonly IJSRuntime jSRuntime;
        private readonly FileUpload fileUpload;
        public UserRepository(IMapper mapper, IJSRuntime jSRuntime, ApplicationDbContext Db, FileUpload fileUpload, UserManager<ApplicationUser> UserManager)
        {
            this.mapper = mapper;
            this.jSRuntime = jSRuntime;
            this.Db = Db;
            this.fileUpload = fileUpload;
            this.UserManager = UserManager;
        }



        public async Task<List<ApplicationUser>> GetAll()
        {
            try
            {
                var customers = await UserManager.GetUsersInRoleAsync(SD.Role_Customer);
                return customers.ToList();

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        public async Task<ApplicationUser> GetUser(string id)
        {
            try
            {
                return  await UserManager.FindByIdAsync(id);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
                return null;
            }
        }

        //public async Task Add(ApplicationUser applicationUser)
        //{
        //    try
        //    {
        //        await UserManager.CreateAsync();

        //    }
        //    catch (Exception e)
        //    {
        //        await jSRuntime.ToastrError(e.Message);
        //    }
        //}

        public async Task Update(string id)
        {
            try
            {
                var user = await UserManager.FindByIdAsync(id);
                await UserManager.UpdateAsync(user);

            }
            catch (Exception e)
            {
                await jSRuntime.ToastrError(e.Message);
            }
        }
    }
}
