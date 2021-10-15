using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IStudentQuery
    {
        //public IQueryable<Student> GetStudentes();

        //public Student GetStudentById(int id);
        public Student GetStudentByLogin(string Login);

      //  public Student GetStudentByPassword(string Password);

    }
}
