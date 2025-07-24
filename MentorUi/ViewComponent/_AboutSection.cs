using MentorUi.DtosofUi.AboutCourse;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace MentorUi.ViewComponent4
{
    public class _AboutSection:ViewComponent
    {  private readonly IHttpClientFactory _httpClientFactory;
        public _AboutSection(IHttpClientFactory httpClientFactory)
        {
           _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {  
            var client =_httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:7101/api/AboutUs");

            if (responsemessage.IsSuccessStatusCode) 
            { 
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutCourseDto>>(jsondata);
                return View(values);
            
            }
            return View();
        }
    }
}
