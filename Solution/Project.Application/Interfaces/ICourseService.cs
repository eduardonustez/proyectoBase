using Project.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
