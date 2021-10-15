using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Context
{
    public class Initializer
    {
        public void Seed(AfinaDbContext context)
        {
            var course1 = context.Courses.Add(new Course { Title = "Course 1", Description = "Course description 1" }).Entity;
            var course2 = context.Courses.Add(new Course { Title = "Course 2", Description = "Course description 2" }).Entity;
            var course3 = context.Courses.Add(new Course { Title = "Course 3", Description = "Course description 3" }).Entity;
            var course4 = context.Courses.Add(new Course { Title = "Course 4", Description = "Course description 4" }).Entity;
            var course5 = context.Courses.Add(new Course { Title = "Course 5", Description = "Course description 5" }).Entity;

            context.SaveChanges();

            var teacher1 = context.Teachers.Add(new Teacher { Name = "Sergii", Login="Sergii2002", Password="Sergii2002", Surname="Sergii", Courses = new List<Course> { course1, course2 } }).Entity;
            var teacher2 = context.Teachers.Add(new Teacher { Name = "Vlad", Login= "Vlad2002", Password= "Vlad2002", Surname= "Vlad", Courses = new List<Course> { course3, course4, course5 } }).Entity;

            context.SaveChanges();

            var student1 = context.Students.Add(new Student { Name = "Vlad", Login = "Vlad2008", Password = "Vlad2008", Surname = "Vlad", Courses = new List<Course> { course1, course2, course3 } }).Entity;
            var student2 = context.Students.Add(new Student { Name = "Andrii", Login = "Andrii2008", Password = "Andrii2008", Surname = "Andrii", Courses = new List<Course> { course3, course2, course4 } }).Entity;
            var student3 = context.Students.Add(new Student { Name = "Bogdan", Login = "Bogdan2008", Password = "Bogdan2008", Surname = "Bogdan", Courses = new List<Course> { course3, course5, course4 } }).Entity;
            
            context.SaveChanges();
        }
    }
}
