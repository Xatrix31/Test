﻿using System.Collections.Generic;
using test.Models.ViewModels;

namespace test.Models.Interfaces
{
    public interface IPupilsService
    {
        void AddPupil(PupilViewModel pupil);
        PupilViewModel GetPupilById(long idPupil);
        ICollection<PupilViewModel> GetPupilsByIdClass(long idClass);
        void EditPupil(PupilViewModel pupil);
        void DeletePupil(long idPupil);
    }
}