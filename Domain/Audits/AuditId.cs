namespace Moulding.Domain.Audits;

public record AuditId
{
    public Guid Value { get; private set; }

    public AuditId()
    {
        Value = Guid.NewGuid();
    }

    public AuditId(Guid value)
    {
        Value = value;
    }
}
