namespace OOP.Classes
{
    public class Group
    {
        public string GroupName { get; set; }
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            student.Group = this; 
        }

        public void ListStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Group: {student.Group.GroupName}");
            }
        }

        public void AddMultipleStudents(List<Student> studentsList)
        {
            for (int i = 0; i < studentsList.Count; i++)
            {
                AddStudent(studentsList[i]); 
            }
        }
    }
}
