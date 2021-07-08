using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Common
{
    public class FileUpload
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly NavigationManager navigationManager;

        public FileUpload(IWebHostEnvironment webHostEnvironment, NavigationManager navigationManager)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.navigationManager = navigationManager;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{webHostEnvironment.WebRootPath}\\Images";
                var path = Path.Combine(webHostEnvironment.WebRootPath, "Images", fileName);
                //await file.RequestImageFileAsync("image/png", 1000, 1000);
                var memoryStream = new MemoryStream();
                await file.OpenReadStream(29825540).CopyToAsync(memoryStream);
                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                await using(var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }

                var fullPath = $"{navigationManager.BaseUri}Images/{fileName}";
                return fullPath;
            }
            catch(Exception e)
            {
                throw new Exception();
            }
        }


        public bool DeleteFile(string fileName)
        {
            var path = $"{webHostEnvironment.WebRootPath}\\Images\\{fileName}";
            if (File.Exists(path))
            {
                
                File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
