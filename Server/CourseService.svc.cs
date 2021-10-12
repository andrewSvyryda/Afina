using DAL.Queries;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    public class CourseService : ICourseService
    {
        public List<CourseDTO> GetCourses()
        {
            CourseQuery courseQuery = new CourseQuery();

            return AfinaMapper.Mapper.Map<List<CourseDTO>>(courseQuery.GetCourses().ToList());
        }
    }
}
