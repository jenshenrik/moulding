namespace Moulding.Domain.MouldCards;

/// <summary>
/// Moulding machine ID value type.
/// </summary>
public record MouldingMachineId
{
    public Guid Value { get; private set; }

    private MouldingMachineId()
    {
        Value = Guid.NewGuid();
    }

    private MouldingMachineId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Create a new instance of a moulding machine ID.
    /// Should be used when generating new IDs
    /// </summary>
    public static MouldingMachineId Create()
    {
        return new MouldingMachineId();
    }

    /// <summary>
    /// Create an instance of a moulding machine ID with a given value.
    /// Should be used when recreating existing machine IDs.
    /// </summary>
    /// <param name="value">The ID of the machine</param>
    public static MouldingMachineId Create(Guid value)
    {
        return new MouldingMachineId(value);
    }
}
