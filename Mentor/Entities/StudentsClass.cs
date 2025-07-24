using Mentor.Entities;
namespace Mentor.Entities
{
    public class StudentClass
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TeacherName { get; set; }
        public int Amount { get; set; }
        public string TeacherImageUrl { get; set; }
        public ICollection<CourseClass> courses { get; set; }
    }

}
