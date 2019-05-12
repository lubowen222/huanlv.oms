using System;
using Huanlv.Passport.Domain.Events;
using Huanlv.Passport.Domain.Exceptions;
using Surging.Huanlv.Domain.Core;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public class User : Entity, IAggregateRoot
    {
        public long Id { get; private set; }

        public string Cellphone { get; private set; }

        public string Password { get; private set; }

        public DateTime RegisterTime { get; private set; }

        public UserStatus Status { get; private set; }
        private int _userStatusId;

        public User() { }

        public User(string cellphone, string password) : this()
        {
            AddUserRegisterDomainEvent(cellphone, password);
        }

        private void AddUserRegisterDomainEvent(string cellphone,string password)
        {
            var userRegisterDomainEvent = new UserRegisterDomainEvent(cellphone,password);

            this.AddDomainEvent(userRegisterDomainEvent);
        }

        public void SetDisabledStatus()
        {
            if (_userStatusId == UserStatus.Disabled.Id)
            {
                StatusChangeException(UserStatus.Disabled);
            }

            _userStatusId = UserStatus.Disabled.Id;
            AddDomainEvent(new UserDisabeldDomainEvent(this));
        }

        private void StatusChangeException(UserStatus userStatusToChange)
        {
            throw new UserDomainException($"Is not possible to change the order status from {Status.Name} to {userStatusToChange.Name}.");
        }
    }
}
