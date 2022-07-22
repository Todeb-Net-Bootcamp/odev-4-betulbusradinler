using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class Department
    {

        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string FacultyName { get; set; }
        public string HeadOfDepartment { get; set; }
    }
}
