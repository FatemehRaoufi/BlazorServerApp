using EmployeeManagement.Models;

//Blazor Web Project - IDepartmentService Interface
namespace BlazorServerApp.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}
