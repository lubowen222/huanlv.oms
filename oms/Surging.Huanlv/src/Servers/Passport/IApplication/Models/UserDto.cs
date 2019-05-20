using ProtoBuf;
using Surging.Huanlv.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.IApplication.Models
{
    [ProtoContract]
    public class UserDto
    {
        [ProtoMember(1)]
        public long Id { get; set; }

        /// <summary>
        /// 厂商Id
        /// </summary>
        [ProtoMember(2)]
        public int OemId { get; set; }

        /// <summary>
        /// 注册手机号
        /// </summary>
        [ProtoMember(3)]
        public string Cellphone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [ProtoMember(4)]
        public string Password { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [ProtoMember(5)]
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [ProtoMember(6)]
        public UserStatus Status { get; set; }

        /// <summary>
        /// 最后操作时间
        /// </summary>
        [ProtoMember(7)]
        public DateTime ModifiedTime { get; set; }
    }
}
