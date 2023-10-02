using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IAccountRepository//membuat interface utk tbl account
{
    IEnumerable<Account> GetAll();
    Account? GetByGuid(Guid guid);
    Account? Create(Account account);
    bool Update(Account account);
    bool Delete(Account account);
}