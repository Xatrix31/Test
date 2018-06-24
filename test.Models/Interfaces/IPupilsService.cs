using System.Collections.Generic;
using test.Models.ViewModels;

namespace test.Models.Interfaces
{
    public interface IPupilsService
    {
        void AddPupil(PupilViewModel pupil);
        PupilViewModel GetPupilById(long idPupil);
        IEnumerable<PupilViewModel> GetPupilsByIdClass(long idClass);
        void EditPupil(PupilViewModel pupil);
        void DeletePupil(long idPupil);
        IEnumerable<PupilViewModel> GetAllPupils();
        IEnumerable<PupilViewModel> GetFilteredPupils(string gender, string schoolClass);
    }
}