using System.Linq;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Threading.Tasks;
using ApplicationCore;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository
{
    public class AccountRepository : EFRepository<Account>, IAccountRepository
    {
        protected new RegisterContext Context => base.Context as RegisterContext;
        public AccountRepository(RegisterContext context) : base(context)
        {

        }

        public async Task<Account> getAccountByPersonId(string person_id)
        {
            var predicate = PredicateBuilder.True<Account>();
            predicate.And(m => m.PersonId.Equals(person_id));
            var acc = await this.FindAsync(predicate);
            if (acc.Count() != 1) return null;
            return acc.ElementAt(0);
        }
        private async Task changeAccountStatus(string username, STATUS status)
        {
            try
            {
                var acc = await this.GetByAsync(username);
                acc.Status = status;
                this.Context.Update(acc);
                await this.Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("ChangeAccountStatus() Unexpected: " + e);
            }
        }
        private async Task changeAccountStatus(Account acc, STATUS status)
        {
            try
            {
                acc.Status = status;
                this.Context.Update(acc);
                await this.Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("ChangeAccountStatus() Unexpected: " + e);
            }
        }

        public async Task activate(string username)
        {
            await this.changeAccountStatus(username, STATUS.AVAILABLE);
        }

        public async Task disable(string username)
        {
            await this.changeAccountStatus(username, STATUS.DISABLED);
        }

        public async Task activate(Account acc)
        {
            await this.changeAccountStatus(acc, STATUS.AVAILABLE);
        }

        public async Task disable(Account acc)
        {
            await this.changeAccountStatus(acc, STATUS.DISABLED);
        }
    }
}