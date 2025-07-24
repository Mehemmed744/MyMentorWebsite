namespace Mentor.Entities
{
    public class CourseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string UsernamPhotoUrl { get; set; }
        public TeachersClass Teachers { get; set; }
        public ICollection<StudentClass> Students { get; set;}
    }
}
