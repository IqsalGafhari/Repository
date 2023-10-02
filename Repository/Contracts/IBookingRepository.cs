using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IBookingRepository//membuat interface utk tbl booking
{
    IEnumerable<Booking> GetAll();
    Booking? GetByGuid(Guid guid);
    Booking? Create(Booking booking);
    bool Update(Booking booking);
    bool Delete(Booking booking);
}