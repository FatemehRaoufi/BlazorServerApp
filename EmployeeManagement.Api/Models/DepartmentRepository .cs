using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EmployeeManagement.Api.Models;


    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;



        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        //public Department GetDepartment(int departmentId)
        //{
        //    return appDbContext.Departments
        //        .FirstOrDefault(d => d.DepartmentId == departmentId);
        //}

        //public IEnumerable<Department> GetDepartments()
        //{
        //    return appDbContext.Departments;
        //}
        //REST API
         async Task<Department> IDepartmentRepository.GetDepartment(int departmentId)
        {
            return await appDbContext.Departments
            .FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

         async Task<IEnumerable<Department>> IDepartmentRepository.GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }
    }
