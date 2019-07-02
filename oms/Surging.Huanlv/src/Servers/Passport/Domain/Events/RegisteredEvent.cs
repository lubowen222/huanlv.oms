using Surging.Core.CPlatform.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huanlv.Passport.Domain.Events
{
    public class RegisteredEvent : IntegrationEvent
    {
        public int OemId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
