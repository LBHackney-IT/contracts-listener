using ContractsListener.Boundary;
using System.Threading.Tasks;

namespace ContractsListener.UseCase.Interfaces
{
    public interface IMessageProcessing
    {
        Task ProcessMessageAsync(EntityEventSns message);
    }
}
