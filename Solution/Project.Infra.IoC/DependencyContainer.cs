using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Interfaces;
using Project.Application.Services;
using Project.Domain.CommandHandlers;
using Project.Domain.Commands;
using Project.Domain.Core.Bus;
using Project.Domain.Interfaces;
using Project.Infra.Bus;
using Project.Infra.Data.Context;
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
            //Domain IMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();

        }
    }
}
