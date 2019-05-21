using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.CPlatform.Ioc;
using System;
using System.Threading.Tasks;
using Huanlv.Passport.IApplication.Models;
using Surging.Core.CPlatform.Filters.Implementation;
using Surging.Core.CPlatform.Support.Attributes;
using Surging.Core.System.Intercept;
using Surging.Core.CPlatform.Runtime.Client.Address.Resolvers.Implementation.Selectors.Implementation;
using Surging.Core.Caching;
using Surging.Core.CPlatform.Support;

namespace Huanlv.Passport.IApplication
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        [Authorization(AuthType = AuthorizationType.JWT)]
        [Command(Strategy = StrategyType.Injection, ShuntStrategy = AddressSelectorMode.HashAlgorithm, ExecutionTimeoutInMilliseconds = 1500, BreakerRequestVolumeThreshold = 3, Injection = @"return null;", RequestCacheEnabled = true)]
        [InterceptMethod(CachingMethod.Get, Key = "GetUserById_{0}", CacheSectionType = SectionType.ddlCache, Mode = CacheTargetType.Redis, Time = 480)]
        Task<UserDto> GetUserById(long oemId, long id);

        Task<bool> CheckRegister(int oemId, string cellphone);
    }
}
