using AutoMapper;
using Mentor.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mentor.Dtos.AboutUsDtos;
using Mentor.Entities;
using Mentor.Dtos.StudentDtos;


namespace Mentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    { private readonly DbContextClass _dbContext;
        private readonly IMapper _mapper;
        public StudentsController(DbContextClass dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;

        }
        [HttpGet]
        public IActionResult GetStudent()
        {
            var students = _dbContext.students.ToList();
            

            return Ok(_mapper.Map<List<StudentDtocsGet>>(students));
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int Id)
        {

            var value = _dbContext.students.Find(Id);
            _dbContext.students.Remove(value);
            _dbContext.SaveChanges();
            return Ok("Student are deleted");
        }
        [HttpPut]
        public IActionResult Modify(StudentPutDtos studentDtocs)
        {  
            var value = _mapper.Map<StudentClass>(studentDtocs);
            _dbContext.Update(value);
            _dbContext.SaveChanges();

            return Ok();
        }


    }
}
