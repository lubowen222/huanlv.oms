using ProtoBuf;
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

        [ProtoMember(2)]
        public int OemId { get; set; }

        [ProtoMember(3)]
        public string Cellphone { get; set; }

        [ProtoMember(4)]
        public string Password { get; set; }

        [ProtoMember(5)]
        public DateTime RegisterTime { get; set; }

        [ProtoMember(6)]
        public int Status { get; set; }
    }
}
