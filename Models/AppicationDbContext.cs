using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownExample.Models
{
    public class AppicationDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public AppicationDbContext():base("name=constr")
        {

        }
    }
}