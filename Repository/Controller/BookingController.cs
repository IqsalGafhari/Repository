using APBookingManagementAppI.Contracts;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    private readonly IBookingRepository _bookingRepository;

    public BookingController(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    [HttpGet]
    public IActionResult GetAll()//method utk get all
    {
        var result = _bookingRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)// method get by id
    {
        var result = _bookingRepository.GetByGuid(guid);
        if (result is null)
        {
            return NotFound("Id Not Found");
        }
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(Booking booking)// method create
    {
        var result = _bookingRepository.Create(booking);
        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }


    [HttpPut]
    public IActionResult Update(Booking booking)//method put Update tbl booking
    {
        var result = _bookingRepository.Update(booking);
        if (!result)
        {
            return BadRequest("Failed To Update Data");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(Guid guid)//method delete tbl booking
    {
        var booking = _bookingRepository.GetByGuid(guid);
        var result = _bookingRepository.Delete(booking);
        if (!result)
        {
            return BadRequest("Failed To Delete Data");
        }

        return Ok(result);
    }
}