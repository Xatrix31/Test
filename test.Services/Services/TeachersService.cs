using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models.Entities;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Services.Services
{
    public class TeachersService : ITeachersService
    {
        private readonly IRepository _repository;

        public TeachersService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddTeacher(TeacherViewModel teacher)
        {
            _repository.AddNew(Mapper.Instance.Map<Teacher>(teacher));
        }

        public void AddTeacherToClass(long idTeacher)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeacher(long idTeacher)
        {
            //каскадное удаление

            _repository.Delete<Teacher>(idTeacher);
        }

        public void EditTeacher(TeacherViewModel teacher)
        {
            var src = _repository.GetById<Teacher>(teacher.Id);
            src.Name = teacher.Name;
            src.Surname = teacher.Surname;
            _repository.Save(src);
        }

        public TeacherViewModel GetTeacherById(long idTeacher)
        {
            return Mapper.Instance.Map<TeacherViewModel>(_repository.GetById<Teacher>(idTeacher));
        }

        public IEnumerable<TeacherViewModel> GetTeachersByIdClass(long idClass)
        {
            throw new NotImplementedException();
        }
    }
}