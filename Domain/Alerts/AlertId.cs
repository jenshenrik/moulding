namespace Moulding.Domain.Alerts;

/// <summary>
/// Alert ID value type
/// </summary>
public record AlertId
{
    public Guid Value { get; private set; }

    private AlertId()
    {
        Value = Guid.NewGuid();
    }

    private AlertId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Create a new instance of an alert ID.
    /// Should be used when generating new IDs
    /// </summary>
    /// <returns></returns>
    public static AlertId Create()
    {
        return new AlertId();
    }

    /// <summary>
    /// Create an instance of an alert ID with a given value.
    /// Should be used when recreating existing alert IDs.
    /// </summary>
    /// <param name="value">The ID of the alert</param>
    /// <returns></returns>
    public static AlertId Create(Guid value)
    {
        return new AlertId(value);
    }
}
