using System;
using MediatR;

namespace Huanlv.Passport.Domain.Events
{
    public class UserRegisterDomainEvent : INotification
    {
        public long Id { get; }

        public int OemId { get; set; }

        public string CellPhone { get; }

        public string Password { get; }

        public DateTime RegisterTime { get; }

        public UserRegisterDomainEvent(int oemId, string cellphone, string password)
        {
            OemId = oemId;
            CellPhone = cellphone;
            Password = password;
            RegisterTime = DateTime.Now;
        }
    }
}
