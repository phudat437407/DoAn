using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repository;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RegisterContext _context;

        public UnitOfWork(RegisterContext context)
        {
            _context = context;
            this.Accounts = new AccountRepository(_context);
            //User = new UserRepository(context);
        }

        public IPatientRepository Patients { get; } // cung ten vơi IUnitOfWork.IPatientRepository
        public IAccountRepository Accounts { get; private set; }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

    }
}