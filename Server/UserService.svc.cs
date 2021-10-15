using DAL.Queries;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public StudentDTO GetStudentByLogin(string login)
        {
            var studentQuery = new StudentQuery();

            return AfinaMapper.Mapper.Map<StudentDTO>(studentQuery.GetStudentByLogin(login));
        }

        public TeahcerDTO GetTeacherByLogin(string login)
        {
            var teacherQuery = new TeacherQuery();

            return AfinaMapper.Mapper.Map<TeahcerDTO>(teacherQuery.GetTeacherByLogin(login));
        }
    }
}
