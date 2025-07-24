using Microsoft.AspNetCore.Mvc;

namespace MentorUi.VieweComponent
{
    public class _HeadDefaultPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            
            
            
            return View();         
        }
    }
}
