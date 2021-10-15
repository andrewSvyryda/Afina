﻿using DAL.Commands;
using DAL.Queries;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseService.svc or CourseService.svc.cs at the Solution Explorer and start debugging.
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

        public List<CourseDTO> GetCoursesByTeacherId(int id)
        {
            CourseQuery courseQuery = new CourseQuery();

            var courses = courseQuery.GetCourses();

            return AfinaMapper.Mapper.Map<List<CourseDTO>>(courses.Where(c => c.TeacherId == id));
        }

        public bool Subscribe(int userId, int courseId)
        {
            CourseQuery courseQuery = new CourseQuery();

            var course = courseQuery.GetCourseById(courseId);

            StudentQuery studentQuery = new StudentQuery();

            var student = studentQuery.GetStudent(userId);

            course.Students.Add(student);

            return true;
        }
    }
}
