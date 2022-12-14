using ContractsListener.Boundary;
using ContractsListener.Domain;
using ContractsListener.Gateway.Interfaces;
using ContractsListener.Infrastructure.Exceptions;
using ContractsListener.UseCase.Interfaces;
using Hackney.Core.Logging;
using System;
using System.Threading.Tasks;

namespace ContractsListener.UseCase
{
    public class DoSomethingUseCase : IDoSomethingUseCase
    {
        private readonly IDbEntityGateway _gateway;

        public DoSomethingUseCase(IDbEntityGateway gateway)
        {
            _gateway = gateway;
        }

        [LogCall]
        public async Task ProcessMessageAsync(EntityEventSns message)
        {
            if (message is null) throw new ArgumentNullException(nameof(message));

            // TODO - Implement use case logic
            DomainEntity entity = await _gateway.GetEntityAsync(message.EntityId).ConfigureAwait(false);
            if (entity is null) throw new EntityNotFoundException<DomainEntity>(message.EntityId);

            entity.Description = "Updated";

            // Save updated entity
            await _gateway.SaveEntityAsync(entity).ConfigureAwait(false);
        }
    }
}
