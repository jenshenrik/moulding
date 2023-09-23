namespace Moulding.Domain.MouldCards;

/// <summary>
/// Mould card ID value type.
/// </summary>
public record MouldCardId
{
    public Guid Value { get; private set; }

    private MouldCardId()
    {
        Value = Guid.NewGuid();
    }

    private MouldCardId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Create a new instance of a mould card ID.
    /// Should be used when generating new IDs
    /// </summary>
    /// <returns></returns>
    public static MouldCardId Create()
    {
        return new MouldCardId();
    }

    /// <summary>
    /// Create an instance of a mould card ID with a given value.
    /// Should be used when recreating existing card IDs.
    /// </summary>
    /// <param name="value">The ID of the mould card</param>
    /// <returns></returns>
    public static MouldCardId Create(Guid value)
    {
        return new MouldCardId(value);
    }
}
