﻿using DAL.Commands;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAuthenticateService
    {
        public bool Login(LogInDTO data)
        {
            StudentQuery studentQuery = new StudentQuery();

            var student = studentQuery.GetStudentByLogin(data.Login);

            if(student != null)
            {
                return student.Password == data.Password;
            }

            TeacherQuery teacherQuery = new TeacherQuery();

            var teacher = teacherQuery.GetTeacherByLogin(data.Login);

            return teacher != null && teacher.Password == data.Password;
        }

        public bool Register(RegisterDTO data)
        {
            if(data.IsTeacher)
            {
                TeahcerDTO teacher = AfinaMapper.Mapper.Map<TeahcerDTO>(data);

                TeacherCommand command = new TeacherCommand();

                return command.CreateTeacher(teacher) != null;
            }
            else
            {
                StudentDTO student = AfinaMapper.Mapper.Map<StudentDTO>(data);

                StudentCommand command = new StudentCommand();

                return command.CreateStudent(student) != null;
            }
        }
    }
}
