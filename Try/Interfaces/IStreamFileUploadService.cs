using System;
using Microsoft.AspNetCore.WebUtilities;
namespace TRY.Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}

