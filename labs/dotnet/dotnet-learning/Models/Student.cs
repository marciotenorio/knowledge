using System.ComponentModel.DataAnnotations;

namespace DotNetLearning.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Matricula { get; set; }
}