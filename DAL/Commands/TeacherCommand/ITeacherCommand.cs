using DAL.DTO;
using DAL.Entities;

namespace DAL.Commands
{
    public interface ITeacherCommand
    {
        public Teacher CreateTeacher(TeahcerDTO teahcer);

        public Teacher ChangeTeacher(int teacherId, TeahcerDTO teahcer);

        public bool DeleteTeacher(int teacherId);
    }
}
