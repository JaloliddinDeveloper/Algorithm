using Microsoft.EntityFrameworkCore;
using Relations.Models;

using (var db = new AppDbContext())
{
    Teacher teacher1 = new Teacher { Name = "Jaloliddin" };
    Teacher teacher2 = new Teacher { Name = "Oydin" };
    TeacherProfile profile1 = new TeacherProfile { Address = "Toshkent", PhoneNumber ="907777777" };
    TeacherProfile profile2 = new TeacherProfile { Address = "Termiz", PhoneNumber = "901111111" };
    teacher1.Profile = profile1;
    teacher2.Profile = profile2;
    db.Teachers.Add(teacher1);
    db.Teachers.Add(teacher2);
    db.SaveChanges();


    Console.WriteLine("Teacher data");

    var teacherData = db.Teachers.Include(t => t.Profile).ToList();
    foreach (var t in teacherData)
    {
        Console.WriteLine($"Teacher: {t.Name}, Profile: {t.Profile.Address}, {t.Profile.PhoneNumber}");
    }   
}   