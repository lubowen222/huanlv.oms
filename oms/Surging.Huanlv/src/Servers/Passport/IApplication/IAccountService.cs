using Huanlv.Passport.IApplication.Models.Input;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.IApplication
{
    [ServiceBundle("api/{Service}")]
    public interface IAccountService : IServiceKey
    {
        /// <summary>
        /// 校验手机号是否已注册
        /// </summary>
        /// <param name="oemId"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<bool> CheckPhoneRegistered(int oemId, string phone);

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="oemId"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<bool> RegisteredAccount(RegisteredAccountDto model);
    }
}
