using Surging.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.Domain.Models
{
    public class UserInfo : Entity<long>
    {
        public int OemId { get; set; }

        public long AccountId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        public string HeadImg { get; set; }

        /// <summary>
        /// 邮件地址
        /// </summary>
        public string Mail { get; set; }
        
        public string Phone { get; set; }
        
        public string QQ { get; set; }
        
        public string Weixin { get; set; }
        
        public string Wid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        public bool IsFakePhone { get; set; }

        /// <summary>
        /// 用户来源
        /// </summary>
        public int Source { get; set; }
    }
}
