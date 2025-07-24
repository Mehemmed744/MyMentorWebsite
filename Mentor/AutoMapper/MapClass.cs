using AutoMapper;
using Mentor.Dtos.AboutCoursetos;
using Mentor.Dtos.AboutUsDtos;
using Mentor.Dtos.StudentDtos;
using Mentor.Entities;

namespace Mentor.AutoMapper
{
    public class MapClass:Profile
    {
        public MapClass()
        {
            CreateMap<TeachersClass,TeachersDtoClass>().ReverseMap();
            CreateMap<StudentClass,StudentDtocsGet>().ReverseMap();
            CreateMap<StudentClass,StudentPutDtos>().ReverseMap();
            CreateMap<AboutUsClass, AboutUsDto>().ReverseMap();
            CreateMap<AboutCourseClass,AboutCourseDto>().ReverseMap();
        }
    }
}
