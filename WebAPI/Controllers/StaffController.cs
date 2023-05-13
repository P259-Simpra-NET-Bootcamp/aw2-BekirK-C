using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
    IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [HttpGet("getall")]
    public List<Staff> GetAll()
    {
        return _staffService.GetAll();
    }

    [HttpGet("getbyid")]
    public Staff GetById(int id)
    {
        return _staffService.GetById(id);
    }

    [HttpGet("getbyfullname")]
    public List<Staff> GetByFullName([FromQuery] string firstName, string lastName)
    {
        return _staffService.GetByFullName(firstName, lastName);
    }

    [HttpPost("add")]
    public void Add([FromBody] Staff staff)
    {
        _staffService.Add(staff);
    }

    [HttpPut("update")]
    public void Update([FromBody] Staff staff)
    {
        _staffService.Update(staff);
    }
}
