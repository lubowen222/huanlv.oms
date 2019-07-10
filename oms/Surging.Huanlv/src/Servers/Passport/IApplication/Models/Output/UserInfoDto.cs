using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.IApplication.Models.Output
{
    [ProtoContract]
    public class UserInfoDto
    {
        [ProtoMember(1)]
        public int OemId { get; set; }

        [ProtoMember(2)]
        public long AccountId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [ProtoMember(3)]
        public string NickName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [ProtoMember(4)]
        public string RealName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [ProtoMember(5)]
        public string HeadImg { get; set; }

        /// <summary>
        /// 邮件地址
        /// </summary>
        [ProtoMember(6)]
        public string Mail { get; set; }

        [ProtoMember(7)]
        public string Phone { get; set; }

        [ProtoMember(8)]
        public string QQ { get; set; }

        [ProtoMember(9)]
        public string Weixin { get; set; }

        [ProtoMember(10)]
        public string Wid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [ProtoMember(11)]
        public string Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [ProtoMember(12)]
        public string City { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [ProtoMember(13)]
        public string Region { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [ProtoMember(14)]
        public DateTime CreateTime { get; set; }

        [ProtoMember(15)]
        public bool IsFakePhone { get; set; }

        /// <summary>
        /// 用户来源
        /// </summary>
        [ProtoMember(16)]
        public int Source { get; set; }
    }
}
