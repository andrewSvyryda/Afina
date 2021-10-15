using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class TeahcerDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public ICollection<CourseDTO> Courses { get; set; }
    }
}
