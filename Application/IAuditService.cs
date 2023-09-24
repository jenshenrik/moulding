using Moulding.Domain.Alerts;

namespace Moulding.Application;

public interface IAuditService
{
    Task<IReadOnlyCollection<Alert>> RunProcessAudit(Guid mouldCardId);
}
