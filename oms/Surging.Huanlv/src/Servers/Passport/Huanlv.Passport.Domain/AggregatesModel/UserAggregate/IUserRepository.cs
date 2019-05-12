using System;
using Surging.Huanlv.Domain.Core;
using System.Threading.Tasks;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public interface IUserRepository : IRepository<User>
    {
        User Add(User user);

        void Update(User user);

        Task<User> GetAsync(int userId);
    }
}
