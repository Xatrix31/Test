using test.Models.ViewModels;

namespace test.Models.Interfaces
{
    public interface ITeachersService
    {
        void AddTeacher(TeacherViewModel teacher);
        TeacherViewModel GetTeacherById(long idTeacher);
        void GetTeacherByIdClass(long idClass);
        void EditTeacher(TeacherViewModel teacher);
        void DeleteTeacher(long idTeacher);
    }
}