using APBookingManagementAppI.Contracts;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : ControllerBase
{
    private readonly IUniversityRepository _universityRepository;

    public UniversityController(IUniversityRepository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    [HttpGet]
    public IActionResult GetAll()//method utk get all
    {
        var result = _universityRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)// method get by id
    {
        var result = _universityRepository.GetByGuid(guid);
        if (result is null)
        {
            return NotFound("Id Not Found");
        }
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(University university)// method create
    {
        var result = _universityRepository.Create(university);
        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }

    
    [HttpPut]
    public IActionResult Update(University university)//method put Update tbl university
    {
        var result = _universityRepository.Update(university);
        if (!result)
        {
            return BadRequest("Failed To Update Data");
        }

        return Ok(result);
    }
    
    [HttpDelete]
    public IActionResult Delete(Guid guid)//method delete tbl university
    {
        var university = _universityRepository.GetByGuid(guid);
        var result = _universityRepository.Delete(university);
        if (!result)
        {
            return BadRequest("Failed To Delete Data");
        }

        return Ok(result);
    }
}