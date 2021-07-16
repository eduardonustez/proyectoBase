using Microsoft.Extensions.DependencyInjection;
using Project.Application.Interfaces;
using Project.Application.Services;
using Project.Domain.Interfaces;
using Project.Infra.Data.Reposoitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
