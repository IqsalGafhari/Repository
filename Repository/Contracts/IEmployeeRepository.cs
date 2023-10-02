using BookingManagementApp.Models;
using BookingManagementApp.Models;

namespace APBookingManagementAppI.Contracts;

public interface IEmployeeRepository//membuat interface utk tbl employee
{
    IEnumerable<Employee> GetAll();
    Employee? GetByGuid(Guid guid);
    Employee? Create(Employee employee);
    bool Update(Employee employee);
    bool Delete(Employee employee);
}