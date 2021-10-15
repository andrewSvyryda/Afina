﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseService" in both code and config file together.
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        List<CourseDTO> GetCourses();

        [OperationContract]
        void CreateCourse(CourseDTO course);

        [OperationContract]
        bool DeleteCourse(int courseId);

        [OperationContract]
        void ChangeCourse(int courseId, CourseDTO course);

        [OperationContract]
        List<CourseDTO> GetCoursesByTeacherId(int id);

        [OperationContract]
        bool Subscribe(int userId, int courseId);
    }
}
