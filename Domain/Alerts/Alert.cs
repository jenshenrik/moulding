namespace Moulding.Domain.Alerts;

/// <summary>
/// Alert entity class.
/// </summary>
public class Alert
{
    public AlertId Id { get; private set; }
    public MouldCardId MouldCardId { get; private set; }
    public string Property { get; private set; }
    public string ExpectedValue { get; private set; }
    public string ActualValue { get; private set; }

    #region constructors
    private Alert(
        MouldCardId mouldCardId,
        string property,
        string expectedValue,
        string actualValue
    )
    {
        Id = AlertId.Create();
        MouldCardId = mouldCardId;
        Property = property;
        ExpectedValue = expectedValue;
        ActualValue = actualValue;
    }

    private Alert(
        AlertId alertId,
        MouldCardId mouldCardId,
        string property,
        string expectedValue,
        string actualValue
    )
    {
        Id = alertId;
        MouldCardId = mouldCardId;
        Property = property;
        ExpectedValue = expectedValue;
        ActualValue = actualValue;
    }
    #endregion constructors

    #region factories
    /// <summary>
    /// Create an instance of the alert entity.
    /// Should be used when generating new alerts.
    /// </summary>
    /// <param name="mouldCardId">The ID of the corresponding mould card</param>
    /// <param name="property">The property that was is off</param>
    /// <param name="expectedValue">The expected value from the mould card</param>
    /// <param name="actualValue">The actual value from the machine</param>
    /// <returns></returns>
    public static Alert Create(
        MouldCardId mouldCardId,
        string property,
        string expectedValue,
        string actualValue
    )
    {
        return new Alert(mouldCardId, property, expectedValue, actualValue);
    }

    /// <summary>
    /// Create an instance of the alert entity.
    /// Should be used when recreating existing alerts.
    /// </summary>
    /// <param name="alertId">The ID of the alert entity</param>
    /// <param name="mouldCardId">The ID of the corresponding mould card</param>
    /// <param name="property">The property that was is off</param>
    /// <param name="expectedValue">The expected value from the mould card</param>
    /// <param name="actualValue">The actual value from the machine</param>
    /// <returns></returns>
    public static Alert Create(
        AlertId alertId,
        MouldCardId mouldCardId,
        string property,
        string expectedValue,
        string actualValue
    )
    {
        return new Alert(alertId, mouldCardId, property, expectedValue, actualValue);
    }
    #endregion factories
}