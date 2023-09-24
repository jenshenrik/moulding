using Moulding.Domain;
using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure.MouldingMachineClient;

public interface IMouldingMachineClient
{
    Task<MouldingMachineReading> ReadMachineValues(MouldingMachineId mouldingMachineId);
}
