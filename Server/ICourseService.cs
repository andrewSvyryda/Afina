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
        List<CourseDTO> GetCourses()

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

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