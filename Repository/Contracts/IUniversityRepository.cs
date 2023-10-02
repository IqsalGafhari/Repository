using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IUniversityRepository//membuat interface utk tbl university
{
    IEnumerable<University> GetAll();
    University? GetByGuid(Guid guid);
    University? Create(University university);
    bool Update(University university);
    bool Delete(University university);
}