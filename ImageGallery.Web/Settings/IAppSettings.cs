using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Web.Settings
{
    public interface IAppSettings
    {
        string ImageApiUrl { get; }
    }
}
