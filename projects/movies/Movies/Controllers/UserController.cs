using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers;

[ApiController]
[Route("users")]
public class UserController : Controller
{
    private readonly IConfiguration _configuration;

    public UserController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Get all users
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<string> Get(CancellationToken cancellationToken)
    {
        var s = cancellationToken.ToString();
        return new ActionResult<string>(_configuration.GetConnectionString("movies-db"));
        // return Ok(new User());
    }
}