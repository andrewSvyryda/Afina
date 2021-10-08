using System.Collections.Generic;

namespace DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public ICollection<CourseDTO> Courses { get; set; }
    }
}
