using DAL.Context;
using DAL.DTO;
using DAL.Entities;
using System.Linq;

namespace DAL.Commands
{
    public class TeacherCommand : ITeacherCommand
    {
        public Teacher CreateTeacher(TeahcerDTO teahcer)
        {
            var createdStudent = AfinaContext.Context.Teachers.Add(
                new Teacher
                {
                    Login = teahcer.Login,
                    Name = teahcer.Name,
                    Password = teahcer.Password,
                    Surname = teahcer.Surname
                }).Entity;

            AfinaContext.Context.SaveChanges();

            return createdStudent;
        }

        public Teacher ChangeTeacher(int teacherId, TeahcerDTO teahcer)
        {
            var changedTeacher = AfinaContext.Context.Teachers.SingleOrDefault(s => s.Id == teacherId);

            changedTeacher.Login = teahcer.Login;
            changedTeacher.Surname = teahcer.Surname;
            changedTeacher.Name = teahcer.Name;
            changedTeacher.Password = teahcer.Password;

            AfinaContext.Context.SaveChanges();

            return changedTeacher;
        }

        public bool DeleteTeacher(int teacherId)
        {
            var teacherToDelete = AfinaContext.Context.Teachers.SingleOrDefault(s => s.Id == teacherId);

            if (teacherToDelete == null)
            {
                return false;
            }

            AfinaContext.Context.Teachers.Remove(teacherToDelete);

            return true;
        }
    }
}
