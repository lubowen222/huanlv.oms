using Huanlv.Passport.Domain.Events;
using Huanlv.Passport.IApplication;
using Surging.Core.CPlatform.EventBus.Events;
using Surging.Core.CPlatform.Utilities;
using Surging.Core.EventBusRabbitMQ;
using Surging.Core.EventBusRabbitMQ.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Huanlv.Passport.Domain.EventHandlers
{
    [QueueConsumer("RegisteredEventHandler", QueueConsumerMode.Normal, QueueConsumerMode.Fail)]
    public class RegisteredEventHandler : BaseIntegrationEventHandler<RegisteredEvent>
    {
        private readonly IAccountService _accountService;
        public RegisteredEventHandler()
        {
            _accountService = ServiceLocator.GetService<IAccountService>("Account");
        }
        public override Task Handle(RegisteredEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
