
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string StudentNo { get; set; }
        public int LessonsID { get; set; }
        public int DepartmentID { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }


        [ForeignKey("LessonID")]
        public Lesson Lessons { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}
