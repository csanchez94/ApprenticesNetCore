using BusinessLogic.Domain;
using System;
using System.Collections.Generic;

namespace WebAPI.BusinessLogic.Contracts
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();

        public void InsertCourse(DTO.Course course);

        public Course FindById(Guid id);
        

    }
}
