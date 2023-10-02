using APBookingManagementAppI.Contracts;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    private readonly IRoomRepository _roomRepository;

    public RoomController(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    [HttpGet]
    public IActionResult GetAll()//method utk get all
    {
        var result = _roomRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)// method get by id
    {
        var result = _roomRepository.GetByGuid(guid);
        if (result is null)
        {
            return NotFound("Id Not Found");
        }
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(Room room)// method create
    {
        var result = _roomRepository.Create(room);
        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }


    [HttpPut]
    public IActionResult Update(Room room)//method put Update tbl room
    {
        var result = _roomRepository.Update(room);
        if (!result)
        {
            return BadRequest("Failed To Update Data");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(Guid guid)//method delete tbl room
    {
        var room = _roomRepository.GetByGuid(guid);
        var result = _roomRepository.Delete(room);
        if (!result)
        {
            return BadRequest("Failed To Delete Data");
        }

        return Ok(result);
    }
}