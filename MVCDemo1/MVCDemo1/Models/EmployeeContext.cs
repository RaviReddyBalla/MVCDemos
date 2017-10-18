using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base( "name=dbString")
        {
            
        }
    
        public DbSet<Employee> Employees { get; set; }

        
    }
}