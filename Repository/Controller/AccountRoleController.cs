using APBookingManagementAppI.Contracts;
using BookingManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagementApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountRoleController : ControllerBase
{
    private readonly IAccountRoleRepository _accountRoleRepository;

    public AccountRoleController(IAccountRoleRepository accountRoleRepository)
    {
        _accountRoleRepository = accountRoleRepository;
    }

    [HttpGet]
    public IActionResult GetAll()//method utk get all
    {
        var result = _accountRoleRepository.GetAll();
        if (!result.Any())
        {
            return NotFound("Data Not Found");
        }

        return Ok(result);
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)// method get by id
    {
        var result = _accountRoleRepository.GetByGuid(guid);
        if (result is null)
        {
            return NotFound("Id Not Found");
        }
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create(AccountRole accountRole)// method create
    {
        var result = _accountRoleRepository.Create(accountRole);
        if (result is null)
        {
            return BadRequest("Failed to create data");
        }

        return Ok(result);
    }


    [HttpPut]
    public IActionResult Update(AccountRole accountRole)//method put Update tbl accountrole
    {
        var result = _accountRoleRepository.Update(accountRole);
        if (!result)
        {
            return BadRequest("Failed To Update Data");
        }

        return Ok(result);
    }

    [HttpDelete]
    public IActionResult Delete(Guid guid)//method delete tbl accountRole
    {
        var accountRole = _accountRoleRepository.GetByGuid(guid);
        var result = _accountRoleRepository.Delete(accountRole);
        if (!result)
        {
            return BadRequest("Failed To Delete Data");
        }

        return Ok(result);
    }
}