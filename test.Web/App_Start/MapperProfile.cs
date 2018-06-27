using AutoMapper;
using test.Models.Entities;
using test.Models.ViewModels;

namespace test.Web
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Pupil, PupilViewModel>().ForMember(dest => dest.SchoolClassName, opts => opts.MapFrom(src => src.Class.ClassName));
            CreateMap<PupilViewModel, Pupil>();
            CreateMap<Teacher, TeacherViewModel>().ForMember(dest => dest.FullName, opts => opts.MapFrom(src => string.Concat(src.Name, ' ', src.Surname))).ForMember(dest => dest.TeacherType, opts => opts.MapFrom(src => src.TeacherType.Title));
            CreateMap<TeacherViewModel, Teacher>();
            CreateMap<SchoolClass, SchoolClassViewModel>().ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.ClassName)).ForMember(dest => dest.MonitorName, opts => opts.MapFrom(src => string.Concat(src.Monitor.Name, ' ', src.Monitor.Surname)));
            CreateMap<SchoolClassViewModel, SchoolClass>().ForMember(dest => dest.ClassName, opts => opts.MapFrom(src => src.Name));
            CreateMap<TeacherType, TeacherTypeViewModel>();
        }
    }
}