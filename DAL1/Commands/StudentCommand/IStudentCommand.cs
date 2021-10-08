using DTO;
using DAL.Entities;

namespace DAL.Commands
{
    public interface IStudentCommand
    {
        Student CreateStudent(StudentDTO student);

        Student ChangeStudent(int courseId, StudentDTO course);

        bool DeleteStudent(int courseId);
    }
}
