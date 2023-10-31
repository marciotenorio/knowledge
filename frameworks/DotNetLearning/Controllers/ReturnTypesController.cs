using DotNetLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearning.Controllers;

//If the [ApiController] attribute is applied, model validation errors result in a 400 status code.
//For more information, see Automatic HTTP 400 responses.
[ApiController]
[Route("return-types")]
public class ReturnTypesController : ControllerBase
{
    /// <summary>
    /// Return a specific type, in this case are 'string' but can be 'Car' or whatever
    /// without known conditions to safeguard against like 'not found(404)' or other things.
    /// When necessary the object are convert implicitly to JSON.
    /// </summary>
    [HttpGet("specific-type")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Person>))]
    //This can be async like:
    //public Task<List<Person>> GetReturnType()
    public List<Person> GetReturnType()
    {
        return new List<Person>
        {
            new Person("Márcio", 27),
            new Person("Tenório", 67)
        };
    }

    /// <summary>
    /// When you want to return a collection of items without specifying a particular status code.
    /// This is commonly used for returning a list of items or a sequence of data.
    /// Buffer or stream depends, see: https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0#return-ienumerablet-or-iasyncenumerablet
    /// </summary>
    [HttpGet("iterable")]
    //This can be async like:
    //public IAsyncEnumerable<Person> GetPerson()
    public IEnumerable<Person> GetIterable()
    {
        return new List<Person>
        {
            new Person("Márcio", 27),
            new Person("Tenório", 67)
        };
    }

    /// <summary>
    /// The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action.
    /// The ActionResult types represent various HTTP status codes.
    /// Because there are multiple return types and paths in this type of action,
    /// liberal use of the [ProducesResponseType] attribute is necessary.
    /// </summary>
    [HttpGet("multiple-return-types/{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Person))]
    //public async Task<IActionResult> GetMultipleIActionResult(int id = 0)
    public IActionResult GetMultipleIActionResult(int id = 0)
    {
        if (id == 0) return Ok(new Person("Tony", 15));
        return NotFound();
    }
    
    /// <summary>
    // ASP.NET Core includes the ActionResult<T> return type for web API controller actions.
    // It enables returning a type deriving from ActionResult or return a specific type.
    // ActionResult<T> offers the following benefits over the IActionResult type:
    //  - The [ProducesResponseType] attribute's Type property can be excluded. For example,
    //  [ProducesResponseType(200, Type = typeof(Product))] is simplified to [ProducesResponseType(200)].
    //  The action's expected return type is inferred from the T in ActionResult<T>.
    // - Implicit cast operators support the conversion of both T and ActionResult to ActionResult<T>.
    //  T converts to ObjectResult, which means return new ObjectResult(T); is simplified to return T;.
    // C# doesn't support implicit cast operators on interfaces. Consequently, conversion of the interface
    // to a concrete type is necessary to use ActionResult<T>.
    //
    // Most actions have a specific return type. Unexpected conditions can occur during action execution,
    // in which case the specific type isn't returned. For example, an action's input parameter may fail model
    // validation. In such a case, it's common to return the appropriate ActionResult type instead of the specific type.
    /// </summary>
    [HttpGet("multiple-return-types-improved/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0#asynchronous-action-1
    public ActionResult<Person> GetMultipleActionResultT(int id = 0)
    {
        if (id == 0) return new Person("Tony", 15);
        return NotFound();
    }
}