using Moulding.Domain.Alerts;
using Moulding.Domain.MouldCards;

namespace Moulding.Domain.Audits;

/// <summary>
/// Audit aggregate. Holds logic to audit its mould card against
/// a set of moulding machine values and raise alerts if relevant.
/// </summary>
public class Audit
{
    private List<Alert> _alerts;

    public AuditId Id { get; private set; }
    public MouldCard MouldCard { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public IReadOnlyCollection<Alert> Alerts => _alerts;

    /// <summary>
    /// Create a new audit of a mould card.
    /// </summary>
    /// <param name="mouldCard">The mould card to audit.</param>
    public Audit(MouldCard mouldCard)
    {
        Id = new AuditId();
        MouldCard = mouldCard;
        CreatedAtUtc = DateTime.UtcNow;
        _alerts = new List<Alert>();
    }

    /// <summary>
    /// Perform an audit by comparing the values read from specified moulding machine
    /// with the audit's mould card.
    ///
    /// Generates alerts for any drifting values on this audit.
    /// </summary>
    /// <param name="machineValues">The machine values to compare the mould card to.</param>
    public void PerformProcessAudit(MouldingMachineReading machineValues)
    {
        if (MouldCard.CycleTimeInSeconds != machineValues.CycleTimeInSeconds)
        {
            RaiseAlert(
                nameof(MouldCard.CycleTimeInSeconds),
                MouldCard.CycleTimeInSeconds.ToString(),
                machineValues.CycleTimeInSeconds.ToString()
            );
        }

        if (MouldCard.InjectionTimeInSeconds != machineValues.InjectionTimeInSeconds)
        {
            RaiseAlert(
                nameof(MouldCard.InjectionTimeInSeconds),
                MouldCard.InjectionTimeInSeconds.ToString(),
                machineValues.InjectionTimeInSeconds.ToString()
            );
        }

        if (MouldCard.InletTemperatureInCelcius != machineValues.InletTemperatureInCelcius)
        {
            RaiseAlert(
                nameof(MouldCard.InletTemperatureInCelcius),
                MouldCard.InletTemperatureInCelcius.ToString(),
                machineValues.InletTemperatureInCelcius.ToString()
            );
        }

        if (MouldCard.Airflow != machineValues.Airflow)
        {
            RaiseAlert(
                nameof(MouldCard.Airflow),
                MouldCard.Airflow.ToString(),
                machineValues.Airflow.ToString()
            );
        }

        if (MouldCard.Waterflow != machineValues.Waterflow)
        {
            RaiseAlert(
                nameof(MouldCard.Waterflow),
                MouldCard.Waterflow.ToString(),
                machineValues.Waterflow.ToString()
            );
        }
    }

    private Alert RaiseAlert(string property, string expectedValue, string actualValue)
    {
        var alert = new Alert(Id, property, expectedValue, actualValue);
        _alerts.Add(alert);
        return alert;
    }
}
