using Microsoft.EntityFrameworkCore;
using Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infra.Data.Context
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}
