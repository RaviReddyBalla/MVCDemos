using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        
        public int employeeid { get; set; }
        public string Name { get; set; }
        public int Salaray { get; set; }

    }
    
}