namespace test.Models.Interfaces
{
    public interface IPupilsService
    {
        void AddPupil();
        void GetPupilById(long idPupil);
        void GetPupilsByIdClass(long idClass);
        void EditPupil();
        void DeletePupil(long idPupil);
    }
}