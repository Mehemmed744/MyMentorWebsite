
using Microsoft.AspNetCore.Mvc;

namespace MentorUi.VieweComponent
{
    public class _NavigationBarDefault:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {

          return View();
        }

    }
}
