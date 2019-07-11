using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.Domain.Repository;
using Huanlv.Passport.IApplication;
using Huanlv.Passport.IApplication.Models.Input;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.Dapper.Repositories;
using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.Application
{
    [ModuleName("Account")]
    public class AccountService : ProxyServiceBase, IAccountService
    {
        private readonly AccountRepository _repository;
        public AccountService(AccountRepository repository)
        {
            this._repository = repository;
        }

        public async Task<bool> CheckPhoneRegistered(int oemId, string phone)
        {
            var account = await _repository.GetService<IDapperRepository<Account, long>>().FirstAsync(s => s.OemId == oemId && s.UserName == phone);
            if (account == null)
                return false;
            return true;
        }

        public Task<bool> RegisteredAccount(RegisteredAccountDto model)
        {
            throw new NotImplementedException();
        }
    }
}
