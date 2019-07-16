using Huanlv.Passport.IApplication;
using Huanlv.Passport.IApplication.Models.Events;
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
        public override async Task Handle(RegisteredEvent @event)
        {
            Console.WriteLine($"消费1。");
            await _accountService.RegisteredAccount(new IApplication.Models.Input.RegisteredAccountDto()
            {
                OemId = @event.OemId,
                UserName = @event.UserName,
                Password = @event.Password,
                Source = @event.Source
            });
            Console.WriteLine($"消费1失败。");
            throw new NotImplementedException();
        }

        public override Task Handled(EventContext context)
        {
            var model = context.Content;
            return Task.CompletedTask;
        }
    }
}
