using System;
using System.Collections.Generic;
using Huanlv.Passport.Domain.Exceptions;
using Surging.Huanlv.Domain.Core;
using System.Linq;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public class UserStatus
        : Enumeration
    {
        public static UserStatus Register = new UserStatus(1, nameof(Register).ToLowerInvariant());
        public static UserStatus Disabled = new UserStatus(2, nameof(Disabled).ToLowerInvariant());

        public UserStatus(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<UserStatus> List() =>
            new[] { Register, Disabled };

        public static UserStatus FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new UserDomainException($"Possible values for UserStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static UserStatus From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new UserDomainException($"Possible values for UserStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
