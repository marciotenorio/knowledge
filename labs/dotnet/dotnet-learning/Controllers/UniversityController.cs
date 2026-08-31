using System.Net.Mime;
using DotNetLearning.Database;
using DotNetLearning.Models;
using DotNetLearning.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace DotNetLearning.Controllers;

[ApiController]
[Route("[controller]")]
public class UniversityController : ControllerBase
{
    public DotNetLearningContext _context { get; set; }

    public UniversityController(DotNetLearningContext context)
    {
        _context = context;
    }

    [HttpGet("students")]
    public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents([FromServices] TestDIService service)
    {
        var testDiService = service;
        return await _context.Students
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
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
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