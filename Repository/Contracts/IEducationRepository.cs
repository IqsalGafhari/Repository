using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IEducationRepository//membuat interface utk tbl education
{
    IEnumerable<Education> GetAll();
    Education? GetByGuid(Guid guid);
    Education? Create(Education education);
    bool Update(Education education);
    bool Delete(Education education);
}