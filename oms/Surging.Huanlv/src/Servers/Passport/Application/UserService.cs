using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.IApplication;
using Huanlv.Passport.IApplication.Models;
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
        private readonly IDapperRepository<User, long> _userRepository;
        private readonly IUserRepository _userManager;
        public UserService(
            IDapperRepository<User, long> userRepository,
            IUserRepository userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<UserDto> GetUserById(long oemId, long id)
        {
            var result = await _userRepository.SingleOrDefaultAsync(s => s.OemId == oemId && s.Id == id);
            return new UserDto() { };
        }

        public async Task<bool> CheckRegister(int oemId, string cellphone)
        {
            var result = await _userRepository.FirstOrDefaultAsync(s => s.OemId == oemId && s.Cellphone == cellphone);
            if (result == null)
                return false;
            return true;
        }
    }
}
