using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService _courseService;

        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }

        
        [HttpGet]
        public List<DTO.Course> Get()
        {
            return _courseService.GetCourses();
        }

        [HttpGet("{id}")]
        public DTO.Course GetById(Guid id)
        {
            
            return _courseService.GetCourseById(id);
        }

        [HttpPost]
        public void Post(DTO.Course course)
        {
            _courseService.InsertCourse(course);
        }
      
        
    }
}
