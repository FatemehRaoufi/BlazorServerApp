using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        //IEnumerable<Department> GetDepartments();
        //Department GetDepartment(int departmentId);

        //Rest API
        //we want them to be executed asynchronously so these methods return a task.
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }

}