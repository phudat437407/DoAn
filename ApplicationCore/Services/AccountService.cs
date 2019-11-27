
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using AutoMapper;
namespace ApplicationCore.Services
{
    public class AccountService : Service<Account, AccountDTO, AccountDTO>, IAccountService
    {
        public AccountService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {

        }

        //query
        public async Task<IEnumerable<AccountDTO>> getAllAccountAsync()
        {
            return this.toDtoRange(await unitOfWork.Accounts.GetAllAsync());
        }
        public async Task<AccountDTO> getAccountAsync(string person_id)
        {
            var acc = await unitOfWork.Accounts.getAccountByPersonId(person_id);
            if (acc == null) return null;
            return this.toDto(acc);
        }


        //action
        public async Task addAccountAsync(AccountDTO dto)
        {
            var temp = await unitOfWork.Accounts.getAccountByPersonId(dto.PersonId);
            if (!await this.isExistedUsernameAsync(dto.Username) && temp == null)
            {
                var acc = this.toEntity(dto);
                await unitOfWork.Accounts.AddAsync(acc);
                await unitOfWork.CompleteAsync();
            }

        }
        public async Task removeAccountAsync(string person_id)
        {
            var acc = await unitOfWork.Accounts.getAccountByPersonId(person_id);
            if (acc != null)
            {
                await unitOfWork.Accounts.RemoveAsync(acc);
                await unitOfWork.CompleteAsync();
            }
        }
        public async Task updateAccountAsync(AccountDTO dto)
        {
            if (await this.isExistedUsernameAsync(dto.Username))
            {
                var acc = this.toEntity(dto);
                await unitOfWork.Accounts.UpdateAsync(acc);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task<bool> isExistedUsernameAsync(string username)
        {
            return await unitOfWork.Accounts.GetByAsync(username) != null;
        }
        public async Task<bool> loginCheckAsync(AccountDTO dto)
        {
            var predicate = PredicateBuilder.True<Account>();
            predicate.And(m => m.Username.Equals(dto.Username));
            predicate.And(m => m.Password.Equals(dto.Password));
            var res = await unitOfWork.Accounts.FindAsync(predicate);
            if (res.Count() != 1) return false;
            return true;
        }

        public async Task disableAccountAsync(string person_id)
        {
            var acc = await unitOfWork.Accounts.getAccountByPersonId(person_id);
            if (acc != null)
            {
                await unitOfWork.Accounts.disable(acc);
                //await unitOfWork.CompleteAsync(); already in above function
            }
        }
        public async Task activateAccountAsync(string person_id)
        {
            var acc = await unitOfWork.Accounts.getAccountByPersonId(person_id);
            if (acc != null)
            {
                await unitOfWork.Accounts.activate(acc);
                //await unitOfWork.CompleteAsync(); already in above function
            }
        }

    }
}