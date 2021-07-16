using MediatR;
using Project.Domain.Commands;
using Project.Domain.Interfaces;
using Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };
            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
