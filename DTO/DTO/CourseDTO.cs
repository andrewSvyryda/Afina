using System.Runtime.Serialization;

namespace DTO
{

    [DataContract]
    public class CourseDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
