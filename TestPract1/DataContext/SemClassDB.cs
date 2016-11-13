using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestPract1.Models;

namespace TestPract1.DataContext
{
    public class SemClassDB : DbContext
    {
        public SemClassDB()
            : base("DefaultConnection")
        {

        }
        public DbSet<SemClassViewModels> SemClassViewModel { get; set; } 
    }
}