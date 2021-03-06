﻿using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
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
            var dest = new Teacher
            {
                Name = teacher.Name,
                Surname = teacher.Surname,
                IdType = _repository.GetAll<TeacherType>().FirstOrDefault(x => x.Title.Equals(teacher.TeacherType)).Id
            };
            _repository.AddNew(dest);
        }

        public void AddTeacherToClass(long idCLass, long idTeacher)
        {
            var myclass = _repository.GetById<SchoolClass>(idCLass);
            _repository.GetById<Teacher>(idTeacher).Classes.Add(myclass);
            _repository.Save();
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

        public IEnumerable<TeacherViewModel> GetAllTeachers()
        {
            return _repository.GetAll<Teacher>().AsEnumerable().Select(Mapper.Instance.Map<TeacherViewModel>);
        }

        public void DeleteTeacherFromClass(long idClass, long idTeacher)
        {
            var temp = _repository.GetById<SchoolClass>(idClass);
            _repository.GetById<Teacher>(idTeacher).Classes.Remove(temp);
            _repository.Save();
        }

        public TeacherViewModel GetTeacherById(long idTeacher)
        {
            return Mapper.Instance.Map<TeacherViewModel>(_repository.GetById<Teacher>(idTeacher));
        }

        public IEnumerable<TeacherViewModel> GetTeachersByIdClass(long idClass)
        {
            return _repository.GetById<SchoolClass>(idClass).Teachers.Select(y =>
            {
                var map = Mapper.Instance.Map<TeacherViewModel>(y);
                map.IdClass = idClass;
                return map;
            });
        }

        public IEnumerable<TeacherViewModel> GetTeachersNotInClass(long idClass)
        {
            return _repository.GetAll<Teacher>().Where(x => x.Classes.All(y => y.Id != idClass)).AsEnumerable().Select(Mapper.Instance.Map<TeacherViewModel>);
        }

        public IEnumerable<TeacherTypeViewModel> GetAllTypes()
        {
            return _repository.GetAll<TeacherType>().AsEnumerable().Select(Mapper.Instance.Map<TeacherTypeViewModel>);
        }

        public TeacherViewModel GetDirector()
        {
            return Mapper.Instance.Map<TeacherViewModel>(_repository.GetById<TeacherType>(1).Teachers.FirstOrDefault());
        }

        public void SetDirector(long vm)
        {
            var currentdirector = _repository.GetAll<Teacher>().FirstOrDefault(x => x.IdType == 1);
            if (currentdirector != null)
            {
                currentdirector.IdType = 3;
            }
            _repository.Save();

            var teacher = _repository.GetById<Teacher>(vm);
            teacher.IdType = 1;
            _repository.Save();
        }

        public IEnumerable<TeacherViewModel> GetHeadTeachers()
        {
            return _repository.GetById<TeacherType>(2).Teachers.Select(Mapper.Instance.Map<TeacherViewModel>);
        }
    }
}