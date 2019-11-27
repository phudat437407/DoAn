using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository Patients{get;}
        IAccountRepository Accounts { get; }
        //IDoctorRepository Doctor{get;}
        //IUserRepository User{get;}
        // bo sung them nhung repository khac

        int Complete();
        Task<int> CompleteAsync();
    }
}