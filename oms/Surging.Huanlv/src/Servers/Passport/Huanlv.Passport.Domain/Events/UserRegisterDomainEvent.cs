using System;
using MediatR;

namespace Huanlv.Passport.Domain.Events
{
    public class UserRegisterDomainEvent : INotification
    {
        public long Id { get; }

        public string CellPhone { get;}

        public string Password { get; }

        public DateTime RegisterTime { get; }

        public UserRegisterDomainEvent(string cellphone,string password)
        {
            CellPhone = cellphone;
            Password = password;
            RegisterTime = DateTime.Now;
        }
    }
}
