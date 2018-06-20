using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using test.Models.Entities;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Services.Services
{
    public class ClassesService : IClassesService
    {
        private readonly IRepository _repository;

        public ClassesService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddClass(SchoolClassViewModel viewModel)
        {
            _repository.AddNew(Mapper.Instance.Map<SchoolClass>(viewModel));
        }

        public void DeleteClass(long idClass)
        {
            //каскадное удаление учеников


            _repository.Delete<SchoolClass>(idClass);
        }

        public void EditClass(SchoolClassViewModel viewModel)
        {
            var src = _repository.GetById<SchoolClass>(viewModel.Id);
            src.ClassName = viewModel.Name;
            _repository.Save(src);
        }

        public SchoolClassViewModel GetClassById(long idClass)
        {
            return Mapper.Instance.Map<SchoolClassViewModel>(_repository.GetById<SchoolClass>(idClass));
        }

        public IEnumerable<SchoolClassViewModel> GetClasses()
        {
            return _repository.GetAll<SchoolClass>().AsEnumerable().Select(Mapper.Instance.Map<SchoolClassViewModel>);
        }
    }
}