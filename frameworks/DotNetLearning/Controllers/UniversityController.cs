using System.Net.Mime;
using DotNetLearning.Database;
using DotNetLearning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace DotNetLearning.Controllers;

[ApiController]
[Route("[controller]")]
public class UniversityController : ControllerBase
{
    public DotNetLearningContext _Context { get; set; }

    public UniversityController(DotNetLearningContext context)
    {
        _Context = context;
    }

    [HttpGet("students")]
    public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
    {
        return await _Context.Students
            .ToListAsync();
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>oiaiasidjasjd</remarks>
    /// <param name="student"></param>
    /// <returns></returns>
    [HttpPost]
    [Produces("application/json")]
    public async Task<ActionResult<Student>> SaveStudent(Student student)
    {
        _Context.Students.Add(student);
        await _Context.SaveChangesAsync();
        return CreatedAtAction(
            actionName: nameof(GetAllStudents),
            routeValues: new Student()
            {
                Id = student.Id
            },
            value: student
        );
    }
}