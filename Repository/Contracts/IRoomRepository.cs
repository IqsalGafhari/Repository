using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IRoomRepository//membuat interface utk tbl room
{
    IEnumerable<Room> GetAll();
    Room? GetByGuid(Guid guid);
    Room? Create(Room room);
    bool Update(Room room);
    bool Delete(Room room);
}