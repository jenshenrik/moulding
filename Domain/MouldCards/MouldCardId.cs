namespace Moulding.Domain.MouldCards;

/// <summary>
/// Mould card ID value type.
/// </summary>
public record MouldCardId
{
    public Guid Value { get; private set; }

    /// <summary>
    /// Create a new instance of a mould card ID.
    /// Should be used when generating new IDs.
    /// </summary>
    public MouldCardId()
    {
        Value = Guid.NewGuid();
    }

    /// <summary>
    /// Create an instance of a mould card ID with a given value.
    /// Should be used when recreating existing card IDs.
    /// </summary>
    /// <param name="value">The ID of the mould card</param>
    public MouldCardId(Guid value)
    {
        Value = value;
    }
}
