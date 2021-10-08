using DTO;
using DAL.Entities;

namespace DAL.Commands
{
    public interface ITeacherCommand
    {
        Teacher CreateTeacher(TeahcerDTO teahcer);

        Teacher ChangeTeacher(int teacherId, TeahcerDTO teahcer);

        bool DeleteTeacher(int teacherId);
    }
}
