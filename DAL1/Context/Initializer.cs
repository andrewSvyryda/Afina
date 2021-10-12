﻿using DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Context
{
    public class Initializer : CreateDatabaseIfNotExists<AfinaDbContext>
    {
        public override void InitializeDatabase(AfinaDbContext context)
        {
            base.InitializeDatabase(context);

            var course1 = context.Courses.Add(new Course { Title = "Course 1", Description = "Course description 1" });
            var course2 = context.Courses.Add(new Course { Title = "Course 2", Description = "Course description 2" });
            var course3 = context.Courses.Add(new Course { Title = "Course 3", Description = "Course description 3" });
            var course4 = context.Courses.Add(new Course { Title = "Course 4", Description = "Course description 4" });
            var course5 = context.Courses.Add(new Course { Title = "Course 5", Description = "Course description 5" });

            context.SaveChanges();

            var teacher1 = context.Teachers.Add(new Teacher { Name = "Sergii", Login = "Sergii2002", Password = "Sergii2002", Surname = "Sergii", Courses = new List<Course> { course1, course2 } });
            var teacher2 = context.Teachers.Add(new Teacher { Name = "Vlad", Login = "Vlad2002", Password = "Vlad2002", Surname = "Vlad", Courses = new List<Course> { course3, course4, course5 } });

            context.SaveChanges();

            var student1 = context.Students.Add(new Student { Name = "Vlad", Login = "Vlad2008", Password = "Vlad2008", Surname = "Vlad", Courses = new List<Course> { course1, course2, course3 } });
            var student2 = context.Students.Add(new Student { Name = "Andrii", Login = "Andrii2008", Password = "Andrii2008", Surname = "Andrii", Courses = new List<Course> { course3, course2, course4 } });
            var student3 = context.Students.Add(new Student { Name = "Bogdan", Login = "Bogdan2008", Password = "Bogdan2008", Surname = "Bogdan", Courses = new List<Course> { course3, course5, course4 } });

            context.SaveChanges();
        }
    }
}