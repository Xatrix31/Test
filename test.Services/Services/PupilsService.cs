using System;
using test.Models.Interfaces;

namespace test.Services.Services
{
    public class PupilsService : IPupilsService
    {
        private readonly IRepository _repository;

        public PupilsService(IRepository repository)
        {
            _repository = repository;
        }

        public void AddPupil()
        {
            throw new NotImplementedException();
        }

        public void DeletePupil(long idPupil)
        {
            throw new NotImplementedException();
        }

        public void EditPupil()
        {
            throw new NotImplementedException();
        }

        public void GetPupilById(long idPupil)
        {
            throw new NotImplementedException();
        }

        public void GetPupilsByIdClass(long idClass)
        {
            throw new NotImplementedException();
        }
    }
}