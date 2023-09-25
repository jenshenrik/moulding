using Microsoft.AspNetCore.Mvc;
using Moulding.Application;
using Moulding.Domain.Alerts;
using Moulding.Domain.MouldCards;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MouldCardsController : ControllerBase
{
    private readonly ILogger<MouldCardsController> _logger;
    private readonly IMouldCardService _mouldCardService;
    private readonly IAuditService _auditService;

    public MouldCardsController(
        ILogger<MouldCardsController> logger,
        IMouldCardService mouldCardService,
        IAuditService auditService
    )
    {
        _logger = logger;
        _mouldCardService = mouldCardService;
        _auditService = auditService;
    }

    [HttpGet(Name = nameof(GetAllMouldCardsAsync))]
    public async Task<ActionResult<IEnumerable<MouldCard>>> GetAllMouldCardsAsync()
    {
        return Ok(await _mouldCardService.GetAllMouldCardsAsync());
    }

    [HttpGet("{mouldCardId}", Name = nameof(GetMouldCardByIdAsync))]
    public async Task<ActionResult<MouldCard>> GetMouldCardByIdAsync(Guid mouldCardId)
    {
        return Ok(await _mouldCardService.GetMouldCardByIdAsync(mouldCardId));
    }

    [HttpPost("{mouldCardId}/audit", Name = nameof(RunProcessAudit))]
    public async Task<ActionResult<IEnumerable<Alert>>> RunProcessAudit(Guid mouldCardId)
    {
        try
        {
            return Ok(await _auditService.RunProcessAudit(mouldCardId));
        }
        catch (ArgumentException e)
        {
            return NotFound(e.Message);
        }
    }
}
