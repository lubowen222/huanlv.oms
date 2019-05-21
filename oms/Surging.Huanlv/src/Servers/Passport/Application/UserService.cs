using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.IApplication;
using Huanlv.Passport.IApplication.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.Dapper.Repositories;
using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.Application
{
    [ModuleName("User")]
    public class UserService : ProxyServiceBase, IUserService
    {
        public async Task<UserDto> GetUserById(long oemId, long id)
        {
            var user = await GetService<IDapperRepository<User, long>>().SingleOrDefaultAsync(s => s.OemId == oemId && s.Id == id);
            return user.MapTo<UserDto>();
        }

        public async Task<bool> CheckRegister(int oemId, string cellphone)
        {
            var result = await GetService<IDapperRepository<User, long>>().FirstOrDefaultAsync(s => s.OemId == oemId && s.Cellphone == cellphone);
            if (result == null)
                return false;
            return true;
        }
    }
}
