﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropDownExample.Models
{
    public class Department
    {
        [Key]
        public int DeptId{ get; set; }
        [Required]
        public string Name { get; set; }
    }
}