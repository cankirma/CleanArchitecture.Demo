using System.Threading.Tasks;
using CleanArchitecture.Domain.Core.Commands;

namespace CleanArchitecture.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T Command) where  T: Command;

    }
}