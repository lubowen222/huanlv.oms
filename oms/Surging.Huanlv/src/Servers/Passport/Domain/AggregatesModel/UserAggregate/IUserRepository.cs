using System;
using Surging.Huanlv.Domain.Core;
using System.Threading.Tasks;
using Surging.Core.CPlatform.Ioc;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public interface IUserRepository : ITransientDependency
    {
        Task Add(User user);

        Task Update(User user);

        Task<User> GetAsync(int userId);

        Task<User> GetByOemIdAsync(long oemId, long userId);
    }
}
