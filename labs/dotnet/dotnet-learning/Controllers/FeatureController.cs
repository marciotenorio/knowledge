using DotNetLearning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace DotNetLearning.Controllers;

[Route("features")]
[ApiController]
//So na versap aspnetcore
// [FeatureGate(FeatureDescriptor.CutText)]
public class FeatureController : ControllerBase
{
    [HttpGet("{text}")]
    public async Task<IActionResult> Get([FromServices] IFeatureManager featureManager, [FromRoute] string text)
    {
        if (await featureManager.IsEnabledAsync(nameof(FeatureDescriptor.CutText))) {
            return Ok(text.Length < 10 ? text : text[..10]);
        }

        return Ok(text);
    }
}

