using AutoMapper;
using test.Models.Entities;
using test.Models.ViewModels;

namespace test.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Pupil, PupilViewModel>();
            CreateMap<Teacher, TeacherViewModel>();
        }
    }
}