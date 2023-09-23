using Microsoft.AspNetCore.Mvc;
using Moulding.Application;
using Moulding.Domain;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MouldCardsController : ControllerBase
{
    private readonly ILogger<MouldCardsController> _logger;
    private readonly IMouldCardService _mouldCardService;

    public MouldCardsController(
        ILogger<MouldCardsController> logger,
        IMouldCardService mouldCardService
    )
    {
        _logger = logger;
        _mouldCardService = mouldCardService;
    }

    [HttpGet(Name = nameof(GetAllMouldCardsAsync))]
    public async Task<ActionResult<IEnumerable<MouldCard>>> GetAllMouldCardsAsync()
    {
        return Ok(await _mouldCardService.GetAllMouldCardsAsync());
    }
}
