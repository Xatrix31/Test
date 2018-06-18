using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using test.Models.Entities;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Services.Services
{
    public class PupilsService : IPupilsService
    {
        private readonly IRepository _repository;

        public PupilsService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddPupil(PupilViewModel pupil)
        {
            _repository.AddNew(Mapper.Instance.Map<Pupil>(pupil));
        }

        public void DeletePupil(long idPupil)
        {
            _repository.Delete<Pupil>(idPupil);
        }

        public void EditPupil(PupilViewModel pupil)
        {
            throw new NotImplementedException();
        }

        public PupilViewModel GetPupilById(long idPupil)
        {
            return Mapper.Instance.Map<PupilViewModel>(_repository.GetById<Pupil>(idPupil));
        }

        public ICollection<PupilViewModel> GetPupilsByIdClass(long idClass)
        {
            return _repository.GetAll<Pupil>().Where(x=> x.IdClass==idClass).AsEnumerable().Select(x=> Mapper.Instance.Map<PupilViewModel>);
        }
    }
}