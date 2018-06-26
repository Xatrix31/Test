using System.Collections.Generic;
using test.Models.ViewModels;

namespace test.Models.Interfaces
{
    public interface IClassesService
    {
        IEnumerable<SchoolClassViewModel> GetClasses();
        SchoolClassViewModel GetClassById(long idClass);
        void AddClass(SchoolClassViewModel viewModel);
        void EditClass(SchoolClassViewModel viewModel);
        void DeleteClass(long idClass);
        IEnumerable<string> GetClassNames();
        PupilViewModel GetMonitor(long idClass);
        void SetMonitor(PupilViewModel pupil);
    }
}