namespace Moulding.Domain.Audits;

/// <summary>
/// Audit ID value type
/// </summary>
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
