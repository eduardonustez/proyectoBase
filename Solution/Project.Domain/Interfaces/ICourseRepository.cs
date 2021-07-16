using Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
