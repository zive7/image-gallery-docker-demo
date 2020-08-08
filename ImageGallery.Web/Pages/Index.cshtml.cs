using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;
using ImageGallery.Web.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ImageGallery.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAppSettings _appSettings;

        public IndexModel(ILogger<IndexModel> logger, IAppSettings appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        public async Task OnGet()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(new Uri($"{_appSettings.ImageApiUrl}/api/images"));

            string responseBody = await response.Content.ReadAsStringAsync();

            var images = JsonConvert.DeserializeObject<List<ImageDto>>(responseBody);

            StringBuilder sb = new StringBuilder();

            foreach (var image in images)
            {
                sb.AppendLine($"{image.Uid} - {image.Name}");
            }

            ViewData["Images"] = sb.ToString();
        }
    }
}
