using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.Domain.Commands.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Huanlv.Passport.Domain.CommandHandlers
{
    public class UserCommandHandler
        : IRequestHandler<UserRegisterCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;

        // Using DI to inject infrastructure persistence Repositories
        public UserCommandHandler(IMediator mediator,
            IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<bool> Handle(UserRegisterCommand message, CancellationToken cancellationToken)
        {
            var user = new User(message.OemId, message.CellPhone, message.Password);
            _userRepository.Add(user);

            return await _userRepository.UnitOfWork
                .SaveEntitiesAsync();
        }

    }
}
