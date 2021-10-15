using AutoMapper;
using DTO;
using DAL.Entities;

namespace Server
{
    public static class AfinaMapper
    {
        public static Mapper Mapper = new Mapper(
            new MapperConfiguration(
                cfg => { 
                    cfg.CreateMap<Student, StudentDTO>(); 
                    cfg.CreateMap<StudentDTO, Student>();
                    cfg.CreateMap<TeahcerDTO, Teacher>();
                    cfg.CreateMap<Teacher, TeahcerDTO>();
                    cfg.CreateMap<Course, CourseDTO>();
                    cfg.CreateMap<TeahcerDTO, RegisterDTO>();
                    cfg.CreateMap<RegisterDTO, TeahcerDTO>();
                    cfg.CreateMap<RegisterDTO, StudentDTO>();
                    cfg.CreateMap<StudentDTO, RegisterDTO>();
                }
            )
        );
    }
}
