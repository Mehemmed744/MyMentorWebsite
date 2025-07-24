using System.Diagnostics.Metrics;
using MentorUi.DtosofUi.CounterDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MentorUi.ViewComponent12
{
    public class _CountSection:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CountSection(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            
        }
        public async Task <IViewComponentResult> InvokeAsync() 
        {  var client =_httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7101/api/Counter");
            if (responsemessage.IsSuccessStatusCode)
            {

                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<CounterDto>(jsondata);
                return View(values);

            }

            return View();  
        }

    }
}
