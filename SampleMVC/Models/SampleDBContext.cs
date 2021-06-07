using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SampleMVC.Models
{ 
    public class SampleDBContext : DbContext
    {
        public SampleDBContext() : base("Mycon") 
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
    }
}