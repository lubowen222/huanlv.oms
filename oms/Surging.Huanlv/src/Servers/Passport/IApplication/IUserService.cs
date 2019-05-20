using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.CPlatform.Ioc;
using System;
using System.Threading.Tasks;
using Huanlv.Passport.IApplication.Models;

namespace Huanlv.Passport.IApplication
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        Task<UserDto> GetUserById(long oemId, long id);

        Task<bool> CheckRegister(int oemId, string cellphone);
    }
}
