using DAL.Context;
using DTO;
using DAL.Entities;
using System.Linq;

namespace DAL.Commands
{
    public class StudentCommand : IStudentCommand
    {
        public Student CreateStudent(StudentDTO student)
        {
            var createdStudent = AfinaContext.Context.Students.Add(
                new Student
                {
                    Login = student.Login,
                    Name = student.Name,
                    Password = student.Password,
                    Surname = student.Surname
                });

            AfinaContext.Context.SaveChanges();

            return createdStudent;
        }

        public Student ChangeStudent(int studentId, StudentDTO student)
        {
            var changedStudent = AfinaContext.Context.Students.SingleOrDefault(s => s.Id == studentId);

            changedStudent.Login = student.Login;
            changedStudent.Surname = student.Surname;
            changedStudent.Name = student.Name;
            changedStudent.Password = student.Password;

            AfinaContext.Context.SaveChanges();

            return changedStudent;
        }

        public bool DeleteStudent(int studentId)
        {
            var studentToDelete = AfinaContext.Context.Students.SingleOrDefault(s => s.Id == studentId);

            if (studentToDelete == null)
            {
                return false;
            }

            AfinaContext.Context.Students.Remove(studentToDelete);

            return true;
        }
    }
}
