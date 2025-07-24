using Mentor.Entities;

namespace Mentor.Dtos.StudentDtos
{
    public class StudentPutDtos
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TeacherName { get; set; }
        public int Amount { get; set; }
        public string TeacherImageUrl { get; set; }
       
    }
}
