using Core.Contracts;
using System.Collections.Generic;

namespace Image.Api.Services
{
    public interface IImageService
    {
        IReadOnlyList<ImageDto> GetImages();
    }
}
