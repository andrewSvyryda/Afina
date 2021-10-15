using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using DTO;

namespace Server
{
    [ServiceContract]
    public interface ICourseService1
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