using System.Collections.Generic;
using test.Models.ViewModels;

namespace test.Models.Interfaces
{
    public interface ITeachersService
    {
        void AddTeacher(TeacherViewModel teacher);
        TeacherViewModel GetTeacherById(long idTeacher);
        IEnumerable<TeacherViewModel> GetTeachersByIdClass(long idClass);
        IEnumerable<TeacherViewModel> GetAllTeachers();
        IEnumerable<TeacherViewModel> GetTeachersNotInClass(long idClass);
        void EditTeacher(TeacherViewModel teacher);
        void DeleteTeacher(long idTeacher);
        void AddTeacherToClass(long idCLass, TeacherViewModel vm);
        void DeleteTeacherFromClass(long idClass, long idTeacher);
    }
}