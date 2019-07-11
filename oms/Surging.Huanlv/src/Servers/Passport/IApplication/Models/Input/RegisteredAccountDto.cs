using Huanlv.Core.Enums.Passport;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.IApplication.Models.Input
{
    [ProtoContract]
    public class RegisteredAccountDto
    {
        [ProtoMember(1)]
        public int OemId { get; set; }

        [ProtoMember(2)]
        public string UserName { get; set; }

        [ProtoMember(3)]
        public string Password { get; set; }

        [ProtoMember(4)]
        public AccountSource Source { get; set; }
    }
}
