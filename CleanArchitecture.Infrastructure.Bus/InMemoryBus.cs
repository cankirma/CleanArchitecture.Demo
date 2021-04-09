﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitecture.Infrastructure.Bus
{
    public sealed class InMemoryBus: IMediatorHandler
    {

        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);

        }
    }
}