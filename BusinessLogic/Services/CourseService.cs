
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.BusinessLogic.Contracts;

namespace WebAPI.Services
{
    public class CourseService
    {
        private readonly IRepositoryManager _repository;

        public CourseService(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }

        public List<DTO.Course> GetCourses()
        {
            var courses = _repository.Course.GetAll();

            return courses.Select(x => x.ToDTO()).ToList();

        }

        public DTO.Course GetCourseById(Guid id)
        {
            return _repository.Course.FindById(id).ToDTO();
        }

        public void InsertCourse(DTO.Course course)
        {
            _repository.Course.InsertCourse(course);
        }
    }
}
