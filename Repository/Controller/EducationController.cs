using APBookingManagementAppI.Contracts;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EducationController : ControllerBase
{
    private readonly IEducationRepository _educationRepository;

    public EducationController(IEducationRepository educationRepository)
    {
        _educationRepository = educationRepository;
    }

    [HttpGet]
    public IActionResult GetAll()//method utk get all
    {
        var result = _educationRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)// method get by id
    {
        var result = _educationRepository.GetByGuid(guid);
        if (result is null)
        {
            return NotFound("Id Not Found");
        }
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(Education education)// method create
    {
        var result = _educationRepository.Create(education);
        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }


    [HttpPut]
    public IActionResult Update(Education education)//method put Update tbl education
    {
        var result = _educationRepository.Update(education);
        if (!result)
        {
            return BadRequest("Failed To Update Data");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(Guid guid)//method delete tbl education
    {
        var education = _educationRepository.GetByGuid(guid);
        var result = _educationRepository.Delete(education);
        if (!result)
        {
            return BadRequest("Failed To Delete Data");
        }

        return Ok(result);
    }
}