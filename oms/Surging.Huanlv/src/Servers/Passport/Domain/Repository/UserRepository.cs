using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Surging.Core.Dapper.Manager;
using Surging.Core.Dapper.Repositories;
using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.Domain.Repository
{
    public class UserRepository : ManagerBase
    {
        private readonly IDapperRepository<UserInfo, long> _userDapperRepository;

        private readonly IServiceProxyProvider _serviceProxyProvider;

        public UserRepository(IDapperRepository<UserInfo, long> userDapperRepository,
            IServiceProxyProvider serviceProxyProvider)
        {
            _userDapperRepository = userDapperRepository;
            _serviceProxyProvider = serviceProxyProvider;
        }

        public Task Add(UserInfo user)
        {
            return _userDapperRepository.InsertAsync(user);
        }

        public Task Update(UserInfo user)
        {
            return _userDapperRepository.UpdateAsync(user);
        }

        public Task<UserInfo> GetAsync(int userId)
        {
            return _userDapperRepository.GetAsync(userId);
        }

        public Task<UserInfo> GetByOemIdAsync(long oemId, long userId)
        {
            return _userDapperRepository.FirstOrDefaultAsync(s => s.OemId == oemId && s.Id == userId);
        }

        //public async Task DeleteByUserId(long userId)
        //{
        //    await UnitOfWorkAsync(async (conn, trans) =>
        //    {
        //        await _userRepository.DeleteAsync(p => p.Id == userId, conn, trans);
        //        await _userRoleRepository.DeleteAsync(p => p.UserId == userId, conn, trans);
        //        await _userGroupRelationRepository.DeleteAsync(p => p.UserId == userId, conn, trans);
        //    }, Connection);
        //}


    }
}
