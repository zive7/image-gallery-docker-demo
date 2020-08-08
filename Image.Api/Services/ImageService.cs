using Core.Contracts;
using System;
using System.Collections.Generic;

namespace Image.Api.Services
{
    public class ImageService : IImageService
    {
        public IReadOnlyList<ImageDto> GetImages()
        {
            return new List<ImageDto>()
            {
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 1" },
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 2" },
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 3" },
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 4" },
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 5" },
                new ImageDto {Uid=Guid.NewGuid(), Name = "Image 6" }
            };
        }
    }
}
