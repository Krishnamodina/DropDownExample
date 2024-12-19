using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropDownExample.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public int SelectedDepartmentId { get; set; }
        public IEnumerable<Department> departments { get; set; }
    }
}