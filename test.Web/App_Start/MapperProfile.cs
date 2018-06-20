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
            CreateMap<PupilViewModel, Pupil>();
            CreateMap<Teacher, TeacherViewModel>();
            CreateMap<SchoolClass, SchoolClassViewModel>().ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.ClassName));
            CreateMap<SchoolClassViewModel, SchoolClass>().ForMember(dest => dest.ClassName, opts => opts.MapFrom(src => src.Name));
        }
    }
}