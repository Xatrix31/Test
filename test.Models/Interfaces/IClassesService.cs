using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}