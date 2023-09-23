namespace Moulding.Domain;

/// <summary>
/// Mould card entity class
/// </summary>
public class MouldCard
{
    public MouldCardId Id { get; private set; }
    public MouldingMachineId MouldingMachineId { get; private set; }
    public int CycleTime { get; private set; }
    public int InjectionTime { get; private set; }
    public double InletTemperature { get; private set; }

    private MouldCard(MouldingMachineId mouldingMachineId)
    {
        Id = MouldCardId.Create();
        MouldingMachineId = mouldingMachineId;
    }

    /// <summary>
    /// Create an instance of the mould card entity
    /// </summary>
    /// <param name="mouldingMachineId">The ID of the moulding machine the card is associated with</param>
    /// <returns>A new instance of a mould card</returns>
    public static MouldCard Create(MouldingMachineId mouldingMachineId)
    {
        return new MouldCard(mouldingMachineId);
    }
}
