using employeewebapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeewebapi.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        public IEnumerable<Employee> GetAllEmployee();

        // public Employee create(Employee employee);

        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);




    }
}
