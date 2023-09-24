using Moulding.Domain.MouldCards;

namespace Moulding.Application;

public interface IAuditService
{
    Task RunProcessAudit(Guid mouldCardId);
}
