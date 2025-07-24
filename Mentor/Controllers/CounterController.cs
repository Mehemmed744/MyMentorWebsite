
using Mentor.Dtos.CounterDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Mentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly DbContextClass _dbContext;
        private readonly CounterDto _counterDto;
       
        public CounterController(DbContextClass dbContext,CounterDto counterDto)
        {
            _dbContext = dbContext;
            _counterDto = counterDto;
        }

        [HttpGet]
        public IActionResult actionResult()
        {
             string[] array = { "students", "courses", "teachers" };
            var students = _dbContext.students.Count();
            var courses = _dbContext.courses.Count();
            var teachers = _dbContext.teachers.Count();
            int[] array2 = {students, courses, teachers };
            for (int i = 0; i < 3; i++) 
            {
               _counterDto.TableName = array[i];
                _counterDto.CountofData =array2[i];
            
               return Ok(_counterDto);
            
            }
            
            return Ok();
        }
     
    }
}