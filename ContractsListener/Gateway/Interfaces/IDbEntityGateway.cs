using ContractsListener.Domain;
using System;
using System.Threading.Tasks;

namespace ContractsListener.Gateway.Interfaces
{
    public interface IDbEntityGateway
    {
        Task<DomainEntity> GetEntityAsync(Guid id);
        Task SaveEntityAsync(DomainEntity entity);
    }
}
