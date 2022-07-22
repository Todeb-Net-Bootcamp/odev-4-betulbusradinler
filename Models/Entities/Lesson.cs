
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonsID { get; set; }
        public string LessonsName { get; set; }
        public string LessonsCode { get; set; }
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}
