using DAL.Commands;
using DAL.Queries;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    public class CourseService : ICourseService
    {
        public void ChangeCourse(int courseId, CourseDTO course)
        {
            CourseCommand courseCommand = new CourseCommand();

            courseCommand.ChangeCourse(courseId, course);
        }

        public void CreateCourse(CourseDTO course)
        {
            CourseCommand courseCommand = new CourseCommand();

            courseCommand.CreateCourse(course);
        }

        public bool DeleteCourse(int courseId)
        {
            CourseCommand courseCommand = new CourseCommand();

            return courseCommand.DeleteCourse(courseId);
        }

        public List<CourseDTO> GetCourses()
        {
            CourseQuery courseQuery = new CourseQuery();

            return AfinaMapper.Mapper.Map<List<CourseDTO>>(courseQuery.GetCourses().ToList());
        }
    }
}
