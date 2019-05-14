using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.CPlatform.Ioc;
using System;
using System.Threading.Tasks;

namespace Huanlv.Passport.IApplication
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        Task<bool> CheckRegisetr(int oemId, string cellphone);
    }
}
