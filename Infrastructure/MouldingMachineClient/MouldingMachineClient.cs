using Moulding.Domain;
using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure.MouldingMachineClient;

public class MouldingMachineClient : IMouldingMachineClient
{
    public async Task<MouldingMachineReading> ReadMachineValues(MouldingMachineId mouldingMachineId)
    {
        return await Task.FromResult(
            new MouldingMachineReading(
                mouldingMachineId,
                10,
                2,
                190f,
                new PressureValue(65, "PSI"),
                new PressureValue(66, "Bar")
            )
        );
    }
}
