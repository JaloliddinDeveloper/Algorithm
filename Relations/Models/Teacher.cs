namespace Relations.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TeacherProfile Profile { get; set; }
    }
}
