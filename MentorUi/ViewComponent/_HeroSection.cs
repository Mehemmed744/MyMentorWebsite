using System.Diagnostics;
using System.Drawing.Text;
using MentorUi.DtosofUi.HomeDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MentorUi.ViewComponent3
{
  
    public class _HeroSection:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _HeroSection(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7101/api/Controller");
            if (responseMessage.IsSuccessStatusCode) 
            {
            
                 var jsondata = await responseMessage.Content.ReadAsStringAsync();
               
                var values = JsonConvert.DeserializeObject<List<HomeDtos>>(jsondata);
                return View(values);
            
            }
            return View();
        }
    }
}
