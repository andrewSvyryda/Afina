using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using DTO;

namespace Server
{
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
    }


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}