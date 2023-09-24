using Moulding.Domain.Audits;
using Moulding.Domain.MouldCards;

namespace Moulding.Application;

public class AuditService : IAuditService
{
    private readonly IMouldCardRepository _mouldCardRepository;
    private readonly IUnitOfWork _unitOfWork;

    public async Task RunProcessAudit(Guid mouldCardId)
    {
        // Get mould card
        var mouldCard = await _mouldCardRepository.GetByIdAsync(MouldCardId.Create(mouldCardId));

        // Create audit
        Audit.Create(mouldCard);

        // Read machine values

        // Compare and raise alerts

        // Persist changes
        // await _unitOfWork.SaveChangesAsync();

        throw new NotImplementedException();
    }
}
