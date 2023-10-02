using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IRoleRepository//membuat interface utk tbl role
{
    IEnumerable<Role> GetAll();
    Role? GetByGuid(Guid guid);
    Role? Create(Role role);
    bool Update(Role role);
    bool Delete(Role role);
}