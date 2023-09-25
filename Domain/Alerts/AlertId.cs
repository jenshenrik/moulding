namespace Moulding.Domain.Alerts;

/// <summary>
/// Alert ID value type
/// </summary>
public record AlertId
{
    public Guid Value { get; private set; }

    /// <summary>
    /// Create a new instance of an alert ID.
    /// Should be used when generating new IDs
    /// </summary>
    public AlertId()
    {
        Value = Guid.NewGuid();
    }

    /// <summary>
    /// Create an instance of an alert ID with a given value.
    /// Should be used when recreating existing alert IDs.
    /// </summary>
    /// <param name="value">The ID of the alert</param>
    public AlertId(Guid value)
    {
        Value = value;
    }
}
