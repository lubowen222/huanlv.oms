using System;
using Surging.Core.Domain.Entities;
using Surging.Huanlv.Domain.Core;

namespace Huanlv.Passport.Domain.AggregatesModel.UserAggregate
{
    public class User : Entity<long>
    {
        public int OemId { get; set; }

        public string Cellphone { get; set; }

        public string Password { get; set; }

        public DateTime RegisterTime { get; set; }

        public int Status { get; set; }
    }
}
