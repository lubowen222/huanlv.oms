using Huanlv.Passport.Interfaces;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.ServerHost.Applications
{
    [ModuleName("User")]
    public class UserService : ProxyServiceBase, IUserService
    {
        public Task<bool> CheckRegister(int oemId, string cellphone)
        {
            return Task.FromResult(true);
        }
    }
}
