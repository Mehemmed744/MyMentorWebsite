using Mentor.Entities;

namespace Mentor.Dtos.AboutUsDtos
{
    public class TeachersDtoClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Speciality { get; set; }
        public string LinkedinUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string FacebookUrl { get; set; }
        public ICollection<CourseClass> Courses { get; set; }
    }
}
