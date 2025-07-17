using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private static readonly List<Employee> Employees = new()
    {
        new Employee(1, "Alice", "Engineering"),
        new Employee(2, "Bob", "Sales"),
        new Employee(3, "Charlie", "HR")
    };

    [HttpGet]
    public ActionResult<IEnumerable<Employee>> Get()
    {
        return Ok(Employees);
    }

    [HttpGet("{id}")]
    public ActionResult<Employee?> GetById(int id)
    {
        var employee = Employees.FirstOrDefault(e => e.Id == id);
        return employee is not null ? Ok(employee) : NotFound();
    }
}
