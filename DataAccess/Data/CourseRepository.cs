using DataAccess.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.BusinessLogic.Contracts;
using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;

namespace WebAPI.DataAccess
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public Domain.Course FindById(Guid id)
        {
            var course = FindByCondition(p => p.Id == id, false).FirstOrDefault();
            return course.ToDomainModel();
        }

        public List<Domain.Course> GetAll()
        {
            var dCourses = FindAll(false).ToList();
            return dCourses.Select(x => x.ToDomainModel()).ToList();
            
        }

        public void InsertCourse(DTO.Course course)
        {
            try
            {
                Course dataAccessCourse = new Course();

                dataAccessCourse.Name = course.Name;
                dataAccessCourse.Id=Guid.NewGuid();

                Create(dataAccessCourse);
                RepositoryContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw; 
            }
        }
    }
}
