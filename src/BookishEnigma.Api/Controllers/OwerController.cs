using BookishEnigma.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BookishEnigma.Api.Controllers;

[Route("api/owner")]
[ApiController]
public class OwerController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private IRepositoryWrapper _repository;

    public OwerController(ILoggerManager logger,
                          IRepositoryWrapper repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllOwners()
    {
        try
        {
            var owners = _repository.Owner.GetAllOwners();
            _logger.LogInfo($"Returned all owners from database.");
            return Ok(owners);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");
            return StatusCode(500, "Internal server error");
        }
    }
}
