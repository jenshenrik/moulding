using Moulding.Domain;
using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure.MouldingMachineClient;

/// <summary>
/// Mock of a client for reading current values of a moulding machine.
/// </summary>
public interface IMouldingMachineClient
{
    Task<MouldingMachineReading> ReadMachineValues(MouldingMachineId mouldingMachineId);
}
