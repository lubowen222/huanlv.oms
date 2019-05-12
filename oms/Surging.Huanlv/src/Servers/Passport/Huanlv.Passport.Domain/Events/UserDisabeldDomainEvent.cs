using System;
using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using MediatR;

namespace Huanlv.Passport.Domain.Events
{
    public class UserDisabeldDomainEvent : INotification
    {
        public User User { get; }

        public UserDisabeldDomainEvent(User user)
        {
            User = user;
        }
    }
}
