namespace Moulding.Domain.Audits;

public record AuditId
{
    public Guid Value { get; private set; }

    private AuditId()
    {
        Value = Guid.NewGuid();
    }

    private AuditId(Guid value)
    {
        Value = value;
    }

    public static AuditId Create()
    {
        return new AuditId();
    }

    public static AuditId Create(Guid value)
    {
        return new AuditId(value);
    }
}
