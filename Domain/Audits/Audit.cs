using Moulding.Domain.Alerts;
using Moulding.Domain.MouldCards;

namespace Moulding.Domain.Audits;

public class Audit
{
    private List<Alert> _alerts;

    public AuditId Id { get; private set; }
    public MouldCard MouldCard { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public IReadOnlyCollection<Alert> Alerts => _alerts;

    private Audit(MouldCard mouldCard)
    {
        Id = AuditId.Create();
        MouldCard = mouldCard;
        CreatedAtUtc = DateTime.UtcNow;
        _alerts = new List<Alert>();
    }

    public static Audit Create(MouldCard mouldCard)
    {
        return new Audit(mouldCard);
    }

    public Alert RaiseAlert(string property, string expectedValue, string actualValue)
    {
        var alert = Alert.Create(MouldCard.Id, property, expectedValue, actualValue);
        _alerts.Add(alert);
        return alert;
    }
}
