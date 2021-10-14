using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentQueri : IStudentQuery
    {
        Student IStudentQuery.GetStudentByLogin(string Login)
        {
            return AfinaContext.Context.Students.SingleOrDefault(c => c.Login == Login);
        }

    }
}
