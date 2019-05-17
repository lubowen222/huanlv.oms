using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.CPlatform.Ioc;
using System;
using System.Threading.Tasks;

namespace Huanlv.Passport.Interfaces
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        Task<bool> CheckRegister(int oemId, string cellphone);
    }
}
