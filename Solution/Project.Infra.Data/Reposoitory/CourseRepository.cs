﻿using Project.Domain.Interfaces;
using Project.Domain.Models;
using Project.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infra.Data.Reposoitory
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
