namespace Moulding.Domain;

/// <summary>
/// Moulding machine ID value type.
/// </summary>
public record MouldingMachineId
{
    public Guid Id { get; private set; }

    private MouldingMachineId()
    {
        Id = Guid.NewGuid();
    }

    private MouldingMachineId(Guid id)
    {
        Id = id;
    }

    /// <summary>
    /// Create a new instance of a moulding machine ID.
    /// Should be used when generating new IDs
    /// </summary>
    /// <returns></returns>
    public static MouldingMachineId Create()
    {
        return new MouldingMachineId();
    }

    /// <summary>
    /// Create an instance of a moulding machine ID with a given value.
    /// Should be used when recreating existing machine IDs.
    /// </summary>
    /// <param name="id">The ID of the machine</param>
    /// <returns></returns>
    public static MouldingMachineId Create(Guid id)
    {
        return new MouldingMachineId(id);
    }
}
