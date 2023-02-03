using Microsoft.AspNetCore.Mvc;

namespace Blog.Static
{
    public interface IFileUpload
    {
        string Upload(IFormFile file, string basePath, string baseFileName);
        void Unlink(string basePath, string fileName);
    }
}
