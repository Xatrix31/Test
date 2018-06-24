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

        public IEnumerable<PupilViewModel> GetAllPupils()
        {
            return _repository.GetAll<Pupil>().AsEnumerable().Select(Mapper.Instance.Map<PupilViewModel>);
        }

        public IEnumerable<PupilViewModel> GetFilteredPupils(string gender, string schoolClass)
        {
            var query = _repository.GetAll<Pupil>();
            if (!string.IsNullOrEmpty(gender)) query = query.Where(x => x.Gender.Equals(gender));
            if (!string.IsNullOrEmpty(schoolClass)) query = query.Where(x => x.Class.ClassName.Equals(schoolClass));
            return query.AsEnumerable().Select(Mapper.Instance.Map<PupilViewModel>);
        }

        public void EditPupil(PupilViewModel pupil)
        {
            var src = _repository.GetById<Pupil>(pupil.Id);
            src.Name = pupil.Name;
            src.Surname = pupil.Surname;
            src.Gender = pupil.Gender.ToString();
            _repository.Save(src);
        }

        public PupilViewModel GetPupilById(long idPupil)
        {
            return Mapper.Instance.Map<PupilViewModel>(_repository.GetById<Pupil>(idPupil));
        }

        public IEnumerable<PupilViewModel> GetPupilsByIdClass(long idClass)
        {
            return _repository.GetAll<Pupil>().Where(x => x.IdClass == idClass).AsEnumerable().Select(Mapper.Instance.Map<PupilViewModel>);
        }
    }
}