using Moulding.Domain.Audits;

namespace Moulding.Domain.Alerts;

/// <summary>
/// Alert entity class.
/// </summary>
public class Alert
{
    public AlertId Id { get; private set; }
    public AuditId AuditId { get; private set; }
    public string Property { get; private set; }
    public string ExpectedValue { get; private set; }
    public string ActualValue { get; private set; }

    /// <summary>
    /// Create an instance of the alert entity.
    /// Should be used when generating new alerts.
    /// </summary>
    /// <param name="auditId">The ID of the corresponding audit</param>
    /// <param name="property">The property that was is off</param>
    /// <param name="expectedValue">The expected value from the mould card</param>
    /// <param name="actualValue">The actual value from the machine</param>
    /// <returns></returns>
    public Alert(AuditId auditId, string property, string expectedValue, string actualValue)
    {
        Id = new AlertId();
        AuditId = auditId;
        Property = property;
        ExpectedValue = expectedValue;
        ActualValue = actualValue;
    }

    /// <summary>
    /// Create an instance of the alert entity.
    /// Should be used when recreating existing alerts.
    /// </summary>
    /// <param name="alertId">The ID of the alert entity</param>
    /// <param name="auditId">The ID of the corresponding audit</param>
    /// <param name="property">The property that was is off</param>
    /// <param name="expectedValue">The expected value from the mould card</param>
    /// <param name="actualValue">The actual value from the machine</param>
    /// <returns></returns>
    public Alert(
        AlertId alertId,
        AuditId auditId,
        string property,
        string expectedValue,
        string actualValue
    )
    {
        Id = alertId;
        AuditId = auditId;
        Property = property;
        ExpectedValue = expectedValue;
        ActualValue = actualValue;
    }
}
