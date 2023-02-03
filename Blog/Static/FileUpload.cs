using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Blog.Static
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _hostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file, string basePath, string baseFileName)
        {
            var uploads = Path.Combine(_hostEnvironment.ContentRootPath, basePath);

            if (!Directory.Exists(uploads))
            {
                Directory.CreateDirectory(uploads);
            }

            string fileName = baseFileName + Path.GetExtension(file.FileName);
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return fileName;
        }

        public void Unlink(string basePath, string fileName)
        {
            var oldImagePath = Path.Combine(basePath, fileName);
            if (File.Exists(oldImagePath))
            {
                File.Delete(oldImagePath);
            }
        }
    }
}
