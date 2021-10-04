using DAL.DTO;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Commands.CourseCommand
{
    public class CourseCommand
    {
        public AfinaDbContext context;

        public CourseCommand()
        {
            context = new AfinaDbContext();
        }

        public Course CreateCourse(CourseDTO course)
        {
            if(context.Courses.Any(c => c.Title == course.Title))
            {
                return null;
            }

            var createdCourse = context.Courses.Add(new Course { Title = course.Title, Description = course.Description }).Entity;

            context.SaveChanges();

            return createdCourse;
        }

        public Course ChangeCourse(int courseId, CourseDTO course)
        {
            Course modifiedCourse = context.Courses.SingleOrDefault(c => c.Id == courseId);

            if(modifiedCourse == null)
            {
                return null;
            }

            modifiedCourse.Title = course.Title;
            modifiedCourse.Description = course.Description;

            context.SaveChanges();

            return modifiedCourse;
        }

        public bool DeleteCourse(int courseId)
        {
            Course courseToDelete = context.Courses.SingleOrDefault(c => c.Id == courseId);

            if (courseToDelete == null)
            {
                return false;
            }

            context.Courses.Remove(courseToDelete);

            return true;
        }
    }
}
