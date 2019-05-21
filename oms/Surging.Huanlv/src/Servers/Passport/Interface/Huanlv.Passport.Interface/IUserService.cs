using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.CPlatform.Ioc;
using System;
using System.Threading.Tasks;
using Surging.Core.CPlatform.Filters.Implementation;
using Surging.Core.CPlatform.Support.Attributes;
using Surging.Core.CPlatform.Runtime.Client.Address.Resolvers.Implementation.Selectors.Implementation;
using Surging.Core.CPlatform.Support;

namespace Huanlv.Passport.Interface
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        [Authorization(AuthType = AuthorizationType.JWT)]
        [Command(Strategy = StrategyType.Injection, ShuntStrategy = AddressSelectorMode.HashAlgorithm, ExecutionTimeoutInMilliseconds = 1500, BreakerRequestVolumeThreshold = 3, Injection = @"return null;", RequestCacheEnabled = true)]
        Task<UserDto> GetUserById(long oemId, long id);

        Task<bool> CheckRegister(int oemId, string cellphone);
    }
}
