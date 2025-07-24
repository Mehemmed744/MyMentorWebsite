using AutoMapper;
using Mentor.Dtos.AboutCoursetos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly DbContextClass _context;
        private readonly IMapper _mapper;
        public AboutUsController(DbContextClass dbContext,IMapper mapper)
        { 
            _context = dbContext;
            _mapper = mapper;
            
        }
        [HttpGet]
        public IActionResult Index() 
        {
            var listofAbout=_context.aboutCourse.ToList();


            return Ok(_mapper.Map<List<AboutCourseDto>>(listofAbout));
        }

    }
}
