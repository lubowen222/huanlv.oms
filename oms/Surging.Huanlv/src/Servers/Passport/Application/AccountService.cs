using Huanlv.Passport.IApplication;
using Huanlv.Passport.IApplication.Models.Input;
using Surging.Core.CPlatform.Ioc;
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
        private readonly UserRepository _repository;
        public UserService(UserRepository repository)
        {
            this._repository = repository;
        }

        public Task<bool> CheckPhoneRegistered(int oemId, string phone)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisteredAccount(RegisteredAccountDto model)
        {
            throw new NotImplementedException();
        }
    }
}
