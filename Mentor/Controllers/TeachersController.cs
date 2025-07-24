using System.Xml;
using AutoMapper;
using Mentor.Dtos.AboutUsDtos;
using Mentor.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {   private readonly IMapper mapper;
        private readonly DbContextClass _Dbcontext;
        public TeachersController(DbContextClass dbContext,IMapper mapper)
        {
            _Dbcontext = dbContext;
            mapper = this.mapper;

        }
        [HttpGet]
        public IActionResult GetTeachers()
        {
            var Teachers = _Dbcontext.teachers.ToList();
            _Dbcontext.SaveChanges();



            return Ok(Teachers);

        }
        [HttpPost]
        public  IActionResult AddTeacher(TeachersDtoClass Dto)
        {
            var Teachers = mapper.Map<TeachersClass>(Dto);
            
            _Dbcontext.teachers.Add(Teachers);
            _Dbcontext.SaveChanges();

            


            return Ok("Adding is succesful");
        }
        [HttpDelete]
        public IActionResult DeleteTeacher(int Id) 
        {

            var value =_Dbcontext.teachers.Find(Id);
            _Dbcontext.teachers.Remove(value);
            _Dbcontext.SaveChanges(); 
            return Ok("Teacher are deleted");
        }
    }

}
