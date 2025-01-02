namespace Relations.Models.OneToMany
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
    }
}
