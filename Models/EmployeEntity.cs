using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeEntity:DbContext
    {
        public DbSet<Employe> employees { get; set; }
    }
}