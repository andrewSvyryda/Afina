using DAL.DTO;
using DAL.Entities;

namespace DAL.Commands
{
    public interface IStudentCommand
    {
        public Student CreateStudent(StudentDTO student);

        public Student ChangeStudent(int courseId, StudentDTO course);

        public bool DeleteStudent(int courseId);
    }
}
