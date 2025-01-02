using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Relations.Models.OneToOnes
{
    public class TeacherProfile
    {
        [Key]
        [ForeignKey("Teacher")]
        public int TeacherProfileId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Teacher Teacher { get; set; }
    }
}