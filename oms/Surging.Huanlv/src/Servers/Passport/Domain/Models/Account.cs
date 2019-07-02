using Surging.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.Domain.Models
{
    public class Account : Entity<long>
    {
        public int OemId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 账号是否可用
        /// </summary>
        public bool IsDisable { get; set; }

        /// <summary>
        /// 第一次登入时间
        /// </summary>
        public DateTime FirstLogonTime { get; set; }

        /// <summary>
        /// 最后一次登入时间
        /// </summary>
        public DateTime LastLogonTime { get; set; }

        /// <summary>
        /// 登入错误次数
        /// </summary>
        public int LogonErrorNum { get; set; }

        /// <summary>
        /// 登入错误信息
        /// </summary>
        public string LogonError { get; set; }
    }
}
