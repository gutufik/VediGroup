namespace VediGroup.Services
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file);
    }
}
