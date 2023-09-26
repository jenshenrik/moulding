using Moulding.Domain.Alerts;

namespace Moulding.Application;

/// <summary>
/// Business service for running a process audit.
/// </summary>
public interface IAuditService
{
    /// <summary>
    /// Perform an audit of a specified mould card by reading
    /// the current values from the machine it is attached to
    /// and compare them with the values of the specified mould card.
    /// </summary>
    /// <param name="mouldCardId">The ID of the mould card to audit.</param>
    /// <returns>A list of alerts raised for drifting values, if any.</returns>
    Task<IReadOnlyCollection<Alert>> RunProcessAudit(Guid mouldCardId);
}
