using System;
using Microsoft.AspNetCore.WebUtilities;
namespace TRY.Interfaces
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file);
    }
}

