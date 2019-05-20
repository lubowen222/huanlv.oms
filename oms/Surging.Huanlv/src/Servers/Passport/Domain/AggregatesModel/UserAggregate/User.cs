using System;
using Surging.Core.Domain.Entities.Auditing;
using Surging.Huanlv.Core.Enums;
using Surging.Huanlv.Domain.Core;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public class User : FullAuditedEntity<long>
    {
        public int OemId { get; set; }

        public string Cellphone { get; private set; }

        public string Password { get; private set; }

        public DateTime RegisterTime { get; private set; }

        public UserStatus Status { get; private set; }
    }
}
