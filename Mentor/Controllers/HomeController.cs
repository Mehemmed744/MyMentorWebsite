using Mentor.Entities;
using Microsoft.AspNetCore.Mvc;
using Mentor.Dtos.AboutUsDtos;
using Mentor.Dtos.AboutUsDtos;
using AutoMapper;

namespace Mentor.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class HomeController : Controller
    {
       private  readonly DbContextClass _context;
       private readonly IMapper _mapper;
        public HomeController(DbContextClass aboutUsClass,IMapper mapper)
        { 
            _context = aboutUsClass;
            _mapper = mapper;
                
        }
        [HttpGet]  
        public IActionResult Index()
        {
            
            var value1 =_context.AboutUs.ToList();
           
            return Ok(_mapper.Map<List<AboutUsDto>>(value1));

        }


    }
    
}
