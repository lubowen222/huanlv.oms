using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Huanlv.Passport.Domain.Commands.User
{
    [DataContract]
    public class UserRegisterCommand
        : IRequest<bool>
    {
        [DataMember]
        public int OemId { get; set; }

        [DataMember]
        public string CellPhone { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
