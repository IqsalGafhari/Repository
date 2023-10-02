using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IAccountRoleRepository//membuat interface utk tbl account
{
    IEnumerable<AccountRole> GetAll();
    AccountRole? GetByGuid(Guid guid);
    AccountRole? Create(AccountRole accountRole);
    bool Update(AccountRole accountRole);
    bool Delete(AccountRole accountRole);
}